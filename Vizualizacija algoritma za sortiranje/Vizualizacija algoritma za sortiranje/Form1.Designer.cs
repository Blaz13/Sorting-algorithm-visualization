namespace Vizualizacija_algoritma_za_sortiranje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnLoad = new System.Windows.Forms.Button();
            this.bttnSort = new System.Windows.Forms.Button();
            this.cbOdabir = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.cbStep = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttnLoad
            // 
            this.bttnLoad.Location = new System.Drawing.Point(12, 12);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(75, 23);
            this.bttnLoad.TabIndex = 0;
            this.bttnLoad.Text = "Load";
            this.bttnLoad.UseVisualStyleBackColor = true;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // bttnSort
            // 
            this.bttnSort.Location = new System.Drawing.Point(258, 12);
            this.bttnSort.Name = "bttnSort";
            this.bttnSort.Size = new System.Drawing.Size(75, 23);
            this.bttnSort.TabIndex = 1;
            this.bttnSort.Text = "Sort";
            this.bttnSort.UseVisualStyleBackColor = true;
            this.bttnSort.Click += new System.EventHandler(this.bttnSort_Click);
            // 
            // cbOdabir
            // 
            this.cbOdabir.FormattingEnabled = true;
            this.cbOdabir.Items.AddRange(new object[] {
            "Insertion",
            "Selection",
            "Bubble",
            "Quick",
            "Merge",
            "Heap",
            "Comb",
            "Shell",
            "Counting"});
            this.cbOdabir.Location = new System.Drawing.Point(104, 12);
            this.cbOdabir.Name = "cbOdabir";
            this.cbOdabir.Size = new System.Drawing.Size(121, 21);
            this.cbOdabir.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(359, 21);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(101, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Number of elements";
            // 
            // cbStep
            // 
            this.cbStep.AutoSize = true;
            this.cbStep.Location = new System.Drawing.Point(13, 42);
            this.cbStep.Name = "cbStep";
            this.cbStep.Size = new System.Drawing.Size(48, 17);
            this.cbStep.TabIndex = 4;
            this.cbStep.Text = "Step";
            this.cbStep.UseVisualStyleBackColor = true;
            this.cbStep.CheckedChanged += new System.EventHandler(this.cbStep_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.cbStep);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.cbOdabir);
            this.Controls.Add(this.bttnSort);
            this.Controls.Add(this.bttnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.Button bttnSort;
        private System.Windows.Forms.ComboBox cbOdabir;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.CheckBox cbStep;
    }
}

