namespace WindowsFormsApp1
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jedynka = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.motywyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dwójka = new System.Windows.Forms.Button();
            this.trójka = new System.Windows.Forms.Button();
            this.kasuj = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.równa_się = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zero = new System.Windows.Forms.Button();
            this.kropka = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mnożenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.kasuj_wszystko = new System.Windows.Forms.Button();
            this.szóstka = new System.Windows.Forms.Button();
            this.piątka = new System.Windows.Forms.Button();
            this.czwórka = new System.Windows.Forms.Button();
            this.dziewiątka = new System.Windows.Forms.Button();
            this.ósemka = new System.Windows.Forms.Button();
            this.siódemka = new System.Windows.Forms.Button();
            this.oblicz = new System.Windows.Forms.TextBox();
            this.pamiętamy = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jedynka
            // 
            this.jedynka.Location = new System.Drawing.Point(38, 260);
            this.jedynka.Name = "jedynka";
            this.jedynka.Size = new System.Drawing.Size(40, 40);
            this.jedynka.TabIndex = 0;
            this.jedynka.Text = "1";
            this.jedynka.UseVisualStyleBackColor = true;
            this.jedynka.Click += new System.EventHandler(this.button_Click);
            this.jedynka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motywyToolStripMenuItem1,
            this.kolorToolStripMenuItem,
            this.zamknijToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // motywyToolStripMenuItem1
            // 
            this.motywyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorToolStripMenuItem,
            this.zegarToolStripMenuItem});
            this.motywyToolStripMenuItem1.Name = "motywyToolStripMenuItem1";
            this.motywyToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.motywyToolStripMenuItem1.Text = "Motywy";
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem2.Text = "Motyw 1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem3.Text = "Motyw 2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem4.Text = "Motyw 3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // zegarToolStripMenuItem
            // 
            this.zegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.zegarToolStripMenuItem.Name = "zegarToolStripMenuItem";
            this.zegarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zegarToolStripMenuItem.Text = "Zegar";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem5.Text = "HH:mm:ss";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem6.Text = "mm:HH:ss";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem7.Text = "ss:mm:HH";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.kolorToolStripMenuItem.Text = "Kolor";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem8.Text = "Czerwony";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem9.Text = "Zielony";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem10.Text = "Niebieski";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // zamknijToolStripMenuItem1
            // 
            this.zamknijToolStripMenuItem1.Name = "zamknijToolStripMenuItem1";
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.zamknijToolStripMenuItem1_Click);
            // 
            // dwójka
            // 
            this.dwójka.Location = new System.Drawing.Point(84, 260);
            this.dwójka.Name = "dwójka";
            this.dwójka.Size = new System.Drawing.Size(40, 40);
            this.dwójka.TabIndex = 6;
            this.dwójka.Text = "2";
            this.dwójka.UseVisualStyleBackColor = true;
            this.dwójka.Click += new System.EventHandler(this.button_Click);
            this.dwójka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // trójka
            // 
            this.trójka.Location = new System.Drawing.Point(130, 260);
            this.trójka.Name = "trójka";
            this.trójka.Size = new System.Drawing.Size(40, 40);
            this.trójka.TabIndex = 7;
            this.trójka.Text = "3";
            this.trójka.UseVisualStyleBackColor = true;
            this.trójka.Click += new System.EventHandler(this.button_Click);
            this.trójka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // kasuj
            // 
            this.kasuj.Location = new System.Drawing.Point(222, 172);
            this.kasuj.Name = "kasuj";
            this.kasuj.Size = new System.Drawing.Size(40, 40);
            this.kasuj.TabIndex = 8;
            this.kasuj.Text = "CE";
            this.kasuj.UseVisualStyleBackColor = true;
            this.kasuj.Click += new System.EventHandler(this.kasuj_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(176, 304);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 40);
            this.plus.TabIndex = 9;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.dzialanie_Click);
            this.plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // równa_się
            // 
            this.równa_się.Location = new System.Drawing.Point(222, 260);
            this.równa_się.Name = "równa_się";
            this.równa_się.Size = new System.Drawing.Size(40, 86);
            this.równa_się.TabIndex = 10;
            this.równa_się.Text = "=";
            this.równa_się.UseVisualStyleBackColor = true;
            this.równa_się.Click += new System.EventHandler(this.ostatecznie_Click);
            this.równa_się.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 61);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zegar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(38, 304);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(86, 40);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // kropka
            // 
            this.kropka.Location = new System.Drawing.Point(130, 304);
            this.kropka.Name = "kropka";
            this.kropka.Size = new System.Drawing.Size(40, 40);
            this.kropka.TabIndex = 13;
            this.kropka.Text = ",";
            this.kropka.UseVisualStyleBackColor = true;
            this.kropka.Click += new System.EventHandler(this.button_Click);
            this.kropka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(176, 260);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 40);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.dzialanie_Click);
            this.minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mnożenie
            // 
            this.mnożenie.Location = new System.Drawing.Point(176, 216);
            this.mnożenie.Name = "mnożenie";
            this.mnożenie.Size = new System.Drawing.Size(40, 40);
            this.mnożenie.TabIndex = 15;
            this.mnożenie.Text = "*";
            this.mnożenie.UseVisualStyleBackColor = true;
            this.mnożenie.Click += new System.EventHandler(this.dzialanie_Click);
            this.mnożenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(176, 172);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(40, 40);
            this.dzielenie.TabIndex = 16;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzialanie_Click);
            this.dzielenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // kasuj_wszystko
            // 
            this.kasuj_wszystko.Location = new System.Drawing.Point(222, 216);
            this.kasuj_wszystko.Name = "kasuj_wszystko";
            this.kasuj_wszystko.Size = new System.Drawing.Size(40, 40);
            this.kasuj_wszystko.TabIndex = 17;
            this.kasuj_wszystko.Text = "C";
            this.kasuj_wszystko.UseVisualStyleBackColor = true;
            this.kasuj_wszystko.Click += new System.EventHandler(this.kasuj_wszystko_Click);
            // 
            // szóstka
            // 
            this.szóstka.Location = new System.Drawing.Point(130, 216);
            this.szóstka.Name = "szóstka";
            this.szóstka.Size = new System.Drawing.Size(40, 40);
            this.szóstka.TabIndex = 19;
            this.szóstka.Text = "6";
            this.szóstka.UseVisualStyleBackColor = true;
            this.szóstka.Click += new System.EventHandler(this.button_Click);
            this.szóstka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // piątka
            // 
            this.piątka.Location = new System.Drawing.Point(84, 216);
            this.piątka.Name = "piątka";
            this.piątka.Size = new System.Drawing.Size(40, 40);
            this.piątka.TabIndex = 20;
            this.piątka.Text = "5";
            this.piątka.UseVisualStyleBackColor = true;
            this.piątka.Click += new System.EventHandler(this.button_Click);
            this.piątka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // czwórka
            // 
            this.czwórka.Location = new System.Drawing.Point(38, 216);
            this.czwórka.Name = "czwórka";
            this.czwórka.Size = new System.Drawing.Size(40, 40);
            this.czwórka.TabIndex = 21;
            this.czwórka.Text = "4";
            this.czwórka.UseVisualStyleBackColor = true;
            this.czwórka.Click += new System.EventHandler(this.button_Click);
            this.czwórka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dziewiątka
            // 
            this.dziewiątka.Location = new System.Drawing.Point(130, 172);
            this.dziewiątka.Name = "dziewiątka";
            this.dziewiątka.Size = new System.Drawing.Size(40, 40);
            this.dziewiątka.TabIndex = 22;
            this.dziewiątka.Text = "9";
            this.dziewiątka.UseVisualStyleBackColor = true;
            this.dziewiątka.Click += new System.EventHandler(this.button_Click);
            this.dziewiątka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ósemka
            // 
            this.ósemka.Location = new System.Drawing.Point(84, 172);
            this.ósemka.Name = "ósemka";
            this.ósemka.Size = new System.Drawing.Size(40, 40);
            this.ósemka.TabIndex = 23;
            this.ósemka.Text = "8";
            this.ósemka.UseVisualStyleBackColor = true;
            this.ósemka.Click += new System.EventHandler(this.button_Click);
            this.ósemka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // siódemka
            // 
            this.siódemka.Location = new System.Drawing.Point(38, 172);
            this.siódemka.Name = "siódemka";
            this.siódemka.Size = new System.Drawing.Size(40, 40);
            this.siódemka.TabIndex = 24;
            this.siódemka.Text = "7";
            this.siódemka.UseVisualStyleBackColor = true;
            this.siódemka.Click += new System.EventHandler(this.button_Click);
            this.siódemka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // oblicz
            // 
            this.oblicz.Enabled = false;
            this.oblicz.Location = new System.Drawing.Point(38, 137);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(224, 20);
            this.oblicz.TabIndex = 25;
            this.oblicz.Text = "0";
            this.oblicz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oblicz.TextChanged += new System.EventHandler(this.oblicz_TextChanged);
            // 
            // pamiętamy
            // 
            this.pamiętamy.Location = new System.Drawing.Point(38, 137);
            this.pamiętamy.Name = "pamiętamy";
            this.pamiętamy.Size = new System.Drawing.Size(100, 20);
            this.pamiętamy.TabIndex = 26;
            this.pamiętamy.TextChanged += new System.EventHandler(this.pamiętamy_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 250);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.siódemka);
            this.Controls.Add(this.ósemka);
            this.Controls.Add(this.dziewiątka);
            this.Controls.Add(this.czwórka);
            this.Controls.Add(this.piątka);
            this.Controls.Add(this.szóstka);
            this.Controls.Add(this.kasuj_wszystko);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnożenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.kropka);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.równa_się);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.kasuj);
            this.Controls.Add(this.trójka);
            this.Controls.Add(this.dwójka);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.jedynka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pamiętamy);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kalkulator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kalkulator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jedynka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem motywyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem1;
        private System.Windows.Forms.Button dwójka;
        private System.Windows.Forms.Button trójka;
        private System.Windows.Forms.Button kasuj;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button równa_się;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button kropka;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mnożenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Button kasuj_wszystko;
        private System.Windows.Forms.Button szóstka;
        private System.Windows.Forms.Button piątka;
        private System.Windows.Forms.Button czwórka;
        private System.Windows.Forms.Button dziewiątka;
        private System.Windows.Forms.Button ósemka;
        private System.Windows.Forms.Button siódemka;
        private System.Windows.Forms.TextBox oblicz;
        private System.Windows.Forms.TextBox pamiętamy;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

