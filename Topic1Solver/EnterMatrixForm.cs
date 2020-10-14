using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Topic1Solver
{
    public partial class EnterMatrixForm : Form
    {
        private int _matrixSize;

        public double[,] Matrix { get; set; }

        public int MyProperty { get; set; }
        public EnterMatrixForm(int matrixSize, string label)
        {
            InitializeComponent();
            _matrixSize = matrixSize;
            labelText.Text = label;

            dataGridView.RowCount = matrixSize;
            dataGridView.ColumnCount = matrixSize;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[_matrixSize, _matrixSize];
            int rows = _matrixSize;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (dataGridView[j, i].Value != null)
                    {
                        var stringValue = dataGridView[j, i].Value.ToString();
                        if (double.TryParse(stringValue, out double val))
                        {
                            matrix[i, j] = val;
                        }
                        else
                        {
                            var twoParts = stringValue.Split('/');
                            var numerator = double.Parse(twoParts[0]);
                            var denomenator = double.Parse(twoParts[1]);

                            matrix[i, j] = numerator / denomenator;
                        }
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            Matrix = matrix;

            Close();
        }
    }
}
