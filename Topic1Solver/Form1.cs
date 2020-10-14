using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic1Solver
{
    public partial class Form1 : Form
    {
        private int qChoicer, qCriteria, qObjects;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            qChoicer = (int)numericUpDownChoicer.Value;
            qCriteria = (int)numericUpDownCriteria.Value;
            qObjects = (int)numericUpDownObjects.Value;

            var solver = new Solver(qChoicer, qCriteria, qObjects);

            var matrixForm = new EnterMatrixForm(qChoicer, "Enter choicer matrix");
            matrixForm.ShowDialog();
            solver.SetChoicerMatrix(matrixForm.Matrix);


            var listCriteriaMatrix = new List<double[,]>();
            for(int i = 0; i < qChoicer; i++)
            {
                var form = new EnterMatrixForm(qCriteria, $"Enter criteria matrix for {i} criterion");
                form.ShowDialog();

                listCriteriaMatrix.Add(form.Matrix);
            }
            solver.SetCrtiteriaMatrix(listCriteriaMatrix);

            var listObjectMatrix = new List<double[,]>();
            for (int i = 0; i < qChoicer*qCriteria; i++)
            {
                var form = new EnterMatrixForm(qObjects, $"Enter obejct matrix for {i} object");
                form.ShowDialog();

                listObjectMatrix.Add(form.Matrix);
            }
            solver.SetObjectsMatrix(listObjectMatrix);

            var best = solver.FindBestObject();

            var coef = best.coef.Select(x => x.ToString()).Aggregate((x, y) => $"{x}; {y}");

            MessageBox.Show($"{best.best} \n {coef}");
        }
    }
}
