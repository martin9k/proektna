namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.igraliste = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.igrazavrsi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topka = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.igraliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.SuspendLayout();
            // 
            // igraliste
            // 
            this.igraliste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.igraliste.Controls.Add(this.textBox1);
            this.igraliste.Controls.Add(this.label2);
            this.igraliste.Controls.Add(this.listBox1);
            this.igraliste.Controls.Add(this.igrazavrsi);
            this.igraliste.Controls.Add(this.label1);
            this.igraliste.Controls.Add(this.topka);
            this.igraliste.Controls.Add(this.raket);
            this.igraliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.igraliste.Location = new System.Drawing.Point(0, 0);
            this.igraliste.Name = "igraliste";
            this.igraliste.Size = new System.Drawing.Size(496, 301);
            this.igraliste.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(112, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(37, 17);
            this.listBox1.TabIndex = 10;
            this.listBox1.Visible = false;
            // 
            // igrazavrsi
            // 
            this.igrazavrsi.AutoSize = true;
            this.igrazavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrazavrsi.ForeColor = System.Drawing.Color.Maroon;
            this.igrazavrsi.Location = new System.Drawing.Point(1, 114);
            this.igrazavrsi.Name = "igrazavrsi";
            this.igrazavrsi.Size = new System.Drawing.Size(625, 25);
            this.igrazavrsi.TabIndex = 3;
            this.igrazavrsi.Text = "Igrata Zavrsi F1 za restart f2 za lista na poeni esc za izlez";
            this.igrazavrsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // topka
            // 
            this.topka.BackColor = System.Drawing.Color.Black;
            this.topka.Location = new System.Drawing.Point(115, 101);
            this.topka.Name = "topka";
            this.topka.Size = new System.Drawing.Size(10, 10);
            this.topka.TabIndex = 1;
            this.topka.TabStop = false;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.Black;
            this.raket.Location = new System.Drawing.Point(147, 278);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(100, 20);
            this.raket.TabIndex = 0;
            this.raket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 301);
            this.Controls.Add(this.igraliste);
            this.Name = "Main";
            this.Text = "Main";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.igraliste.ResumeLayout(false);
            this.igraliste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel igraliste;
        private System.Windows.Forms.PictureBox topka;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label igrazavrsi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
       
    }
}