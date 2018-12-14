using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HomeAccounting
{
    public partial class frmCharts : Form
    {
        private string _nameSeries = "";
        private List<Payments> _paymnetsLst;
        private List<Incomes> _incomesLst;
        private bool _all = false;
        private DateTime _dateFrom;
        private DateTime _dateTo; 

        public frmCharts(string nameSeries, List<Payments> paymentsLst, List<Incomes> incomesLst,bool all)
        {
            InitializeComponent();
            _nameSeries = nameSeries;
            _paymnetsLst = paymentsLst;
            _incomesLst = incomesLst;
            _all = all;
            //dodać zakres daty od do zeby były w danym zarkesie
        }


        public frmCharts(string nameSeries, List<Payments> paymentsLst, List<Incomes> incomesLst, bool all, DateTime dateFrom, DateTime dateTo )
        {
            InitializeComponent();
            _nameSeries = nameSeries;
            _paymnetsLst = paymentsLst;
            _incomesLst = incomesLst;
            _all = all;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            //dodać zakres daty od do zeby były w danym zarkesie
        }

        private void frmChars_Load(object sender, EventArgs e)
        {
            ClearChart();
            PrepareSeries();
            PreparePoints();  
        }
        private void ClearChart()
        {
            chart.Series.Clear();
        }

        private void PrepareSeries()
        {
            if(_nameSeries != "")
            {
                chart.Series.Add(_nameSeries);
            }            
        }

        private void PreparePoints()
        {
            if(_all)
            {
                using (OCTOPUSEntities4 db = new OCTOPUSEntities4())
                {
                    List<Payments> _paymentsLst = new List<Payments>();
                    _paymentsLst = db.Payments.ToList<Payments>();
                    chart.Series.Add("Przychody");

                    List<Incomes> _incomesLst = new List<Incomes>();
                    _incomesLst = db.Incomes.ToList<Incomes>();
                    chart.Series.Add("Wydatki");

                    foreach (Incomes inc in _incomesLst)
                    {
                        chart.Series["Przychody"].Points.AddXY(inc.DateIncome, inc.ValueOfIncome);
                        chart.Series["Przychody"]["PixelPointWidth"] = "15";
                    }
                    foreach (Payments payment in _paymentsLst)
                    {
                        chart.Series["Wydatki"].Points.AddXY(payment.DatePayment, payment.ValuePayment);
                        chart.Series["Wydatki"]["PixelPointWidth"] = "15";
                    }
                }                
            }
            else
            {
                int counterOfPoint = 0;
                if (_incomesLst != null )
                {
                    // _incomesLst.Where(incIt => incIt.DateIncome > _dateFrom && incIt.DateIncome < _dateTo).GroupBy(grp => grp.TypeIncome).ToList()
                    //tworzenie wykresu wydatków                   
                    foreach (Incomes inc in _incomesLst.Where(incIt => incIt.DateIncome > _dateFrom && incIt.DateIncome < _dateTo).Distinct().ToList())
                    {
                        //chart.Series[_nameSeries].Points.AddXY(inc.TypeIncome, inc.ValueOfIncome);
                        chart.Series[_nameSeries].Points.AddXY(inc.TypeIncome, inc.ValueOfIncome);// _incomesLst.Where(y=>y.TypeIncome == inc.TypeIncome).Sum(x=>x.ValueOfIncome).Value);       
                        chart.Series[_nameSeries].Points.ElementAt(counterOfPoint).ToolTip = inc.ValueOfIncome.ToString();
                        counterOfPoint++;
                    }
                }
                else
                {
                    //tworzenie wykresu przychodów
                    foreach (Payments payment in _paymnetsLst.Where(payIt => payIt.DatePayment > _dateFrom && payIt.DatePayment < _dateTo).ToList())
                    {
                        chart.Series[_nameSeries].Points.AddXY(payment.TypeName, payment.ValuePayment);
                        chart.Series[_nameSeries].Points.ElementAt(counterOfPoint).ToolTip = payment.ValuePayment.ToString();
                        counterOfPoint++;
                    }
                }
                SetBarWidth();
            }          
            SetScrollbars();
        }
        private void SetBarWidth()
        {
            if(chart.Series.Count >0)
            {
                chart.Series[_nameSeries]["PixelPointWidth"] = "15";
                chart.Series[_nameSeries].Color = Color.Blue;
            }           
        }

        private void SetScrollbars()
        {
            chart.ChartAreas["Area1"].AxisY.ScrollBar.Size = 10;
            chart.ChartAreas["Area1"].AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart.ChartAreas["Area1"].AxisY.ScrollBar.IsPositionedInside = true;
            chart.ChartAreas["Area1"].AxisY.ScrollBar.Enabled = true;


            chart.ChartAreas["Area1"].AxisX.ScrollBar.Size = 10;
            chart.ChartAreas["Area1"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart.ChartAreas["Area1"].AxisX.ScrollBar.IsPositionedInside = true;
            chart.ChartAreas["Area1"].AxisX.ScrollBar.Enabled = true;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
