namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            mapaPanel = new Panel();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnDetenerSimulacion = new Button();
            txtResumenMovimientos = new TextBox();
            lstMovimientos = new ListBox();
            txtAgregarVehiculos = new TextBox();
            btnAgregarVehiculos = new Button();
            txtSemaforo = new TextBox();
            txtVehiculos = new TextBox();
            btnSimular = new Button();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panelVerde7 = new Panel();
            panelRojo6 = new Panel();
            panelAmarillo7 = new Panel();
            panelRojo7 = new Panel();
            panelVerde5 = new Panel();
            panelAmarillo6 = new Panel();
            panelVerde6 = new Panel();
            label8 = new Label();
            panelAmarillo5 = new Panel();
            panelRojo5 = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelVerde4 = new Panel();
            panelAmarillo4 = new Panel();
            panelRojo3 = new Panel();
            panelRojo4 = new Panel();
            panelAmarillo3 = new Panel();
            panelVerde3 = new Panel();
            panelVerde2 = new Panel();
            btnIniciar = new Button();
            panelAmarillo2 = new Panel();
            lblTemporizador = new Label();
            panelRojo2 = new Panel();
            panelVerde = new Panel();
            panelAmarillo = new Panel();
            panelRojo = new Panel();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            btnGenerarReportes = new Button();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtResumenFlujo = new TextBox();
            LstReporteFlujo = new ListBox();
            tabPage4 = new TabPage();
            label10 = new Label();
            lstCongestiones = new ListBox();
            lstFlujoVehiculos = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            mapaPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // mapaPanel
            // 
            mapaPanel.BackColor = Color.FromArgb(255, 255, 192);
            mapaPanel.Controls.Add(label9);
            mapaPanel.Controls.Add(label5);
            mapaPanel.Controls.Add(label4);
            mapaPanel.Controls.Add(label3);
            mapaPanel.Controls.Add(btnDetenerSimulacion);
            mapaPanel.Controls.Add(txtResumenMovimientos);
            mapaPanel.Controls.Add(lstMovimientos);
            mapaPanel.Controls.Add(txtAgregarVehiculos);
            mapaPanel.Controls.Add(btnAgregarVehiculos);
            mapaPanel.Controls.Add(txtSemaforo);
            mapaPanel.Controls.Add(txtVehiculos);
            mapaPanel.Controls.Add(btnSimular);
            mapaPanel.Location = new Point(0, 19);
            mapaPanel.Name = "mapaPanel";
            mapaPanel.Size = new Size(978, 515);
            mapaPanel.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sunday Best", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(270, 16);
            label9.Name = "label9";
            label9.Size = new Size(417, 44);
            label9.TabIndex = 14;
            label9.Text = "Visualización de Punteros ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(610, 203);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 13;
            label5.Text = "Cantidad de Vehículos: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(629, 163);
            label4.Name = "label4";
            label4.Size = new Size(191, 23);
            label4.TabIndex = 12;
            label4.Text = "Estado del Semaforo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(629, 123);
            label3.Name = "label3";
            label3.Size = new Size(191, 23);
            label3.TabIndex = 11;
            label3.Text = "Vehículos Restantes: ";
            label3.Click += label3_Click;
            // 
            // btnDetenerSimulacion
            // 
            btnDetenerSimulacion.BackColor = Color.DarkOrange;
            btnDetenerSimulacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDetenerSimulacion.ForeColor = SystemColors.ControlText;
            btnDetenerSimulacion.Location = new Point(331, 407);
            btnDetenerSimulacion.Name = "btnDetenerSimulacion";
            btnDetenerSimulacion.Size = new Size(161, 37);
            btnDetenerSimulacion.TabIndex = 10;
            btnDetenerSimulacion.Text = "Detener";
            btnDetenerSimulacion.UseVisualStyleBackColor = false;
            btnDetenerSimulacion.Click += btnDetenerSimulacion_Click;
            // 
            // txtResumenMovimientos
            // 
            txtResumenMovimientos.BackColor = Color.Goldenrod;
            txtResumenMovimientos.Location = new Point(629, 235);
            txtResumenMovimientos.Name = "txtResumenMovimientos";
            txtResumenMovimientos.Size = new Size(332, 30);
            txtResumenMovimientos.TabIndex = 9;
            // 
            // lstMovimientos
            // 
            lstMovimientos.BackColor = Color.Goldenrod;
            lstMovimientos.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.ItemHeight = 28;
            lstMovimientos.Location = new Point(501, 333);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(459, 144);
            lstMovimientos.TabIndex = 8;
            // 
            // txtAgregarVehiculos
            // 
            txtAgregarVehiculos.BackColor = Color.Goldenrod;
            txtAgregarVehiculos.Location = new Point(834, 203);
            txtAgregarVehiculos.Name = "txtAgregarVehiculos";
            txtAgregarVehiculos.Size = new Size(126, 30);
            txtAgregarVehiculos.TabIndex = 7;
            // 
            // btnAgregarVehiculos
            // 
            btnAgregarVehiculos.BackColor = Color.DarkOrange;
            btnAgregarVehiculos.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAgregarVehiculos.ForeColor = SystemColors.ControlText;
            btnAgregarVehiculos.Location = new Point(787, 268);
            btnAgregarVehiculos.Name = "btnAgregarVehiculos";
            btnAgregarVehiculos.Size = new Size(173, 35);
            btnAgregarVehiculos.TabIndex = 6;
            btnAgregarVehiculos.Text = "AgregarVehiculos";
            btnAgregarVehiculos.UseVisualStyleBackColor = false;
            btnAgregarVehiculos.Click += btnAgregarVehiculos_Click;
            // 
            // txtSemaforo
            // 
            txtSemaforo.BackColor = Color.Goldenrod;
            txtSemaforo.Location = new Point(835, 155);
            txtSemaforo.Name = "txtSemaforo";
            txtSemaforo.Size = new Size(125, 30);
            txtSemaforo.TabIndex = 5;
            // 
            // txtVehiculos
            // 
            txtVehiculos.BackColor = Color.Goldenrod;
            txtVehiculos.Location = new Point(835, 123);
            txtVehiculos.Name = "txtVehiculos";
            txtVehiculos.Size = new Size(125, 30);
            txtVehiculos.TabIndex = 4;
            // 
            // btnSimular
            // 
            btnSimular.BackColor = Color.DarkOrange;
            btnSimular.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSimular.ForeColor = SystemColors.ControlText;
            btnSimular.Location = new Point(331, 372);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(165, 35);
            btnSimular.TabIndex = 0;
            btnSimular.Text = "SIMULACION";
            btnSimular.UseVisualStyleBackColor = false;
            btnSimular.Click += btnSimular_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(11, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(997, 577);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.MapaProgra;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(pictureBox7);
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(panelVerde7);
            tabPage2.Controls.Add(panelRojo6);
            tabPage2.Controls.Add(panelAmarillo7);
            tabPage2.Controls.Add(panelRojo7);
            tabPage2.Controls.Add(panelVerde5);
            tabPage2.Controls.Add(panelAmarillo6);
            tabPage2.Controls.Add(panelVerde6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(panelAmarillo5);
            tabPage2.Controls.Add(panelRojo5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(panelVerde4);
            tabPage2.Controls.Add(panelAmarillo4);
            tabPage2.Controls.Add(panelRojo3);
            tabPage2.Controls.Add(panelRojo4);
            tabPage2.Controls.Add(panelAmarillo3);
            tabPage2.Controls.Add(panelVerde3);
            tabPage2.Controls.Add(panelVerde2);
            tabPage2.Controls.Add(btnIniciar);
            tabPage2.Controls.Add(panelAmarillo2);
            tabPage2.Controls.Add(lblTemporizador);
            tabPage2.Controls.Add(panelRojo2);
            tabPage2.Controls.Add(panelVerde);
            tabPage2.Controls.Add(panelAmarillo);
            tabPage2.Controls.Add(panelRojo);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(989, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SIMULACIÓN";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.carroDerecha;
            pictureBox7.Location = new Point(501, 255);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(48, 19);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.carroIzquierdaN;
            pictureBox6.Location = new Point(317, 276);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.carroAzul;
            pictureBox5.Location = new Point(437, 333);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // panelVerde7
            // 
            panelVerde7.BackColor = Color.Gray;
            panelVerde7.Location = new Point(405, 224);
            panelVerde7.Name = "panelVerde7";
            panelVerde7.Size = new Size(22, 25);
            panelVerde7.TabIndex = 18;
            // 
            // panelRojo6
            // 
            panelRojo6.BackColor = Color.Gray;
            panelRojo6.Location = new Point(405, 301);
            panelRojo6.Name = "panelRojo6";
            panelRojo6.Size = new Size(22, 25);
            panelRojo6.TabIndex = 15;
            // 
            // panelAmarillo7
            // 
            panelAmarillo7.BackColor = Color.Gray;
            panelAmarillo7.Location = new Point(384, 224);
            panelAmarillo7.Name = "panelAmarillo7";
            panelAmarillo7.Size = new Size(22, 25);
            panelAmarillo7.TabIndex = 17;
            // 
            // panelRojo7
            // 
            panelRojo7.BackColor = Color.Gray;
            panelRojo7.Location = new Point(368, 224);
            panelRojo7.Name = "panelRojo7";
            panelRojo7.Size = new Size(22, 25);
            panelRojo7.TabIndex = 16;
            // 
            // panelVerde5
            // 
            panelVerde5.BackColor = Color.Gray;
            panelVerde5.Location = new Point(474, 344);
            panelVerde5.Name = "panelVerde5";
            panelVerde5.Size = new Size(26, 21);
            panelVerde5.TabIndex = 10;
            // 
            // panelAmarillo6
            // 
            panelAmarillo6.BackColor = Color.Gray;
            panelAmarillo6.Location = new Point(384, 301);
            panelAmarillo6.Name = "panelAmarillo6";
            panelAmarillo6.Size = new Size(22, 25);
            panelAmarillo6.TabIndex = 14;
            // 
            // panelVerde6
            // 
            panelVerde6.BackColor = Color.Gray;
            panelVerde6.Location = new Point(368, 301);
            panelVerde6.Name = "panelVerde6";
            panelVerde6.Size = new Size(22, 25);
            panelVerde6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 75);
            label8.Name = "label8";
            label8.Size = new Size(266, 23);
            label8.TabIndex = 21;
            label8.Text = "Mapa Vial Zona 9, Guatemala ";
            // 
            // panelAmarillo5
            // 
            panelAmarillo5.BackColor = Color.Gray;
            panelAmarillo5.Location = new Point(474, 323);
            panelAmarillo5.Name = "panelAmarillo5";
            panelAmarillo5.Size = new Size(26, 21);
            panelAmarillo5.TabIndex = 9;
            // 
            // panelRojo5
            // 
            panelRojo5.BackColor = Color.Gray;
            panelRojo5.Location = new Point(474, 305);
            panelRojo5.Name = "panelRojo5";
            panelRojo5.Size = new Size(26, 21);
            panelRojo5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sunday Best", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(384, 13);
            label7.Name = "label7";
            label7.Size = new Size(222, 52);
            label7.TabIndex = 20;
            label7.Text = "SIMULACIÓN ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.carroDerecha;
            pictureBox4.Location = new Point(794, 255);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.carroIzquierdaN;
            pictureBox3.Location = new Point(527, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.carroAzul;
            pictureBox2.Location = new Point(647, 171);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carroAmarillo;
            pictureBox1.Location = new Point(681, 325);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panelVerde4
            // 
            panelVerde4.BackColor = Color.Gray;
            panelVerde4.Location = new Point(773, 224);
            panelVerde4.Name = "panelVerde4";
            panelVerde4.Size = new Size(22, 25);
            panelVerde4.TabIndex = 15;
            // 
            // panelAmarillo4
            // 
            panelAmarillo4.BackColor = Color.Gray;
            panelAmarillo4.Location = new Point(752, 224);
            panelAmarillo4.Name = "panelAmarillo4";
            panelAmarillo4.Size = new Size(22, 25);
            panelAmarillo4.TabIndex = 14;
            // 
            // panelRojo3
            // 
            panelRojo3.BackColor = Color.Gray;
            panelRojo3.Location = new Point(621, 301);
            panelRojo3.Name = "panelRojo3";
            panelRojo3.Size = new Size(22, 25);
            panelRojo3.TabIndex = 12;
            // 
            // panelRojo4
            // 
            panelRojo4.BackColor = Color.Gray;
            panelRojo4.Location = new Point(736, 224);
            panelRojo4.Name = "panelRojo4";
            panelRojo4.Size = new Size(22, 25);
            panelRojo4.TabIndex = 13;
            // 
            // panelAmarillo3
            // 
            panelAmarillo3.BackColor = Color.Gray;
            panelAmarillo3.Location = new Point(600, 301);
            panelAmarillo3.Name = "panelAmarillo3";
            panelAmarillo3.Size = new Size(22, 25);
            panelAmarillo3.TabIndex = 12;
            // 
            // panelVerde3
            // 
            panelVerde3.BackColor = Color.Gray;
            panelVerde3.Location = new Point(584, 301);
            panelVerde3.Name = "panelVerde3";
            panelVerde3.Size = new Size(22, 25);
            panelVerde3.TabIndex = 11;
            // 
            // panelVerde2
            // 
            panelVerde2.BackColor = Color.Gray;
            panelVerde2.Location = new Point(615, 227);
            panelVerde2.Name = "panelVerde2";
            panelVerde2.Size = new Size(26, 21);
            panelVerde2.TabIndex = 10;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Yellow;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(425, 447);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(153, 48);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // panelAmarillo2
            // 
            panelAmarillo2.BackColor = Color.Gray;
            panelAmarillo2.Location = new Point(615, 205);
            panelAmarillo2.Name = "panelAmarillo2";
            panelAmarillo2.Size = new Size(26, 21);
            panelAmarillo2.TabIndex = 9;
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Sunday Best", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemporizador.ForeColor = Color.White;
            lblTemporizador.Location = new Point(661, 248);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(58, 52);
            lblTemporizador.TabIndex = 8;
            lblTemporizador.Text = "10";
            // 
            // panelRojo2
            // 
            panelRojo2.BackColor = Color.Gray;
            panelRojo2.Location = new Point(615, 188);
            panelRojo2.Name = "panelRojo2";
            panelRojo2.Size = new Size(26, 21);
            panelRojo2.TabIndex = 8;
            // 
            // panelVerde
            // 
            panelVerde.BackColor = Color.Gray;
            panelVerde.Location = new Point(731, 344);
            panelVerde.Name = "panelVerde";
            panelVerde.Size = new Size(26, 21);
            panelVerde.TabIndex = 7;
            // 
            // panelAmarillo
            // 
            panelAmarillo.BackColor = Color.Gray;
            panelAmarillo.Location = new Point(731, 323);
            panelAmarillo.Name = "panelAmarillo";
            panelAmarillo.Size = new Size(26, 21);
            panelAmarillo.TabIndex = 6;
            // 
            // panelRojo
            // 
            panelRojo.BackColor = Color.Gray;
            panelRojo.Location = new Point(731, 305);
            panelRojo.Name = "panelRojo";
            panelRojo.Size = new Size(26, 21);
            panelRojo.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(mapaPanel);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(989, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "VISUAL";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(192, 255, 192);
            tabPage3.Controls.Add(btnGenerarReportes);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(txtResumenFlujo);
            tabPage3.Controls.Add(LstReporteFlujo);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(989, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "REPORTES";
            // 
            // btnGenerarReportes
            // 
            btnGenerarReportes.BackColor = Color.FromArgb(0, 64, 0);
            btnGenerarReportes.ForeColor = Color.White;
            btnGenerarReportes.Location = new Point(575, 285);
            btnGenerarReportes.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReportes.Name = "btnGenerarReportes";
            btnGenerarReportes.Size = new Size(242, 35);
            btnGenerarReportes.TabIndex = 5;
            btnGenerarReportes.Text = "Generar Reportes Reales";
            btnGenerarReportes.UseVisualStyleBackColor = false;
            btnGenerarReportes.Click += btnGenerarReportes_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sunday Best", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(278, 39);
            label6.Name = "label6";
            label6.Size = new Size(361, 52);
            label6.TabIndex = 4;
            label6.Text = "RESUMEN DE REPORTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(536, 165);
            label2.Name = "label2";
            label2.Size = new Size(308, 32);
            label2.TabIndex = 3;
            label2.Text = "Congestión de vehículos ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 165);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 2;
            label1.Text = "Flujo de vehículos ";
            // 
            // txtResumenFlujo
            // 
            txtResumenFlujo.BackColor = Color.FromArgb(0, 192, 0);
            txtResumenFlujo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResumenFlujo.Location = new Point(486, 213);
            txtResumenFlujo.Name = "txtResumenFlujo";
            txtResumenFlujo.Size = new Size(410, 34);
            txtResumenFlujo.TabIndex = 1;
            // 
            // LstReporteFlujo
            // 
            LstReporteFlujo.BackColor = Color.FromArgb(0, 192, 0);
            LstReporteFlujo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LstReporteFlujo.FormattingEnabled = true;
            LstReporteFlujo.ItemHeight = 28;
            LstReporteFlujo.Location = new Point(35, 213);
            LstReporteFlujo.Name = "LstReporteFlujo";
            LstReporteFlujo.Size = new Size(418, 256);
            LstReporteFlujo.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(255, 192, 128);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(lstCongestiones);
            tabPage4.Controls.Add(lstFlujoVehiculos);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(989, 541);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "R. REAL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sunday Best", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(366, 24);
            label10.Name = "label10";
            label10.Size = new Size(249, 52);
            label10.TabIndex = 2;
            label10.Text = "Reporte Real";
            // 
            // lstCongestiones
            // 
            lstCongestiones.BackColor = Color.FromArgb(255, 128, 0);
            lstCongestiones.FormattingEnabled = true;
            lstCongestiones.ItemHeight = 23;
            lstCongestiones.Location = new Point(529, 103);
            lstCongestiones.Margin = new Padding(3, 4, 3, 4);
            lstCongestiones.Name = "lstCongestiones";
            lstCongestiones.Size = new Size(426, 372);
            lstCongestiones.TabIndex = 1;
            // 
            // lstFlujoVehiculos
            // 
            lstFlujoVehiculos.BackColor = Color.FromArgb(255, 128, 0);
            lstFlujoVehiculos.FormattingEnabled = true;
            lstFlujoVehiculos.ItemHeight = 23;
            lstFlujoVehiculos.Location = new Point(30, 103);
            lstFlujoVehiculos.Margin = new Padding(3, 4, 3, 4);
            lstFlujoVehiculos.Name = "lstFlujoVehiculos";
            lstFlujoVehiculos.Size = new Size(479, 372);
            lstFlujoVehiculos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 579);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mapaPanel.ResumeLayout(false);
            mapaPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mapaPanel;
        private Button btnSimular;
        private TextBox txtVehiculos;
        private TextBox txtSemaforo;
        private Button btnAgregarVehiculos;
        private TextBox txtAgregarVehiculos;
        private ListBox lstMovimientos;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtResumenMovimientos;
        private System.Windows.Forms.Timer timer1;
        private Panel panelVerde;
        private Panel panelAmarillo;
        private Panel panelRojo;
        private Label lblTemporizador;
        private Button btnIniciar;
        private Panel panelVerde2;
        private Panel panelAmarillo2;
        private Panel panelRojo2;
        private Panel panelRojo3;
        private Panel panelAmarillo3;
        private Panel panelVerde3;
        private Panel panelVerde4;
        private Panel panelAmarillo4;
        private Panel panelRojo4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox txtResumenFlujo;
        private ListBox LstReporteFlujo;
        private Button btnDetenerSimulacion;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Panel panelVerde7;
        private Panel panelRojo6;
        private Panel panelAmarillo7;
        private Panel panelRojo7;
        private Panel panelVerde5;
        private Panel panelAmarillo6;
        private Panel panelVerde6;
        private Panel panelAmarillo5;
        private Panel panelRojo5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private TabPage tabPage4;
        private ListBox lstCongestiones;
        private ListBox lstFlujoVehiculos;
        private Button btnGenerarReportes;
        private Label label10;
    }
}
