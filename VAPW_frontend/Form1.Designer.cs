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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Porsche).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vstupniVrata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vyjezdoveVrata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            vstupniVrata.Location = new Point(469, 426);
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
            jetDovnitr_btn.Click += jetDovnitr_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(529, 25);
            label1.Name = "label1";
            label1.Size = new Size(251, 47);
            label1.TabIndex = 11;
            label1.Text = "Freaky Mytíčko";
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
            vyjet_btn.Click += vyjet_btn_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1008, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(851, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(907, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(975, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(102, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(786, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 666);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Porsche).EndInit();
            ((System.ComponentModel.ISupportInitialize)barak).EndInit();
            ((System.ComponentModel.ISupportInitialize)vstupniVrata).EndInit();
            ((System.ComponentModel.ISupportInitialize)vyjezdoveVrata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
