using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class frmIncomes : Form
    {
        private Incomes _incom = new Incomes();
        private bool _canChange = false;
        private List<Incomes> _incomesLst = new List<Incomes>();
        public frmIncomes()
        {
            InitializeComponent();
        }


        private void frmIncomes_Load(object sender, EventArgs e)
        {
            ReloadGrid();
            LoadComboBoxFilter(cmbField);
            LoadComboBoxFilter(cmbOperand);
            LoadComboBoxFilter(cmbSortType);
        }

        private void LoadComboBoxFilter(ComboBox cmb)
        {
            switch (cmb.Name)
            {
                case "cmbField":
                    var dataSource = new List<string>
                        {
                            "Kwota",
                            "Data",
                            "Nazwa",
                            "Typ"
                        };
                    cmb.DataSource = dataSource;
                    break;
                case "cmbFiledSort":
                    var dataSourceField = new List<string>
                        {
                            "Kwota",
                            "Data",
                            "Nazwa",
                            "Typ"
                        };
                    cmb.DataSource = dataSourceField;
                    break;
                case "cmbOperand":
                    var dataSourceOp = new List<string>
                        {
                            "="
                        };
                    if (cmbField.SelectedValue.ToString() == "Kwota")
                    {
                        dataSourceOp.Add(">");
                        dataSourceOp.Add("<");
                    }
                    cmb.DataSource = dataSourceOp;
                    break;
                case "cmbSortType":
                    var dataSourceTyp = new List<string>
                        {
                            "Malejące",
                            "Rosnące"
                        };
                    cmb.DataSource = dataSourceTyp;
                    break;
            }
        }

        private void ReloadGrid()
        {
            using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
            {
                _incomesLst = db.Incomes.ToList<Incomes>();
                gridViewIncomes.DataSource = _incomesLst;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //sprawdzic czy jest uzupelnione 
            if (txtValue.Text != "" & txtName.Text != "" & txtType.Text != "" & dateTimePicekIncome.Value.ToString() != "")
            {
                _incom.ValueOfIncome = decimal.Parse(txtValue.Text);
                _incom.NameIncome = txtName.Text.Trim();
                _incom.TypeIncome = txtType.Text.Trim();
                _incom.DateIncome = dateTimePicekIncome.Value;

                using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                {
                    if (_incom.IdIncomes == 0) //insert
                        db.Incomes.Add(_incom);
                    else //update
                        db.Entry(_incom).State = System.Data.Entity.EntityState.Modified; //ustawienie flagi na update
                    db.SaveChanges();
                }
                ReloadGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Uzupełnij dane - następnie dodaj");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_canChange)
            {
                if (MessageBox.Show("Czy chcesz usunąć wpis?", "Usuwanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                    {
                        var entry = db.Entry(_incom);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Incomes.Attach(_incom);
                        }
                        db.Incomes.Remove(_incom);
                        db.SaveChanges();
                        ReloadGrid();
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kliknij 2x na wiersz, który chcesz usunąć - następnie usuń");
            }
        }

        private void gridViewIncomes_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewIncomes.CurrentRow.Index != -1)
            {
                _canChange = true;
                _incom.IdIncomes = Convert.ToInt32(gridViewIncomes.CurrentRow.Cells["IdIncomes"].Value);
                using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                {
                    _incom = db.Incomes.Where(id => id.IdIncomes == _incom.IdIncomes).FirstOrDefault();

                    txtValue.Text = _incom.ValueOfIncome.ToString();
                    txtName.Text = _incom.NameIncome;
                    txtType.Text = _incom.TypeIncome;
                    dateTimePicekIncome.Value = _incom.DateIncome.Value;
                }
            }
        }

        private void Clear()
        {
            txtValue.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            dateTimePicekIncome.Value = DateTime.Now;
            _canChange = false;
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // tylko 1 punkt dziesiętny
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
           
            if (cmbField.SelectedValue.ToString() != "" && cmbOperand.SelectedValue.ToString() != "" && txtValueFilter.Text != "")
            {
                decimal x = 0;
                if (cmbField.SelectedValue.ToString() == "Kwota" && decimal.TryParse(txtValueFilter.Text, out x))
                {
                    using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                    {
                        List<Incomes> incomes = new List<Incomes>();
                        incomes = db.Incomes.ToList<Incomes>();
                        List<Incomes> incomesFiltered = new List<Incomes>();

                        switch (cmbField.SelectedValue.ToString())
                        {
                            case "Kwota":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome == decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome == decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome == decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                if (cmbOperand.SelectedValue.ToString() == "<")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome < decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome < decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome < decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                if (cmbOperand.SelectedValue.ToString() == ">")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome > decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome > decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.ValueOfIncome < decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                gridViewIncomes.DataSource = incomesFiltered;
                                break;
                            case "Data":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.DateIncome.ToString().Remove(10, 9) == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.DateIncome.ToString().Remove(10, 9) == txtValueFilter.Text).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.DateIncome.ToString().Remove(10, 9) == txtValueFilter.Text).ToList();
                                    }

                                }
                                gridViewIncomes.DataSource = incomesFiltered;
                                break;
                            case "Nazwa":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.NameIncome == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.NameIncome == txtValueFilter.Text).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.NameIncome == txtValueFilter.Text).ToList();
                                    }

                                }
                                gridViewIncomes.DataSource = incomesFiltered;
                                break;
                            case "Typ":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.TypeIncome == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValueOfIncome).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        incomesFiltered = incomes.Where(p => p.TypeIncome == txtValueFilter.Text).ToList().OrderBy(o => o.ValueOfIncome).ToList();
                                    }
                                    else
                                    {
                                        incomesFiltered = incomes.Where(p => p.TypeIncome == txtValueFilter.Text).ToList();
                                    }
                                }
                                gridViewIncomes.DataSource = incomesFiltered;
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Popraw dane!!");
                }
            }
        }

        private void cmbField_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadComboBoxFilter(cmbOperand);
        }

        private void btnRemoveFiltr_Click(object sender, EventArgs e)
        {
            txtValueFilter.Text = "";
            ReloadGrid();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
           // if(cmbField.SelectedValue.ToString()!= "")
                //frmCharts frm = new frmCharts("Kwota/TypPrzychodu", null, _incomesLst,false); //+cmbField.SelectedValue.ToString()
                //frm.ShowDialog();                    
        }

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbField.SelectedValue.ToString() == "Kwota")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
                // tylko 1 punkt dziesiętny
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCharts frm = new frmCharts("Kwota/TypPrzychodu", null, _incomesLst, false, dtpDateFrom.Value, dtpDateTo.Value); //+cmbField.SelectedValue.ToString()
            frm.ShowDialog();
        }
    }
}

