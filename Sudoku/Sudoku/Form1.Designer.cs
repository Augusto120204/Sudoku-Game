namespace Sudoku
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
            label1 = new Label();
            menu = new GroupBox();
            resolverJuego = new Button();
            ComprobarSolucion = new Button();
            CondicionInicial = new Button();
            generarJuego = new Button();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox52 = new RichTextBox();
            richTextBox45 = new RichTextBox();
            richTextBox36 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            richTextBox12 = new RichTextBox();
            richTextBox11 = new RichTextBox();
            richTextBox10 = new RichTextBox();
            richTextBox18 = new RichTextBox();
            richTextBox14 = new RichTextBox();
            richTextBox16 = new RichTextBox();
            richTextBox15 = new RichTextBox();
            richTextBox17 = new RichTextBox();
            richTextBox13 = new RichTextBox();
            richTextBox75 = new RichTextBox();
            richTextBox74 = new RichTextBox();
            richTextBox76 = new RichTextBox();
            richTextBox77 = new RichTextBox();
            richTextBox73 = new RichTextBox();
            richTextBox78 = new RichTextBox();
            richTextBox81 = new RichTextBox();
            richTextBox80 = new RichTextBox();
            richTextBox79 = new RichTextBox();
            richTextBox65 = new RichTextBox();
            richTextBox66 = new RichTextBox();
            richTextBox67 = new RichTextBox();
            richTextBox68 = new RichTextBox();
            richTextBox64 = new RichTextBox();
            richTextBox69 = new RichTextBox();
            richTextBox72 = new RichTextBox();
            richTextBox71 = new RichTextBox();
            richTextBox70 = new RichTextBox();
            richTextBox60 = new RichTextBox();
            richTextBox57 = new RichTextBox();
            richTextBox58 = new RichTextBox();
            richTextBox61 = new RichTextBox();
            richTextBox59 = new RichTextBox();
            richTextBox55 = new RichTextBox();
            richTextBox63 = new RichTextBox();
            richTextBox62 = new RichTextBox();
            richTextBox56 = new RichTextBox();
            richTextBox47 = new RichTextBox();
            richTextBox48 = new RichTextBox();
            richTextBox49 = new RichTextBox();
            richTextBox50 = new RichTextBox();
            richTextBox46 = new RichTextBox();
            richTextBox51 = new RichTextBox();
            richTextBox54 = new RichTextBox();
            richTextBox53 = new RichTextBox();
            richTextBox40 = new RichTextBox();
            richTextBox39 = new RichTextBox();
            richTextBox41 = new RichTextBox();
            richTextBox42 = new RichTextBox();
            richTextBox44 = new RichTextBox();
            richTextBox43 = new RichTextBox();
            richTextBox37 = new RichTextBox();
            richTextBox38 = new RichTextBox();
            richTextBox35 = new RichTextBox();
            richTextBox33 = new RichTextBox();
            richTextBox32 = new RichTextBox();
            richTextBox28 = new RichTextBox();
            richTextBox29 = new RichTextBox();
            richTextBox34 = new RichTextBox();
            richTextBox30 = new RichTextBox();
            richTextBox31 = new RichTextBox();
            richTextBox23 = new RichTextBox();
            richTextBox24 = new RichTextBox();
            richTextBox22 = new RichTextBox();
            richTextBox21 = new RichTextBox();
            richTextBox27 = new RichTextBox();
            richTextBox26 = new RichTextBox();
            richTextBox25 = new RichTextBox();
            richTextBox19 = new RichTextBox();
            richTextBox20 = new RichTextBox();
            limpiar = new Button();
            cmbDificultad = new ComboBox();
            menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Gill Sans Ultra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(997, 61);
            label1.TabIndex = 0;
            label1.Text = "SUDOKU";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.MenuHighlight;
            menu.Controls.Add(resolverJuego);
            menu.Controls.Add(ComprobarSolucion);
            menu.Controls.Add(CondicionInicial);
            menu.Controls.Add(generarJuego);
            menu.Controls.Add(label2);
            menu.Font = new Font("Gill Sans Ultra Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            menu.ForeColor = SystemColors.ControlDarkDark;
            menu.Location = new Point(0, -23);
            menu.Margin = new Padding(3, 4, 3, 4);
            menu.Name = "menu";
            menu.Padding = new Padding(3, 4, 3, 4);
            menu.Size = new Size(229, 796);
            menu.TabIndex = 1;
            menu.TabStop = false;
            // 
            // resolverJuego
            // 
            resolverJuego.BackColor = Color.PaleTurquoise;
            resolverJuego.Cursor = Cursors.Hand;
            resolverJuego.FlatAppearance.BorderSize = 0;
            resolverJuego.FlatStyle = FlatStyle.Flat;
            resolverJuego.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            resolverJuego.ForeColor = Color.Black;
            resolverJuego.Location = new Point(14, 628);
            resolverJuego.Margin = new Padding(3, 4, 3, 4);
            resolverJuego.Name = "resolverJuego";
            resolverJuego.Size = new Size(195, 85);
            resolverJuego.TabIndex = 4;
            resolverJuego.Text = "Resolver Juego";
            resolverJuego.UseVisualStyleBackColor = false;
            resolverJuego.Click += resolverJuego_Click;
            // 
            // ComprobarSolucion
            // 
            ComprobarSolucion.BackColor = Color.PaleTurquoise;
            ComprobarSolucion.Cursor = Cursors.Hand;
            ComprobarSolucion.FlatAppearance.BorderSize = 0;
            ComprobarSolucion.FlatStyle = FlatStyle.Flat;
            ComprobarSolucion.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ComprobarSolucion.ForeColor = Color.Black;
            ComprobarSolucion.Location = new Point(14, 477);
            ComprobarSolucion.Margin = new Padding(3, 4, 3, 4);
            ComprobarSolucion.Name = "ComprobarSolucion";
            ComprobarSolucion.Size = new Size(195, 85);
            ComprobarSolucion.TabIndex = 3;
            ComprobarSolucion.Text = "Comprobar Solucion";
            ComprobarSolucion.UseVisualStyleBackColor = false;
            ComprobarSolucion.Click += ComprobarSolucion_Click;
            // 
            // CondicionInicial
            // 
            CondicionInicial.BackColor = Color.PaleTurquoise;
            CondicionInicial.Cursor = Cursors.Hand;
            CondicionInicial.FlatAppearance.BorderSize = 0;
            CondicionInicial.FlatStyle = FlatStyle.Flat;
            CondicionInicial.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CondicionInicial.ForeColor = Color.Black;
            CondicionInicial.Location = new Point(14, 332);
            CondicionInicial.Margin = new Padding(3, 4, 3, 4);
            CondicionInicial.Name = "CondicionInicial";
            CondicionInicial.Size = new Size(195, 85);
            CondicionInicial.TabIndex = 2;
            CondicionInicial.Text = "Condicion Inicial";
            CondicionInicial.UseVisualStyleBackColor = false;
            CondicionInicial.Click += CondicionInicial_Click;
            // 
            // generarJuego
            // 
            generarJuego.BackColor = Color.PaleTurquoise;
            generarJuego.Cursor = Cursors.Hand;
            generarJuego.FlatAppearance.BorderSize = 0;
            generarJuego.FlatStyle = FlatStyle.Flat;
            generarJuego.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            generarJuego.ForeColor = Color.Black;
            generarJuego.Location = new Point(14, 184);
            generarJuego.Margin = new Padding(3, 4, 3, 4);
            generarJuego.Name = "generarJuego";
            generarJuego.Size = new Size(195, 85);
            generarJuego.TabIndex = 1;
            generarJuego.Text = "Generar Juego";
            generarJuego.UseVisualStyleBackColor = false;
            generarJuego.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(187, 67);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            label2.Click += label2_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Controls.Add(richTextBox52, 0, 5);
            tableLayoutPanel1.Controls.Add(richTextBox45, 0, 4);
            tableLayoutPanel1.Controls.Add(richTextBox36, 0, 3);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(richTextBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(richTextBox5, 4, 0);
            tableLayoutPanel1.Controls.Add(richTextBox6, 5, 0);
            tableLayoutPanel1.Controls.Add(richTextBox7, 6, 0);
            tableLayoutPanel1.Controls.Add(richTextBox8, 7, 0);
            tableLayoutPanel1.Controls.Add(richTextBox9, 8, 0);
            tableLayoutPanel1.Controls.Add(richTextBox12, 8, 1);
            tableLayoutPanel1.Controls.Add(richTextBox11, 7, 1);
            tableLayoutPanel1.Controls.Add(richTextBox10, 6, 1);
            tableLayoutPanel1.Controls.Add(richTextBox18, 5, 1);
            tableLayoutPanel1.Controls.Add(richTextBox14, 4, 1);
            tableLayoutPanel1.Controls.Add(richTextBox16, 3, 1);
            tableLayoutPanel1.Controls.Add(richTextBox15, 2, 1);
            tableLayoutPanel1.Controls.Add(richTextBox17, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox13, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox75, 8, 8);
            tableLayoutPanel1.Controls.Add(richTextBox74, 7, 8);
            tableLayoutPanel1.Controls.Add(richTextBox76, 6, 8);
            tableLayoutPanel1.Controls.Add(richTextBox77, 5, 8);
            tableLayoutPanel1.Controls.Add(richTextBox73, 4, 8);
            tableLayoutPanel1.Controls.Add(richTextBox78, 3, 8);
            tableLayoutPanel1.Controls.Add(richTextBox81, 2, 8);
            tableLayoutPanel1.Controls.Add(richTextBox80, 1, 8);
            tableLayoutPanel1.Controls.Add(richTextBox79, 0, 8);
            tableLayoutPanel1.Controls.Add(richTextBox65, 8, 7);
            tableLayoutPanel1.Controls.Add(richTextBox66, 7, 7);
            tableLayoutPanel1.Controls.Add(richTextBox67, 6, 7);
            tableLayoutPanel1.Controls.Add(richTextBox68, 5, 7);
            tableLayoutPanel1.Controls.Add(richTextBox64, 4, 7);
            tableLayoutPanel1.Controls.Add(richTextBox69, 3, 7);
            tableLayoutPanel1.Controls.Add(richTextBox72, 2, 7);
            tableLayoutPanel1.Controls.Add(richTextBox71, 1, 7);
            tableLayoutPanel1.Controls.Add(richTextBox70, 0, 7);
            tableLayoutPanel1.Controls.Add(richTextBox60, 0, 6);
            tableLayoutPanel1.Controls.Add(richTextBox57, 8, 6);
            tableLayoutPanel1.Controls.Add(richTextBox58, 7, 6);
            tableLayoutPanel1.Controls.Add(richTextBox61, 6, 6);
            tableLayoutPanel1.Controls.Add(richTextBox59, 5, 6);
            tableLayoutPanel1.Controls.Add(richTextBox55, 4, 6);
            tableLayoutPanel1.Controls.Add(richTextBox63, 3, 6);
            tableLayoutPanel1.Controls.Add(richTextBox62, 2, 6);
            tableLayoutPanel1.Controls.Add(richTextBox56, 1, 6);
            tableLayoutPanel1.Controls.Add(richTextBox47, 8, 5);
            tableLayoutPanel1.Controls.Add(richTextBox48, 7, 5);
            tableLayoutPanel1.Controls.Add(richTextBox49, 6, 5);
            tableLayoutPanel1.Controls.Add(richTextBox50, 5, 5);
            tableLayoutPanel1.Controls.Add(richTextBox46, 4, 5);
            tableLayoutPanel1.Controls.Add(richTextBox51, 3, 5);
            tableLayoutPanel1.Controls.Add(richTextBox54, 2, 5);
            tableLayoutPanel1.Controls.Add(richTextBox53, 1, 5);
            tableLayoutPanel1.Controls.Add(richTextBox40, 8, 4);
            tableLayoutPanel1.Controls.Add(richTextBox39, 7, 4);
            tableLayoutPanel1.Controls.Add(richTextBox41, 6, 4);
            tableLayoutPanel1.Controls.Add(richTextBox42, 5, 4);
            tableLayoutPanel1.Controls.Add(richTextBox44, 4, 4);
            tableLayoutPanel1.Controls.Add(richTextBox43, 3, 4);
            tableLayoutPanel1.Controls.Add(richTextBox37, 2, 4);
            tableLayoutPanel1.Controls.Add(richTextBox38, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox35, 8, 3);
            tableLayoutPanel1.Controls.Add(richTextBox33, 7, 3);
            tableLayoutPanel1.Controls.Add(richTextBox32, 6, 3);
            tableLayoutPanel1.Controls.Add(richTextBox28, 5, 3);
            tableLayoutPanel1.Controls.Add(richTextBox29, 4, 3);
            tableLayoutPanel1.Controls.Add(richTextBox34, 3, 3);
            tableLayoutPanel1.Controls.Add(richTextBox30, 2, 3);
            tableLayoutPanel1.Controls.Add(richTextBox31, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox23, 8, 2);
            tableLayoutPanel1.Controls.Add(richTextBox24, 7, 2);
            tableLayoutPanel1.Controls.Add(richTextBox22, 6, 2);
            tableLayoutPanel1.Controls.Add(richTextBox21, 5, 2);
            tableLayoutPanel1.Controls.Add(richTextBox27, 4, 2);
            tableLayoutPanel1.Controls.Add(richTextBox26, 3, 2);
            tableLayoutPanel1.Controls.Add(richTextBox25, 2, 2);
            tableLayoutPanel1.Controls.Add(richTextBox19, 1, 2);
            tableLayoutPanel1.Controls.Add(richTextBox20, 0, 2);
            tableLayoutPanel1.Location = new Point(295, 161);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(479, 515);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // richTextBox52
            // 
            richTextBox52.BackColor = Color.DeepSkyBlue;
            richTextBox52.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox52.Location = new Point(3, 289);
            richTextBox52.Margin = new Padding(3, 4, 3, 4);
            richTextBox52.Name = "richTextBox52";
            richTextBox52.Size = new Size(44, 47);
            richTextBox52.TabIndex = 51;
            richTextBox52.Text = "";
            // 
            // richTextBox45
            // 
            richTextBox45.BackColor = Color.DeepSkyBlue;
            richTextBox45.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox45.Location = new Point(3, 232);
            richTextBox45.Margin = new Padding(3, 4, 3, 4);
            richTextBox45.Name = "richTextBox45";
            richTextBox45.Size = new Size(44, 47);
            richTextBox45.TabIndex = 44;
            richTextBox45.Text = "";
            // 
            // richTextBox36
            // 
            richTextBox36.BackColor = Color.DeepSkyBlue;
            richTextBox36.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox36.Location = new Point(3, 175);
            richTextBox36.Margin = new Padding(3, 4, 3, 4);
            richTextBox36.Name = "richTextBox36";
            richTextBox36.Size = new Size(44, 47);
            richTextBox36.TabIndex = 35;
            richTextBox36.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SkyBlue;
            richTextBox1.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(3, 4);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(44, 47);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.SkyBlue;
            richTextBox2.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(56, 4);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(44, 47);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.SkyBlue;
            richTextBox3.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(109, 4);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(44, 47);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.DeepSkyBlue;
            richTextBox4.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(162, 4);
            richTextBox4.Margin = new Padding(3, 4, 3, 4);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(44, 47);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.DeepSkyBlue;
            richTextBox5.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(215, 4);
            richTextBox5.Margin = new Padding(3, 4, 3, 4);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(44, 47);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = Color.DeepSkyBlue;
            richTextBox6.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox6.Location = new Point(268, 4);
            richTextBox6.Margin = new Padding(3, 4, 3, 4);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(44, 47);
            richTextBox6.TabIndex = 5;
            richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.BackColor = Color.SkyBlue;
            richTextBox7.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox7.Location = new Point(321, 4);
            richTextBox7.Margin = new Padding(3, 4, 3, 4);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(44, 47);
            richTextBox7.TabIndex = 6;
            richTextBox7.Text = "";
            // 
            // richTextBox8
            // 
            richTextBox8.BackColor = Color.SkyBlue;
            richTextBox8.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox8.Location = new Point(374, 4);
            richTextBox8.Margin = new Padding(3, 4, 3, 4);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(44, 47);
            richTextBox8.TabIndex = 7;
            richTextBox8.Text = "";
            // 
            // richTextBox9
            // 
            richTextBox9.BackColor = Color.SkyBlue;
            richTextBox9.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox9.Location = new Point(427, 4);
            richTextBox9.Margin = new Padding(3, 4, 3, 4);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(44, 47);
            richTextBox9.TabIndex = 8;
            richTextBox9.Text = "";
            // 
            // richTextBox12
            // 
            richTextBox12.BackColor = Color.SkyBlue;
            richTextBox12.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox12.Location = new Point(427, 61);
            richTextBox12.Margin = new Padding(3, 4, 3, 4);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.Size = new Size(44, 47);
            richTextBox12.TabIndex = 11;
            richTextBox12.Text = "";
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = Color.SkyBlue;
            richTextBox11.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox11.Location = new Point(374, 61);
            richTextBox11.Margin = new Padding(3, 4, 3, 4);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.Size = new Size(44, 47);
            richTextBox11.TabIndex = 10;
            richTextBox11.Text = "";
            // 
            // richTextBox10
            // 
            richTextBox10.BackColor = Color.SkyBlue;
            richTextBox10.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox10.Location = new Point(321, 61);
            richTextBox10.Margin = new Padding(3, 4, 3, 4);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.Size = new Size(44, 47);
            richTextBox10.TabIndex = 9;
            richTextBox10.Text = "";
            // 
            // richTextBox18
            // 
            richTextBox18.BackColor = Color.DeepSkyBlue;
            richTextBox18.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox18.Location = new Point(268, 61);
            richTextBox18.Margin = new Padding(3, 4, 3, 4);
            richTextBox18.Name = "richTextBox18";
            richTextBox18.Size = new Size(44, 47);
            richTextBox18.TabIndex = 17;
            richTextBox18.Text = "";
            // 
            // richTextBox14
            // 
            richTextBox14.BackColor = Color.DeepSkyBlue;
            richTextBox14.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox14.Location = new Point(215, 61);
            richTextBox14.Margin = new Padding(3, 4, 3, 4);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.Size = new Size(44, 47);
            richTextBox14.TabIndex = 13;
            richTextBox14.Text = "";
            // 
            // richTextBox16
            // 
            richTextBox16.BackColor = Color.DeepSkyBlue;
            richTextBox16.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox16.Location = new Point(162, 61);
            richTextBox16.Margin = new Padding(3, 4, 3, 4);
            richTextBox16.Name = "richTextBox16";
            richTextBox16.Size = new Size(44, 47);
            richTextBox16.TabIndex = 15;
            richTextBox16.Text = "";
            // 
            // richTextBox15
            // 
            richTextBox15.BackColor = Color.SkyBlue;
            richTextBox15.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox15.Location = new Point(109, 61);
            richTextBox15.Margin = new Padding(3, 4, 3, 4);
            richTextBox15.Name = "richTextBox15";
            richTextBox15.Size = new Size(44, 47);
            richTextBox15.TabIndex = 14;
            richTextBox15.Text = "";
            // 
            // richTextBox17
            // 
            richTextBox17.BackColor = Color.SkyBlue;
            richTextBox17.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox17.Location = new Point(56, 61);
            richTextBox17.Margin = new Padding(3, 4, 3, 4);
            richTextBox17.Name = "richTextBox17";
            richTextBox17.Size = new Size(44, 47);
            richTextBox17.TabIndex = 16;
            richTextBox17.Text = "";
            // 
            // richTextBox13
            // 
            richTextBox13.BackColor = Color.SkyBlue;
            richTextBox13.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox13.Location = new Point(3, 61);
            richTextBox13.Margin = new Padding(3, 4, 3, 4);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.Size = new Size(44, 47);
            richTextBox13.TabIndex = 12;
            richTextBox13.Text = "";
            // 
            // richTextBox75
            // 
            richTextBox75.BackColor = Color.SkyBlue;
            richTextBox75.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox75.Location = new Point(427, 460);
            richTextBox75.Margin = new Padding(3, 4, 3, 4);
            richTextBox75.Name = "richTextBox75";
            richTextBox75.Size = new Size(44, 51);
            richTextBox75.TabIndex = 74;
            richTextBox75.Text = "";
            // 
            // richTextBox74
            // 
            richTextBox74.BackColor = Color.SkyBlue;
            richTextBox74.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox74.Location = new Point(374, 460);
            richTextBox74.Margin = new Padding(3, 4, 3, 4);
            richTextBox74.Name = "richTextBox74";
            richTextBox74.Size = new Size(44, 51);
            richTextBox74.TabIndex = 73;
            richTextBox74.Text = "";
            // 
            // richTextBox76
            // 
            richTextBox76.BackColor = Color.SkyBlue;
            richTextBox76.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox76.Location = new Point(321, 460);
            richTextBox76.Margin = new Padding(3, 4, 3, 4);
            richTextBox76.Name = "richTextBox76";
            richTextBox76.Size = new Size(44, 51);
            richTextBox76.TabIndex = 75;
            richTextBox76.Text = "";
            // 
            // richTextBox77
            // 
            richTextBox77.BackColor = Color.DeepSkyBlue;
            richTextBox77.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox77.Location = new Point(268, 460);
            richTextBox77.Margin = new Padding(3, 4, 3, 4);
            richTextBox77.Name = "richTextBox77";
            richTextBox77.Size = new Size(44, 51);
            richTextBox77.TabIndex = 76;
            richTextBox77.Text = "";
            // 
            // richTextBox73
            // 
            richTextBox73.BackColor = Color.DeepSkyBlue;
            richTextBox73.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox73.Location = new Point(215, 460);
            richTextBox73.Margin = new Padding(3, 4, 3, 4);
            richTextBox73.Name = "richTextBox73";
            richTextBox73.Size = new Size(44, 51);
            richTextBox73.TabIndex = 72;
            richTextBox73.Text = "";
            // 
            // richTextBox78
            // 
            richTextBox78.BackColor = Color.DeepSkyBlue;
            richTextBox78.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox78.Location = new Point(162, 460);
            richTextBox78.Margin = new Padding(3, 4, 3, 4);
            richTextBox78.Name = "richTextBox78";
            richTextBox78.Size = new Size(44, 51);
            richTextBox78.TabIndex = 77;
            richTextBox78.Text = "";
            // 
            // richTextBox81
            // 
            richTextBox81.BackColor = Color.SkyBlue;
            richTextBox81.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox81.Location = new Point(109, 460);
            richTextBox81.Margin = new Padding(3, 4, 3, 4);
            richTextBox81.Name = "richTextBox81";
            richTextBox81.Size = new Size(44, 51);
            richTextBox81.TabIndex = 80;
            richTextBox81.Text = "";
            // 
            // richTextBox80
            // 
            richTextBox80.BackColor = Color.SkyBlue;
            richTextBox80.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox80.Location = new Point(56, 460);
            richTextBox80.Margin = new Padding(3, 4, 3, 4);
            richTextBox80.Name = "richTextBox80";
            richTextBox80.Size = new Size(44, 51);
            richTextBox80.TabIndex = 79;
            richTextBox80.Text = "";
            richTextBox80.TextChanged += richTextBox80_TextChanged;
            // 
            // richTextBox79
            // 
            richTextBox79.BackColor = Color.SkyBlue;
            richTextBox79.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox79.Location = new Point(3, 460);
            richTextBox79.Margin = new Padding(3, 4, 3, 4);
            richTextBox79.Name = "richTextBox79";
            richTextBox79.Size = new Size(44, 51);
            richTextBox79.TabIndex = 78;
            richTextBox79.Text = "";
            // 
            // richTextBox65
            // 
            richTextBox65.BackColor = Color.SkyBlue;
            richTextBox65.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox65.Location = new Point(427, 403);
            richTextBox65.Margin = new Padding(3, 4, 3, 4);
            richTextBox65.Name = "richTextBox65";
            richTextBox65.Size = new Size(44, 47);
            richTextBox65.TabIndex = 64;
            richTextBox65.Text = "";
            // 
            // richTextBox66
            // 
            richTextBox66.BackColor = Color.SkyBlue;
            richTextBox66.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox66.Location = new Point(374, 403);
            richTextBox66.Margin = new Padding(3, 4, 3, 4);
            richTextBox66.Name = "richTextBox66";
            richTextBox66.Size = new Size(44, 47);
            richTextBox66.TabIndex = 65;
            richTextBox66.Text = "";
            // 
            // richTextBox67
            // 
            richTextBox67.BackColor = Color.SkyBlue;
            richTextBox67.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox67.Location = new Point(321, 403);
            richTextBox67.Margin = new Padding(3, 4, 3, 4);
            richTextBox67.Name = "richTextBox67";
            richTextBox67.Size = new Size(44, 47);
            richTextBox67.TabIndex = 66;
            richTextBox67.Text = "";
            // 
            // richTextBox68
            // 
            richTextBox68.BackColor = Color.DeepSkyBlue;
            richTextBox68.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox68.Location = new Point(268, 403);
            richTextBox68.Margin = new Padding(3, 4, 3, 4);
            richTextBox68.Name = "richTextBox68";
            richTextBox68.Size = new Size(44, 47);
            richTextBox68.TabIndex = 67;
            richTextBox68.Text = "";
            // 
            // richTextBox64
            // 
            richTextBox64.BackColor = Color.DeepSkyBlue;
            richTextBox64.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox64.Location = new Point(215, 403);
            richTextBox64.Margin = new Padding(3, 4, 3, 4);
            richTextBox64.Name = "richTextBox64";
            richTextBox64.Size = new Size(44, 47);
            richTextBox64.TabIndex = 63;
            richTextBox64.Text = "";
            // 
            // richTextBox69
            // 
            richTextBox69.BackColor = Color.DeepSkyBlue;
            richTextBox69.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox69.Location = new Point(162, 403);
            richTextBox69.Margin = new Padding(3, 4, 3, 4);
            richTextBox69.Name = "richTextBox69";
            richTextBox69.Size = new Size(44, 47);
            richTextBox69.TabIndex = 68;
            richTextBox69.Text = "";
            // 
            // richTextBox72
            // 
            richTextBox72.BackColor = Color.SkyBlue;
            richTextBox72.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox72.Location = new Point(109, 403);
            richTextBox72.Margin = new Padding(3, 4, 3, 4);
            richTextBox72.Name = "richTextBox72";
            richTextBox72.Size = new Size(44, 47);
            richTextBox72.TabIndex = 71;
            richTextBox72.Text = "";
            // 
            // richTextBox71
            // 
            richTextBox71.BackColor = Color.SkyBlue;
            richTextBox71.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox71.Location = new Point(56, 403);
            richTextBox71.Margin = new Padding(3, 4, 3, 4);
            richTextBox71.Name = "richTextBox71";
            richTextBox71.Size = new Size(44, 47);
            richTextBox71.TabIndex = 70;
            richTextBox71.Text = "";
            // 
            // richTextBox70
            // 
            richTextBox70.BackColor = Color.SkyBlue;
            richTextBox70.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox70.Location = new Point(3, 403);
            richTextBox70.Margin = new Padding(3, 4, 3, 4);
            richTextBox70.Name = "richTextBox70";
            richTextBox70.Size = new Size(44, 47);
            richTextBox70.TabIndex = 69;
            richTextBox70.Text = "";
            // 
            // richTextBox60
            // 
            richTextBox60.BackColor = Color.SkyBlue;
            richTextBox60.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox60.Location = new Point(3, 346);
            richTextBox60.Margin = new Padding(3, 4, 3, 4);
            richTextBox60.Name = "richTextBox60";
            richTextBox60.Size = new Size(44, 47);
            richTextBox60.TabIndex = 59;
            richTextBox60.Text = "";
            // 
            // richTextBox57
            // 
            richTextBox57.BackColor = Color.SkyBlue;
            richTextBox57.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox57.Location = new Point(427, 346);
            richTextBox57.Margin = new Padding(3, 4, 3, 4);
            richTextBox57.Name = "richTextBox57";
            richTextBox57.Size = new Size(44, 47);
            richTextBox57.TabIndex = 56;
            richTextBox57.Text = "";
            // 
            // richTextBox58
            // 
            richTextBox58.BackColor = Color.SkyBlue;
            richTextBox58.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox58.Location = new Point(374, 346);
            richTextBox58.Margin = new Padding(3, 4, 3, 4);
            richTextBox58.Name = "richTextBox58";
            richTextBox58.Size = new Size(44, 47);
            richTextBox58.TabIndex = 57;
            richTextBox58.Text = "";
            // 
            // richTextBox61
            // 
            richTextBox61.BackColor = Color.SkyBlue;
            richTextBox61.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox61.Location = new Point(321, 346);
            richTextBox61.Margin = new Padding(3, 4, 3, 4);
            richTextBox61.Name = "richTextBox61";
            richTextBox61.Size = new Size(44, 47);
            richTextBox61.TabIndex = 60;
            richTextBox61.Text = "";
            // 
            // richTextBox59
            // 
            richTextBox59.BackColor = Color.DeepSkyBlue;
            richTextBox59.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox59.Location = new Point(268, 346);
            richTextBox59.Margin = new Padding(3, 4, 3, 4);
            richTextBox59.Name = "richTextBox59";
            richTextBox59.Size = new Size(44, 47);
            richTextBox59.TabIndex = 58;
            richTextBox59.Text = "";
            // 
            // richTextBox55
            // 
            richTextBox55.BackColor = Color.DeepSkyBlue;
            richTextBox55.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox55.Location = new Point(215, 346);
            richTextBox55.Margin = new Padding(3, 4, 3, 4);
            richTextBox55.Name = "richTextBox55";
            richTextBox55.Size = new Size(44, 47);
            richTextBox55.TabIndex = 54;
            richTextBox55.Text = "";
            // 
            // richTextBox63
            // 
            richTextBox63.BackColor = Color.DeepSkyBlue;
            richTextBox63.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox63.Location = new Point(162, 346);
            richTextBox63.Margin = new Padding(3, 4, 3, 4);
            richTextBox63.Name = "richTextBox63";
            richTextBox63.Size = new Size(44, 47);
            richTextBox63.TabIndex = 62;
            richTextBox63.Text = "";
            // 
            // richTextBox62
            // 
            richTextBox62.BackColor = Color.SkyBlue;
            richTextBox62.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox62.Location = new Point(109, 346);
            richTextBox62.Margin = new Padding(3, 4, 3, 4);
            richTextBox62.Name = "richTextBox62";
            richTextBox62.Size = new Size(44, 47);
            richTextBox62.TabIndex = 61;
            richTextBox62.Text = "";
            // 
            // richTextBox56
            // 
            richTextBox56.BackColor = Color.SkyBlue;
            richTextBox56.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox56.Location = new Point(56, 346);
            richTextBox56.Margin = new Padding(3, 4, 3, 4);
            richTextBox56.Name = "richTextBox56";
            richTextBox56.Size = new Size(44, 47);
            richTextBox56.TabIndex = 55;
            richTextBox56.Text = "";
            richTextBox56.TextChanged += richTextBox56_TextChanged;
            // 
            // richTextBox47
            // 
            richTextBox47.BackColor = Color.DeepSkyBlue;
            richTextBox47.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox47.Location = new Point(427, 289);
            richTextBox47.Margin = new Padding(3, 4, 3, 4);
            richTextBox47.Name = "richTextBox47";
            richTextBox47.Size = new Size(44, 47);
            richTextBox47.TabIndex = 46;
            richTextBox47.Text = "";
            // 
            // richTextBox48
            // 
            richTextBox48.BackColor = Color.DeepSkyBlue;
            richTextBox48.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox48.Location = new Point(374, 289);
            richTextBox48.Margin = new Padding(3, 4, 3, 4);
            richTextBox48.Name = "richTextBox48";
            richTextBox48.Size = new Size(44, 47);
            richTextBox48.TabIndex = 47;
            richTextBox48.Text = "";
            // 
            // richTextBox49
            // 
            richTextBox49.BackColor = Color.DeepSkyBlue;
            richTextBox49.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox49.Location = new Point(321, 289);
            richTextBox49.Margin = new Padding(3, 4, 3, 4);
            richTextBox49.Name = "richTextBox49";
            richTextBox49.Size = new Size(44, 47);
            richTextBox49.TabIndex = 48;
            richTextBox49.Text = "";
            // 
            // richTextBox50
            // 
            richTextBox50.BackColor = Color.SkyBlue;
            richTextBox50.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox50.Location = new Point(268, 289);
            richTextBox50.Margin = new Padding(3, 4, 3, 4);
            richTextBox50.Name = "richTextBox50";
            richTextBox50.Size = new Size(44, 47);
            richTextBox50.TabIndex = 49;
            richTextBox50.Text = "";
            // 
            // richTextBox46
            // 
            richTextBox46.BackColor = Color.SkyBlue;
            richTextBox46.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox46.Location = new Point(215, 289);
            richTextBox46.Margin = new Padding(3, 4, 3, 4);
            richTextBox46.Name = "richTextBox46";
            richTextBox46.Size = new Size(44, 47);
            richTextBox46.TabIndex = 45;
            richTextBox46.Text = "";
            // 
            // richTextBox51
            // 
            richTextBox51.BackColor = Color.SkyBlue;
            richTextBox51.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox51.Location = new Point(162, 289);
            richTextBox51.Margin = new Padding(3, 4, 3, 4);
            richTextBox51.Name = "richTextBox51";
            richTextBox51.Size = new Size(44, 47);
            richTextBox51.TabIndex = 50;
            richTextBox51.Text = "";
            // 
            // richTextBox54
            // 
            richTextBox54.BackColor = Color.DeepSkyBlue;
            richTextBox54.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox54.Location = new Point(109, 289);
            richTextBox54.Margin = new Padding(3, 4, 3, 4);
            richTextBox54.Name = "richTextBox54";
            richTextBox54.Size = new Size(44, 47);
            richTextBox54.TabIndex = 53;
            richTextBox54.Text = "";
            // 
            // richTextBox53
            // 
            richTextBox53.BackColor = Color.DeepSkyBlue;
            richTextBox53.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox53.Location = new Point(56, 289);
            richTextBox53.Margin = new Padding(3, 4, 3, 4);
            richTextBox53.Name = "richTextBox53";
            richTextBox53.Size = new Size(44, 47);
            richTextBox53.TabIndex = 52;
            richTextBox53.Text = "";
            // 
            // richTextBox40
            // 
            richTextBox40.BackColor = Color.DeepSkyBlue;
            richTextBox40.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox40.Location = new Point(427, 232);
            richTextBox40.Margin = new Padding(3, 4, 3, 4);
            richTextBox40.Name = "richTextBox40";
            richTextBox40.Size = new Size(44, 47);
            richTextBox40.TabIndex = 39;
            richTextBox40.Text = "";
            // 
            // richTextBox39
            // 
            richTextBox39.BackColor = Color.DeepSkyBlue;
            richTextBox39.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox39.Location = new Point(374, 232);
            richTextBox39.Margin = new Padding(3, 4, 3, 4);
            richTextBox39.Name = "richTextBox39";
            richTextBox39.Size = new Size(44, 47);
            richTextBox39.TabIndex = 38;
            richTextBox39.Text = "";
            // 
            // richTextBox41
            // 
            richTextBox41.BackColor = Color.DeepSkyBlue;
            richTextBox41.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox41.Location = new Point(321, 232);
            richTextBox41.Margin = new Padding(3, 4, 3, 4);
            richTextBox41.Name = "richTextBox41";
            richTextBox41.Size = new Size(44, 47);
            richTextBox41.TabIndex = 40;
            richTextBox41.Text = "";
            // 
            // richTextBox42
            // 
            richTextBox42.BackColor = Color.SkyBlue;
            richTextBox42.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox42.Location = new Point(268, 232);
            richTextBox42.Margin = new Padding(3, 4, 3, 4);
            richTextBox42.Name = "richTextBox42";
            richTextBox42.Size = new Size(44, 47);
            richTextBox42.TabIndex = 41;
            richTextBox42.Text = "";
            // 
            // richTextBox44
            // 
            richTextBox44.BackColor = Color.SkyBlue;
            richTextBox44.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox44.Location = new Point(215, 232);
            richTextBox44.Margin = new Padding(3, 4, 3, 4);
            richTextBox44.Name = "richTextBox44";
            richTextBox44.Size = new Size(44, 47);
            richTextBox44.TabIndex = 43;
            richTextBox44.Text = "";
            // 
            // richTextBox43
            // 
            richTextBox43.BackColor = Color.SkyBlue;
            richTextBox43.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox43.Location = new Point(162, 232);
            richTextBox43.Margin = new Padding(3, 4, 3, 4);
            richTextBox43.Name = "richTextBox43";
            richTextBox43.Size = new Size(44, 47);
            richTextBox43.TabIndex = 42;
            richTextBox43.Text = "";
            // 
            // richTextBox37
            // 
            richTextBox37.BackColor = Color.DeepSkyBlue;
            richTextBox37.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox37.Location = new Point(109, 232);
            richTextBox37.Margin = new Padding(3, 4, 3, 4);
            richTextBox37.Name = "richTextBox37";
            richTextBox37.Size = new Size(44, 47);
            richTextBox37.TabIndex = 36;
            richTextBox37.Text = "";
            // 
            // richTextBox38
            // 
            richTextBox38.BackColor = Color.DeepSkyBlue;
            richTextBox38.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox38.Location = new Point(56, 232);
            richTextBox38.Margin = new Padding(3, 4, 3, 4);
            richTextBox38.Name = "richTextBox38";
            richTextBox38.Size = new Size(44, 47);
            richTextBox38.TabIndex = 37;
            richTextBox38.Text = "";
            // 
            // richTextBox35
            // 
            richTextBox35.BackColor = Color.DeepSkyBlue;
            richTextBox35.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox35.Location = new Point(427, 175);
            richTextBox35.Margin = new Padding(3, 4, 3, 4);
            richTextBox35.Name = "richTextBox35";
            richTextBox35.Size = new Size(44, 47);
            richTextBox35.TabIndex = 34;
            richTextBox35.Text = "";
            // 
            // richTextBox33
            // 
            richTextBox33.BackColor = Color.DeepSkyBlue;
            richTextBox33.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox33.Location = new Point(374, 175);
            richTextBox33.Margin = new Padding(3, 4, 3, 4);
            richTextBox33.Name = "richTextBox33";
            richTextBox33.Size = new Size(44, 47);
            richTextBox33.TabIndex = 32;
            richTextBox33.Text = "";
            // 
            // richTextBox32
            // 
            richTextBox32.BackColor = Color.DeepSkyBlue;
            richTextBox32.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox32.Location = new Point(321, 175);
            richTextBox32.Margin = new Padding(3, 4, 3, 4);
            richTextBox32.Name = "richTextBox32";
            richTextBox32.Size = new Size(44, 47);
            richTextBox32.TabIndex = 31;
            richTextBox32.Text = "";
            // 
            // richTextBox28
            // 
            richTextBox28.BackColor = Color.SkyBlue;
            richTextBox28.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox28.Location = new Point(268, 175);
            richTextBox28.Margin = new Padding(3, 4, 3, 4);
            richTextBox28.Name = "richTextBox28";
            richTextBox28.Size = new Size(44, 47);
            richTextBox28.TabIndex = 27;
            richTextBox28.Text = "";
            // 
            // richTextBox29
            // 
            richTextBox29.BackColor = Color.SkyBlue;
            richTextBox29.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox29.Location = new Point(215, 175);
            richTextBox29.Margin = new Padding(3, 4, 3, 4);
            richTextBox29.Name = "richTextBox29";
            richTextBox29.Size = new Size(44, 47);
            richTextBox29.TabIndex = 28;
            richTextBox29.Text = "";
            // 
            // richTextBox34
            // 
            richTextBox34.BackColor = Color.SkyBlue;
            richTextBox34.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox34.Location = new Point(162, 175);
            richTextBox34.Margin = new Padding(3, 4, 3, 4);
            richTextBox34.Name = "richTextBox34";
            richTextBox34.Size = new Size(44, 47);
            richTextBox34.TabIndex = 33;
            richTextBox34.Text = "";
            // 
            // richTextBox30
            // 
            richTextBox30.BackColor = Color.DeepSkyBlue;
            richTextBox30.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox30.Location = new Point(109, 175);
            richTextBox30.Margin = new Padding(3, 4, 3, 4);
            richTextBox30.Name = "richTextBox30";
            richTextBox30.Size = new Size(44, 47);
            richTextBox30.TabIndex = 29;
            richTextBox30.Text = "";
            // 
            // richTextBox31
            // 
            richTextBox31.BackColor = Color.DeepSkyBlue;
            richTextBox31.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox31.Location = new Point(56, 175);
            richTextBox31.Margin = new Padding(3, 4, 3, 4);
            richTextBox31.Name = "richTextBox31";
            richTextBox31.Size = new Size(44, 47);
            richTextBox31.TabIndex = 30;
            richTextBox31.Text = "";
            // 
            // richTextBox23
            // 
            richTextBox23.BackColor = Color.SkyBlue;
            richTextBox23.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox23.Location = new Point(427, 118);
            richTextBox23.Margin = new Padding(3, 4, 3, 4);
            richTextBox23.Name = "richTextBox23";
            richTextBox23.Size = new Size(44, 47);
            richTextBox23.TabIndex = 22;
            richTextBox23.Text = "";
            // 
            // richTextBox24
            // 
            richTextBox24.BackColor = Color.SkyBlue;
            richTextBox24.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox24.Location = new Point(374, 118);
            richTextBox24.Margin = new Padding(3, 4, 3, 4);
            richTextBox24.Name = "richTextBox24";
            richTextBox24.Size = new Size(44, 47);
            richTextBox24.TabIndex = 23;
            richTextBox24.Text = "";
            // 
            // richTextBox22
            // 
            richTextBox22.BackColor = Color.SkyBlue;
            richTextBox22.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox22.Location = new Point(321, 118);
            richTextBox22.Margin = new Padding(3, 4, 3, 4);
            richTextBox22.Name = "richTextBox22";
            richTextBox22.Size = new Size(44, 47);
            richTextBox22.TabIndex = 21;
            richTextBox22.Text = "";
            // 
            // richTextBox21
            // 
            richTextBox21.BackColor = Color.DeepSkyBlue;
            richTextBox21.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox21.Location = new Point(268, 118);
            richTextBox21.Margin = new Padding(3, 4, 3, 4);
            richTextBox21.Name = "richTextBox21";
            richTextBox21.Size = new Size(44, 47);
            richTextBox21.TabIndex = 20;
            richTextBox21.Text = "";
            // 
            // richTextBox27
            // 
            richTextBox27.BackColor = Color.DeepSkyBlue;
            richTextBox27.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox27.Location = new Point(215, 118);
            richTextBox27.Margin = new Padding(3, 4, 3, 4);
            richTextBox27.Name = "richTextBox27";
            richTextBox27.Size = new Size(44, 47);
            richTextBox27.TabIndex = 26;
            richTextBox27.Text = "";
            // 
            // richTextBox26
            // 
            richTextBox26.BackColor = Color.DeepSkyBlue;
            richTextBox26.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox26.Location = new Point(162, 118);
            richTextBox26.Margin = new Padding(3, 4, 3, 4);
            richTextBox26.Name = "richTextBox26";
            richTextBox26.Size = new Size(44, 47);
            richTextBox26.TabIndex = 25;
            richTextBox26.Text = "";
            // 
            // richTextBox25
            // 
            richTextBox25.BackColor = Color.SkyBlue;
            richTextBox25.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox25.Location = new Point(109, 118);
            richTextBox25.Margin = new Padding(3, 4, 3, 4);
            richTextBox25.Name = "richTextBox25";
            richTextBox25.Size = new Size(44, 47);
            richTextBox25.TabIndex = 24;
            richTextBox25.Text = "";
            // 
            // richTextBox19
            // 
            richTextBox19.BackColor = Color.SkyBlue;
            richTextBox19.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox19.Location = new Point(56, 118);
            richTextBox19.Margin = new Padding(3, 4, 3, 4);
            richTextBox19.Name = "richTextBox19";
            richTextBox19.Size = new Size(44, 47);
            richTextBox19.TabIndex = 18;
            richTextBox19.Text = "";
            // 
            // richTextBox20
            // 
            richTextBox20.BackColor = Color.SkyBlue;
            richTextBox20.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox20.Location = new Point(3, 118);
            richTextBox20.Margin = new Padding(3, 4, 3, 4);
            richTextBox20.Name = "richTextBox20";
            richTextBox20.Size = new Size(44, 47);
            richTextBox20.TabIndex = 19;
            richTextBox20.Text = "";
            // 
            // limpiar
            // 
            limpiar.BackColor = Color.PaleTurquoise;
            limpiar.Cursor = Cursors.Hand;
            limpiar.FlatAppearance.BorderSize = 0;
            limpiar.FlatStyle = FlatStyle.Flat;
            limpiar.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            limpiar.ForeColor = Color.Black;
            limpiar.Location = new Point(831, 609);
            limpiar.Margin = new Padding(3, 4, 3, 4);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(141, 67);
            limpiar.TabIndex = 5;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // cmbDificultad
            // 
            cmbDificultad.BackColor = Color.PaleTurquoise;
            cmbDificultad.FlatStyle = FlatStyle.Popup;
            cmbDificultad.Font = new Font("Gill Sans Ultra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Items.AddRange(new object[] { "Facil", "Medio", "Dificil" });
            cmbDificultad.Location = new Point(831, 190);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(151, 34);
            cmbDificultad.TabIndex = 6;
            cmbDificultad.Text = "Facil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(997, 763);
            Controls.Add(cmbDificultad);
            Controls.Add(limpiar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Sudoku";
            TransparencyKey = Color.Transparent;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox menu;
        private Label label2;
        private Button generarJuego;
        private Button resolverJuego;
        private Button ComprobarSolucion;
        private Button CondicionInicial;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox81;
        private RichTextBox richTextBox80;
        private RichTextBox richTextBox79;
        private RichTextBox richTextBox78;
        private RichTextBox richTextBox77;
        private RichTextBox richTextBox76;
        private RichTextBox richTextBox75;
        private RichTextBox richTextBox74;
        private RichTextBox richTextBox73;
        private RichTextBox richTextBox72;
        private RichTextBox richTextBox71;
        private RichTextBox richTextBox70;
        private RichTextBox richTextBox69;
        private RichTextBox richTextBox68;
        private RichTextBox richTextBox67;
        private RichTextBox richTextBox66;
        private RichTextBox richTextBox65;
        private RichTextBox richTextBox64;
        private RichTextBox richTextBox63;
        private RichTextBox richTextBox62;
        private RichTextBox richTextBox61;
        private RichTextBox richTextBox60;
        private RichTextBox richTextBox59;
        private RichTextBox richTextBox58;
        private RichTextBox richTextBox57;
        private RichTextBox richTextBox56;
        private RichTextBox richTextBox55;
        private RichTextBox richTextBox54;
        private RichTextBox richTextBox53;
        private RichTextBox richTextBox52;
        private RichTextBox richTextBox51;
        private RichTextBox richTextBox50;
        private RichTextBox richTextBox49;
        private RichTextBox richTextBox48;
        private RichTextBox richTextBox47;
        private RichTextBox richTextBox46;
        private RichTextBox richTextBox45;
        private RichTextBox richTextBox44;
        private RichTextBox richTextBox43;
        private RichTextBox richTextBox42;
        private RichTextBox richTextBox41;
        private RichTextBox richTextBox40;
        private RichTextBox richTextBox39;
        private RichTextBox richTextBox38;
        private RichTextBox richTextBox37;
        private RichTextBox richTextBox36;
        private RichTextBox richTextBox35;
        private RichTextBox richTextBox34;
        private RichTextBox richTextBox33;
        private RichTextBox richTextBox32;
        private RichTextBox richTextBox31;
        private RichTextBox richTextBox30;
        private RichTextBox richTextBox29;
        private RichTextBox richTextBox28;
        private RichTextBox richTextBox27;
        private RichTextBox richTextBox26;
        private RichTextBox richTextBox25;
        private RichTextBox richTextBox24;
        private RichTextBox richTextBox23;
        private RichTextBox richTextBox22;
        private RichTextBox richTextBox21;
        private RichTextBox richTextBox20;
        private RichTextBox richTextBox19;
        private RichTextBox richTextBox18;
        private RichTextBox richTextBox17;
        private RichTextBox richTextBox16;
        private RichTextBox richTextBox15;
        private RichTextBox richTextBox14;
        private RichTextBox richTextBox13;
        private RichTextBox richTextBox12;
        private RichTextBox richTextBox11;
        private RichTextBox richTextBox10;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox9;
        private Button limpiar;
        private ComboBox cmbDificultad;
    }
}