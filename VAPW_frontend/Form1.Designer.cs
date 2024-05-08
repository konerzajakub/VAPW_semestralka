namespace VAPW_frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Porsche = new PictureBox();
            barak = new PictureBox();
            vstupniVrata = new PictureBox();
            vyjezdoveVrata = new PictureBox();
            prijetPred_btn = new Button();
            jetDovnitr_btn = new Button();
            label1 = new Label();
            vyjet_btn = new Button();
            vyberNapojeniNaModel = new Button();
            predniSemafor = new Panel();
            zadniSemafor = new Panel();
            ((System.ComponentModel.ISupportInitialize)Porsche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vstupniVrata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vyjezdoveVrata).BeginInit();
            SuspendLayout();
            // 
            // Porsche
            // 
            Porsche.Image = Properties.Resources.car;
            Porsche.Location = new Point(35, 478);
            Porsche.Name = "Porsche";
            Porsche.Size = new Size(227, 154);
            Porsche.SizeMode = PictureBoxSizeMode.StretchImage;
            Porsche.TabIndex = 0;
            Porsche.TabStop = false;
            // 
            // barak
            // 
            barak.ErrorImage = (Image)resources.GetObject("barak.ErrorImage");
            barak.Image = (Image)resources.GetObject("barak.Image");
            barak.InitialImage = (Image)resources.GetObject("barak.InitialImage");
            barak.Location = new Point(508, 86);
            barak.Name = "barak";
            barak.Size = new Size(424, 568);
            barak.SizeMode = PictureBoxSizeMode.StretchImage;
            barak.TabIndex = 3;
            barak.TabStop = false;
            // 
            // vstupniVrata
            // 
            vstupniVrata.Image = (Image)resources.GetObject("vstupniVrata.Image");
            vstupniVrata.Location = new Point(476, 423);
            vstupniVrata.Name = "vstupniVrata";
            vstupniVrata.Size = new Size(45, 206);
            vstupniVrata.SizeMode = PictureBoxSizeMode.StretchImage;
            vstupniVrata.TabIndex = 4;
            vstupniVrata.TabStop = false;
            // 
            // vyjezdoveVrata
            // 
            vyjezdoveVrata.Image = (Image)resources.GetObject("vyjezdoveVrata.Image");
            vyjezdoveVrata.Location = new Point(906, 423);
            vyjezdoveVrata.Name = "vyjezdoveVrata";
            vyjezdoveVrata.Size = new Size(46, 209);
            vyjezdoveVrata.SizeMode = PictureBoxSizeMode.StretchImage;
            vyjezdoveVrata.TabIndex = 5;
            vyjezdoveVrata.TabStop = false;
            // 
            // prijetPred_btn
            // 
            prijetPred_btn.Location = new Point(48, 211);
            prijetPred_btn.Name = "prijetPred_btn";
            prijetPred_btn.Size = new Size(122, 59);
            prijetPred_btn.TabIndex = 8;
            prijetPred_btn.Text = "jet autem";
            prijetPred_btn.UseVisualStyleBackColor = true;
            prijetPred_btn.Click += prijetPred_btn_Click;
            // 
            // jetDovnitr_btn
            // 
            jetDovnitr_btn.Location = new Point(295, 211);
            jetDovnitr_btn.Name = "jetDovnitr_btn";
            jetDovnitr_btn.Size = new Size(122, 57);
            jetDovnitr_btn.TabIndex = 9;
            jetDovnitr_btn.Text = "vjet dovnitř";
            jetDovnitr_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 47);
            label1.TabIndex = 11;
            label1.Text = "Mytíčko";
            label1.Click += label1_Click;
            // 
            // vyjet_btn
            // 
            vyjet_btn.Location = new Point(1008, 122);
            vyjet_btn.Name = "vyjet_btn";
            vyjet_btn.Size = new Size(148, 57);
            vyjet_btn.TabIndex = 12;
            vyjet_btn.Text = "vyjet z myčky";
            vyjet_btn.UseVisualStyleBackColor = true;
            // 
            // vyberNapojeniNaModel
            // 
            vyberNapojeniNaModel.Location = new Point(35, 61);
            vyberNapojeniNaModel.Name = "vyberNapojeniNaModel";
            vyberNapojeniNaModel.Size = new Size(399, 64);
            vyberNapojeniNaModel.TabIndex = 13;
            vyberNapojeniNaModel.Text = "Výběr způsobu napojení na model";
            vyberNapojeniNaModel.UseVisualStyleBackColor = true;
            vyberNapojeniNaModel.Click += button1_Click;
            // 
            // predniSemafor
            // 
            predniSemafor.BackColor = Color.Red;
            predniSemafor.Location = new Point(398, 349);
            predniSemafor.Name = "predniSemafor";
            predniSemafor.Size = new Size(65, 65);
            predniSemafor.TabIndex = 14;
            // 
            // zadniSemafor
            // 
            zadniSemafor.BackColor = Color.Red;
            zadniSemafor.Location = new Point(997, 349);
            zadniSemafor.Name = "zadniSemafor";
            zadniSemafor.Size = new Size(68, 64);
            zadniSemafor.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 666);
            Controls.Add(zadniSemafor);
            Controls.Add(predniSemafor);
            Controls.Add(vyberNapojeniNaModel);
            Controls.Add(vyjet_btn);
            Controls.Add(label1);
            Controls.Add(jetDovnitr_btn);
            Controls.Add(prijetPred_btn);
            Controls.Add(vyjezdoveVrata);
            Controls.Add(vstupniVrata);
            Controls.Add(barak);
            Controls.Add(Porsche);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Porsche).EndInit();
            ((System.ComponentModel.ISupportInitialize)barak).EndInit();
            ((System.ComponentModel.ISupportInitialize)vstupniVrata).EndInit();
            ((System.ComponentModel.ISupportInitialize)vyjezdoveVrata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Porsche;
        private PictureBox barak;
        private PictureBox vstupniVrata;
        private PictureBox vyjezdoveVrata;
        private Button prijetPred_btn;
        private Button jetDovnitr_btn;
        private Label label1;
        private Button vyjet_btn;
        private Button vyberNapojeniNaModel;
        private Panel predniSemafor;
        private Panel zadniSemafor;
    }
}
