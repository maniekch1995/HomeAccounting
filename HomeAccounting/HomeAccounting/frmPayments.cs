using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    //TODO doadć !! wykresy - > typ do kwoty + dodać możliwość wybrania zakresu dat
    public partial class frmPayments : Form
    {
        private Payments _payments = new Payments();
        private bool _canChange = false;

        private List<Payments> _paymentsLst = new List<Payments>();
        public frmPayments()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //sprawdzic czy jest uzupelnione 
            if (txtValue.Text != "" & txtPlace.Text != "" & txtType.Text != "" & dateTimePickPayments.Value.ToString() != "" && txtNamePayment.Text != "")
            {
                _payments.ValuePayment = decimal.Parse(txtValue.Text);
                _payments.PlaceName = txtPlace.Text.Trim();
                _payments.TypeName = txtType.Text.Trim();
                _payments.DatePayment = dateTimePickPayments.Value;
                _payments.ShopName = txtNamePayment.Text.Trim();

                using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                {
                    if (_payments.IdPayment == 0) //insert
                        db.Payments.Add(_payments);
                    else //update
                        db.Entry(_payments).State = System.Data.Entity.EntityState.Modified; //ustawienie flagi na update
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_canChange)
            {
                if (MessageBox.Show("Czy chcesz usunąć wpis?", "Usuwanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                    {
                        var entry = db.Entry(_payments);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Payments.Attach(_payments);
                        }
                        db.Payments.Remove(_payments);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtValue.Text = "";
            txtPlace.Text = "";
            txtType.Text = "";
            txtNamePayment.Text = "";
            dateTimePickPayments.Value = DateTime.Now;
            _canChange = false;
        }

        private void frmPayments_Load(object sender, EventArgs e)
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
                            "Typ",
                            "Miejsce"
                        };
                    cmb.DataSource = dataSource;
                    break;
                case "cmbFiledSort":
                    var dataSourceField = new List<string>
                        {
                            "Kwota",
                            "Data",
                            "Nazwa",
                            "Typ",
                            "Miejsce"
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
                _paymentsLst = db.Payments.ToList<Payments>();
                gridViewPayments.DataSource = _paymentsLst;
            }
        }

        private void gridViewPayments_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewPayments.CurrentRow.Index != -1)
            {
                _canChange = true;
                _payments.IdPayment = Convert.ToInt32(gridViewPayments.CurrentRow.Cells["IdPayment"].Value);
                using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                {
                    _payments = db.Payments.Where(id => id.IdPayment == _payments.IdPayment).FirstOrDefault();

                    txtValue.Text = _payments.ValuePayment.ToString();
                    txtPlace.Text = _payments.PlaceName;
                    txtType.Text = _payments.TypeName;
                    dateTimePickPayments.Value = _payments.DatePayment.Value;
                    txtNamePayment.Text = _payments.ShopName;
                }
            }
        }

        private void btnRemoveFiltr_Click(object sender, EventArgs e)
        {
            txtValueFilter.Text = "";
            ReloadGrid();
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
                        List<Payments> payments = new List<Payments>();
                        payments = db.Payments.ToList<Payments>();
                        List<Payments> paymentsFiltered = new List<Payments>();

                        switch (cmbField.SelectedValue.ToString())
                        {
                            case "Kwota":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment == decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment == decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment == decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                if (cmbOperand.SelectedValue.ToString() == "<")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment < decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment < decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment < decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                if (cmbOperand.SelectedValue.ToString() == ">")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment > decimal.Parse(txtValueFilter.Text)).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment > decimal.Parse(txtValueFilter.Text)).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.ValuePayment < decimal.Parse(txtValueFilter.Text)).ToList();
                                    }
                                }
                                gridViewPayments.DataSource = paymentsFiltered;
                                break;
                            case "Data":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.DatePayment.ToString().Remove(10, 9) == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.DatePayment.ToString().Remove(10, 9) == txtValueFilter.Text).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.DatePayment.ToString().Remove(10, 9) == txtValueFilter.Text).ToList();
                                    }

                                }
                                gridViewPayments.DataSource = paymentsFiltered;
                                break;
                            case "Nazwa":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ShopName == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.ShopName == txtValueFilter.Text).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.ShopName == txtValueFilter.Text).ToList();
                                    }

                                }
                                gridViewPayments.DataSource = paymentsFiltered;
                                break;
                            case "Typ":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.TypeName == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.TypeName == txtValueFilter.Text).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.TypeName == txtValueFilter.Text).ToList();
                                    }
                                }
                                gridViewPayments.DataSource = paymentsFiltered;
                                break;
                            case "Miejsce":
                                if (cmbOperand.SelectedValue.ToString() == "=")
                                {
                                    if (cmbSortType.SelectedValue.ToString() == "Malejące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.PlaceName == txtValueFilter.Text).ToList().OrderByDescending(o => o.ValuePayment).ToList();
                                    }
                                    else if (cmbSortType.SelectedValue.ToString() == "Rosnące")
                                    {
                                        paymentsFiltered = payments.Where(p => p.PlaceName == txtValueFilter.Text).ToList().OrderBy(o => o.ValuePayment).ToList();
                                    }
                                    else
                                    {
                                        paymentsFiltered = payments.Where(p => p.PlaceName == txtValueFilter.Text).ToList();
                                    }
                                }
                                gridViewPayments.DataSource = paymentsFiltered;
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

        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboBoxFilter(cmbOperand);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            // if(cmbField.SelectedValue.ToString()!= "")
            frmCharts frm = new frmCharts("Kwota/TypWydatku", _paymentsLst, null, false,dtpDateFrom.Value, dtpDateTo.Value); //+cmbField.SelectedValue.ToString()
            frm.ShowDialog();
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

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbField.SelectedIndex.ToString() == "Kwota")
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
    }
}
