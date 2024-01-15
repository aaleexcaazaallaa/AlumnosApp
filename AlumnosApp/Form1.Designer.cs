namespace AlumnosApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAlumnosAltas = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelListarAlumnos = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSet = new AlumnosApp.practicaDataSet();
            this.alumnosTableAdapter = new AlumnosApp.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.panelAltaEvaluacion = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEvaluacion = new System.Windows.Forms.TextBox();
            this.buttonGuardarEvaluacion = new System.Windows.Forms.Button();
            this.panelListarEvaluaciones = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.practicaDataSet1 = new AlumnosApp.practicaDataSet1();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionesTableAdapter = new AlumnosApp.practicaDataSet1TableAdapters.EvaluacionesTableAdapter();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModificarEvaluacion = new System.Windows.Forms.Button();
            this.buttonBorrarEvaluacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panelAlumnosAltas.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelListarAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).BeginInit();
            this.panelAltaEvaluacion.SuspendLayout();
            this.panelListarEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // panelAlumnosAltas
            // 
            this.panelAlumnosAltas.Controls.Add(this.label6);
            this.panelAlumnosAltas.Controls.Add(this.buttonGuardar);
            this.panelAlumnosAltas.Controls.Add(this.checkBoxBaja);
            this.panelAlumnosAltas.Controls.Add(this.textBoxNIF);
            this.panelAlumnosAltas.Controls.Add(this.label3);
            this.panelAlumnosAltas.Controls.Add(this.label2);
            this.panelAlumnosAltas.Controls.Add(this.label1);
            this.panelAlumnosAltas.Controls.Add(this.textBoxApellidos);
            this.panelAlumnosAltas.Controls.Add(this.textBoxNombre);
            this.panelAlumnosAltas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnosAltas.Location = new System.Drawing.Point(0, 48);
            this.panelAlumnosAltas.Name = "panelAlumnosAltas";
            this.panelAlumnosAltas.Size = new System.Drawing.Size(800, 402);
            this.panelAlumnosAltas.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(332, 309);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(135, 44);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBaja.Location = new System.Drawing.Point(185, 235);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(74, 29);
            this.checkBoxBaja.TabIndex = 6;
            this.checkBoxBaja.Text = "Baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIF.Location = new System.Drawing.Point(286, 172);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(333, 31);
            this.textBoxNIF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.Location = new System.Drawing.Point(286, 129);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(333, 31);
            this.textBoxApellidos.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(286, 87);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(333, 31);
            this.textBoxNombre.TabIndex = 0;
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.label4);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 48);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(800, 402);
            this.panelInicio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 62);
            this.label4.TabIndex = 0;
            this.label4.Text = "APP DE GESTIÓN DE ALUMNADO";
            // 
            // panelListarAlumnos
            // 
            this.panelListarAlumnos.Controls.Add(this.buttonEliminar);
            this.panelListarAlumnos.Controls.Add(this.buttonModificar);
            this.panelListarAlumnos.Controls.Add(this.dataGridView1);
            this.panelListarAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListarAlumnos.Location = new System.Drawing.Point(0, 48);
            this.panelListarAlumnos.Name = "panelListarAlumnos";
            this.panelListarAlumnos.Size = new System.Drawing.Size(800, 402);
            this.panelListarAlumnos.TabIndex = 1;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(41, 367);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(708, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(41, 340);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(708, 23);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.practicaDataSet;
            // 
            // practicaDataSet
            // 
            this.practicaDataSet.DataSetName = "practicaDataSet";
            this.practicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // panelAltaEvaluacion
            // 
            this.panelAltaEvaluacion.Controls.Add(this.label7);
            this.panelAltaEvaluacion.Controls.Add(this.buttonGuardarEvaluacion);
            this.panelAltaEvaluacion.Controls.Add(this.textBoxEvaluacion);
            this.panelAltaEvaluacion.Controls.Add(this.label5);
            this.panelAltaEvaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAltaEvaluacion.Location = new System.Drawing.Point(0, 48);
            this.panelAltaEvaluacion.Name = "panelAltaEvaluacion";
            this.panelAltaEvaluacion.Size = new System.Drawing.Size(800, 402);
            this.panelAltaEvaluacion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Evaluacion";
            // 
            // textBoxEvaluacion
            // 
            this.textBoxEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvaluacion.Location = new System.Drawing.Point(357, 149);
            this.textBoxEvaluacion.Name = "textBoxEvaluacion";
            this.textBoxEvaluacion.Size = new System.Drawing.Size(258, 31);
            this.textBoxEvaluacion.TabIndex = 1;
            // 
            // buttonGuardarEvaluacion
            // 
            this.buttonGuardarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarEvaluacion.Location = new System.Drawing.Point(340, 243);
            this.buttonGuardarEvaluacion.Name = "buttonGuardarEvaluacion";
            this.buttonGuardarEvaluacion.Size = new System.Drawing.Size(127, 60);
            this.buttonGuardarEvaluacion.TabIndex = 2;
            this.buttonGuardarEvaluacion.Text = "Guardar";
            this.buttonGuardarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonGuardarEvaluacion.Click += new System.EventHandler(this.buttonGuardarEvaluacion_Click);
            // 
            // panelListarEvaluaciones
            // 
            this.panelListarEvaluaciones.Controls.Add(this.buttonBorrarEvaluacion);
            this.panelListarEvaluaciones.Controls.Add(this.buttonModificarEvaluacion);
            this.panelListarEvaluaciones.Controls.Add(this.dataGridView2);
            this.panelListarEvaluaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListarEvaluaciones.Location = new System.Drawing.Point(0, 48);
            this.panelListarEvaluaciones.Name = "panelListarEvaluaciones";
            this.panelListarEvaluaciones.Size = new System.Drawing.Size(800, 402);
            this.panelListarEvaluaciones.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evaluacionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.evaluacionesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(794, 282);
            this.dataGridView2.TabIndex = 0;
            // 
            // practicaDataSet1
            // 
            this.practicaDataSet1.DataSetName = "practicaDataSet1";
            this.practicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.practicaDataSet1;
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            // 
            // buttonModificarEvaluacion
            // 
            this.buttonModificarEvaluacion.Location = new System.Drawing.Point(12, 298);
            this.buttonModificarEvaluacion.Name = "buttonModificarEvaluacion";
            this.buttonModificarEvaluacion.Size = new System.Drawing.Size(776, 36);
            this.buttonModificarEvaluacion.TabIndex = 1;
            this.buttonModificarEvaluacion.Text = "Modificar";
            this.buttonModificarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonModificarEvaluacion.Click += new System.EventHandler(this.buttonModificarEvaluacion_Click);
            // 
            // buttonBorrarEvaluacion
            // 
            this.buttonBorrarEvaluacion.Location = new System.Drawing.Point(12, 341);
            this.buttonBorrarEvaluacion.Name = "buttonBorrarEvaluacion";
            this.buttonBorrarEvaluacion.Size = new System.Drawing.Size(776, 37);
            this.buttonBorrarEvaluacion.TabIndex = 2;
            this.buttonBorrarEvaluacion.Text = "Borrar";
            this.buttonBorrarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonBorrarEvaluacion.Click += new System.EventHandler(this.buttonBorrarEvaluacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(452, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "ALTAS DE NUEVOS ALUMNOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "ALTAS DE NUEVAS EVALUACIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAlumnosAltas);
            this.Controls.Add(this.panelAltaEvaluacion);
            this.Controls.Add(this.panelListarEvaluaciones);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelListarAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelAlumnosAltas.ResumeLayout(false);
            this.panelAlumnosAltas.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelListarAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).EndInit();
            this.panelAltaEvaluacion.ResumeLayout(false);
            this.panelAltaEvaluacion.PerformLayout();
            this.panelListarEvaluaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Panel panelAlumnosAltas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelListarAlumnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private practicaDataSet practicaDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Panel panelAltaEvaluacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuardarEvaluacion;
        private System.Windows.Forms.TextBox textBoxEvaluacion;
        private System.Windows.Forms.Panel panelListarEvaluaciones;
        private System.Windows.Forms.DataGridView dataGridView2;
        private practicaDataSet1 practicaDataSet1;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private practicaDataSet1TableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBorrarEvaluacion;
        private System.Windows.Forms.Button buttonModificarEvaluacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

