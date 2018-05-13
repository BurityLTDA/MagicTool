namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFinalValue = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cboxFrom = new System.Windows.Forms.ComboBox();
            this.cboxTo = new System.Windows.Forms.ComboBox();
            this.txtboxInputValue = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalValue
            // 
            this.lblFinalValue.AutoSize = true;
            this.lblFinalValue.Location = new System.Drawing.Point(574, 118);
            this.lblFinalValue.Name = "lblFinalValue";
            this.lblFinalValue.Size = new System.Drawing.Size(22, 13);
            this.lblFinalValue.TabIndex = 0;
            this.lblFinalValue.Text = "0.0";
            // 
            // btnSwap
            // 
            this.btnSwap.Image = ((System.Drawing.Image)(resources.GetObject("btnSwap.Image")));
            this.btnSwap.Location = new System.Drawing.Point(388, 76);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(30, 34);
            this.btnSwap.TabIndex = 3;
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxFrom
            // 
            this.cboxFrom.FormattingEnabled = true;
            this.cboxFrom.Items.AddRange(new object[] {
            "Dolar",
            "Real",
            "Euro",
            "Iene"});
            this.cboxFrom.Location = new System.Drawing.Point(151, 84);
            this.cboxFrom.Name = "cboxFrom";
            this.cboxFrom.Size = new System.Drawing.Size(121, 21);
            this.cboxFrom.TabIndex = 4;
            // 
            // cboxTo
            // 
            this.cboxTo.FormattingEnabled = true;
            this.cboxTo.Items.AddRange(new object[] {
            "Dolar",
            "Real",
            "Euro",
            "Iene"});
            this.cboxTo.Location = new System.Drawing.Point(528, 84);
            this.cboxTo.Name = "cboxTo";
            this.cboxTo.Size = new System.Drawing.Size(121, 21);
            this.cboxTo.TabIndex = 5;
            // 
            // txtboxInputValue
            // 
            this.txtboxInputValue.Location = new System.Drawing.Point(161, 111);
            this.txtboxInputValue.Name = "txtboxInputValue";
            this.txtboxInputValue.Size = new System.Drawing.Size(100, 20);
            this.txtboxInputValue.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Image = ((System.Drawing.Image)(resources.GetObject("btnConvert.Image")));
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.Location = new System.Drawing.Point(349, 201);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 42);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "converter";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(182, 68);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(68, 13);
            this.lblDe.TabIndex = 8;
            this.lblDe.Text = "Converter de";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(574, 68);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(29, 13);
            this.lblPara.TabIndex = 9;
            this.lblPara.Text = "Para";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtboxInputValue);
            this.Controls.Add(this.cboxTo);
            this.Controls.Add(this.cboxFrom);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblFinalValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalValue;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cboxFrom;
        private System.Windows.Forms.ComboBox cboxTo;
        private System.Windows.Forms.TextBox txtboxInputValue;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPara;
    }
}

