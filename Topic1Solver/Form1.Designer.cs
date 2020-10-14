namespace Topic1Solver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownChoicer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownObjects = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCriteria = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChoicer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriteria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter numer of choicers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter numer of criteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter numer of objects";
            // 
            // numericUpDownChoicer
            // 
            this.numericUpDownChoicer.Location = new System.Drawing.Point(211, 7);
            this.numericUpDownChoicer.Name = "numericUpDownChoicer";
            this.numericUpDownChoicer.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownChoicer.TabIndex = 1;
            // 
            // numericUpDownObjects
            // 
            this.numericUpDownObjects.Location = new System.Drawing.Point(211, 146);
            this.numericUpDownObjects.Name = "numericUpDownObjects";
            this.numericUpDownObjects.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownObjects.TabIndex = 1;
            // 
            // numericUpDownCriteria
            // 
            this.numericUpDownCriteria.Location = new System.Drawing.Point(211, 78);
            this.numericUpDownCriteria.Name = "numericUpDownCriteria";
            this.numericUpDownCriteria.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownCriteria.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(418, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 37);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownCriteria);
            this.Controls.Add(this.numericUpDownObjects);
            this.Controls.Add(this.numericUpDownChoicer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChoicer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCriteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownChoicer;
        private System.Windows.Forms.NumericUpDown numericUpDownObjects;
        private System.Windows.Forms.NumericUpDown numericUpDownCriteria;
        private System.Windows.Forms.Button buttonSave;
    }
}

