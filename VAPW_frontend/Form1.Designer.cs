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
            Porsche.Location = new Point(40, 605);
            Porsche.Margin = new Padding(3, 4, 3, 4);
            Porsche.Name = "Porsche";
            Porsche.Size = new Size(259, 195);
            Porsche.SizeMode = PictureBoxSizeMode.StretchImage;
            Porsche.TabIndex = 0;
            Porsche.TabStop = false;
            // 
            // barak
            // 
            barak.ErrorImage = (Image)resources.GetObject("barak.ErrorImage");
            barak.Image = (Image)resources.GetObject("barak.Image");
            barak.InitialImage = (Image)resources.GetObject("barak.InitialImage");
            barak.Location = new Point(581, 109);
            barak.Margin = new Padding(3, 4, 3, 4);
            barak.Name = "barak";
            barak.Size = new Size(485, 719);
            barak.SizeMode = PictureBoxSizeMode.StretchImage;
            barak.TabIndex = 3;
            barak.TabStop = false;
            // 
            // vstupniVrata
            // 
            vstupniVrata.Image = (Image)resources.GetObject("vstupniVrata.Image");
            vstupniVrata.Location = new Point(536, 540);
            vstupniVrata.Margin = new Padding(3, 4, 3, 4);
            vstupniVrata.Name = "vstupniVrata";
            vstupniVrata.Size = new Size(51, 261);
            vstupniVrata.SizeMode = PictureBoxSizeMode.StretchImage;
            vstupniVrata.TabIndex = 4;
            vstupniVrata.TabStop = false;
            // 
            // vyjezdoveVrata
            // 
            vyjezdoveVrata.Image = (Image)resources.GetObject("vyjezdoveVrata.Image");
            vyjezdoveVrata.Location = new Point(1035, 536);
            vyjezdoveVrata.Margin = new Padding(3, 4, 3, 4);
            vyjezdoveVrata.Name = "vyjezdoveVrata";
            vyjezdoveVrata.Size = new Size(53, 265);
            vyjezdoveVrata.SizeMode = PictureBoxSizeMode.StretchImage;
            vyjezdoveVrata.TabIndex = 5;
            vyjezdoveVrata.TabStop = false;
            // 
            // prijetPred_btn
            // 
            prijetPred_btn.Location = new Point(55, 267);
            prijetPred_btn.Margin = new Padding(3, 4, 3, 4);
            prijetPred_btn.Name = "prijetPred_btn";
            prijetPred_btn.Size = new Size(139, 75);
            prijetPred_btn.TabIndex = 8;
            prijetPred_btn.Text = "jet autem";
            prijetPred_btn.UseVisualStyleBackColor = true;
            prijetPred_btn.Click += prijetPred_btn_Click;
            // 
            // jetDovnitr_btn
            // 
            jetDovnitr_btn.Location = new Point(337, 267);
            jetDovnitr_btn.Margin = new Padding(3, 4, 3, 4);
            jetDovnitr_btn.Name = "jetDovnitr_btn";
            jetDovnitr_btn.Size = new Size(139, 72);
            jetDovnitr_btn.TabIndex = 9;
            jetDovnitr_btn.Text = "vjet dovnitř";
            jetDovnitr_btn.UseVisualStyleBackColor = true;
            jetDovnitr_btn.Click += jetDovnitr_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(717, 38);
            label1.Name = "label1";
            label1.Size = new Size(204, 47);
            label1.TabIndex = 11;
            label1.Text = "Auto myčka";
            label1.Click += label1_Click;
            // 
            // vyjet_btn
            // 
            vyjet_btn.Location = new Point(1152, 155);
            vyjet_btn.Margin = new Padding(3, 4, 3, 4);
            vyjet_btn.Name = "vyjet_btn";
            vyjet_btn.Size = new Size(169, 72);
            vyjet_btn.TabIndex = 12;
            vyjet_btn.Text = "vyjet z myčky";
            vyjet_btn.UseVisualStyleBackColor = true;
            vyjet_btn.Click += vyjet_btn_Click;
            // 
            // vyberNapojeniNaModel
            // 
            vyberNapojeniNaModel.Location = new Point(40, 77);
            vyberNapojeniNaModel.Margin = new Padding(3, 4, 3, 4);
            vyberNapojeniNaModel.Name = "vyberNapojeniNaModel";
            vyberNapojeniNaModel.Size = new Size(456, 81);
            vyberNapojeniNaModel.TabIndex = 13;
            vyberNapojeniNaModel.Text = "Výběr způsobu napojení na model";
            vyberNapojeniNaModel.UseVisualStyleBackColor = true;
            vyberNapojeniNaModel.Click += button1_Click;
            // 
            // predniSemafor
            // 
            predniSemafor.BackColor = Color.Red;
            predniSemafor.Location = new Point(455, 442);
            predniSemafor.Margin = new Padding(3, 4, 3, 4);
            predniSemafor.Name = "predniSemafor";
            predniSemafor.Size = new Size(74, 82);
            predniSemafor.TabIndex = 14;
            // 
            // zadniSemafor
            // 
            zadniSemafor.BackColor = Color.Red;
            zadniSemafor.Location = new Point(1139, 442);
            zadniSemafor.Margin = new Padding(3, 4, 3, 4);
            zadniSemafor.Name = "zadniSemafor";
            zadniSemafor.Size = new Size(78, 81);
            zadniSemafor.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 844);
            Controls.Add(zadniSemafor);
            Controls.Add(predniSemafor);
            Controls.Add(vyjezdoveVrata);
            Controls.Add(vstupniVrata);
            Controls.Add(Porsche);
            Controls.Add(vyberNapojeniNaModel);
            Controls.Add(vyjet_btn);
            Controls.Add(label1);
            Controls.Add(jetDovnitr_btn);
            Controls.Add(prijetPred_btn);
            Controls.Add(barak);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
