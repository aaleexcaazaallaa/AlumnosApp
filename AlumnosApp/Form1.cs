using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlumnosApp
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter oleAdapter;
        OleDbCommand oleCommand;
        OleDbCommandBuilder oleBuilder;
        DataSet dataSet;
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AltasNotas();
            eliminarPaneles();
            mostrarPanelInicio();
        }

        private void mostrarPanelInicio()
        {
            panelInicio.Visible = true; ;
        }

        private void mostrarPanelAlumnosAltas()
        {
            panelAlumnosAltas.Visible = true; ;
        }
        private void mostrarPanelEvaluacionesAltas()
        {
            panelAltaEvaluacion.Visible = true; ;
        }

        private void mostrarPanelListarAlumnos()
        {
            panelListarAlumnos.Visible = true; ;
            this.listarAlumnos();
        }

        private void mostrarPanelListarEvaluaciones()
        {
            panelListarEvaluaciones.Visible = true; ;
            this.listarEvaluaciones();
        }

        private void mostrarPanelNotas()
        {
            panelNotas.Visible = true; 
            this.cargarAlumnosEnNotas();
            cargarComboBoxEvaluaciones();
        }

        private void eliminarPaneles()
        {
            panelAlumnosAltas.Visible = false;
            panelInicio.Visible = false;
            panelListarAlumnos.Visible = false;
            panelAltaEvaluacion.Visible = false;
            panelListarEvaluaciones.Visible = false;
            panelNotas.Visible = false;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelAlumnosAltas();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelEvaluacionesAltas();
        }

        private void AltasAlumnos(string nombre, string apellidos, string NIF, bool baja)
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "insert into Alumnos (Nombre,Apellidos,NIF,Baja) values ('" + nombre + "'," + "'" + apellidos + "'," + "'" + NIF + "'," + baja + ")";
            OleDbConnection connection;
            OleDbCommand command;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sentencia, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("El alumno " + nombre + " " + apellidos + " ha sido dado de alta exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
        }

        private void AltasEvaluaciones(string evaluacion)
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "insert into Evaluaciones (Evaluacion) values ('" + evaluacion + "')";
            OleDbConnection connection;
            OleDbCommand command;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sentencia, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("La evaluacion ha sido dada de alta exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
        }

        private void listarAlumnos()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "select * FROM Alumnos";
            OleDbConnection connection;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                this.oleCommand = new OleDbCommand(sentencia, connection);
                this.oleAdapter = new OleDbDataAdapter(this.oleCommand);
                this.oleBuilder = new OleDbCommandBuilder(this.oleAdapter);
                this.dataSet = new DataSet();
                this.oleAdapter.Fill(dataSet, "Alumnos");
                this.table = dataSet.Tables["Alumnos"];
                connection.Close();
                dataGridView1.DataSource = dataSet.Tables["Alumnos"];
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.ToString());
            }
        }

        private void listarEvaluaciones()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "select * FROM Evaluaciones";
            OleDbConnection connection;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                this.oleCommand = new OleDbCommand(sentencia, connection);
                this.oleAdapter = new OleDbDataAdapter(this.oleCommand);
                this.oleBuilder = new OleDbCommandBuilder(this.oleAdapter);
                this.dataSet = new DataSet();
                this.oleAdapter.Fill(dataSet, "Evaluaciones");
                this.table = dataSet.Tables["Evaluaciones"];
                connection.Close();
                dataGridView2.DataSource = dataSet.Tables["Evaluaciones"];
                dataGridView2.ReadOnly = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.ToString());
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellidos.Text;
            string NIF = textBoxNIF.Text;
            bool baja = checkBoxBaja.Checked;
            if (nombre.Equals("") || apellido.Equals("") || NIF.Equals(""))
            {
                MessageBox.Show("Quedan campos por rellenar");
            }
            else
            {
                AltasAlumnos(nombre, apellido, NIF, baja);
                textBoxNombre.ResetText();
                textBoxApellidos.ResetText();
                textBoxNIF.ResetText();
                checkBoxBaja.Checked = false;
            }

        }

        private void buttonGuardarEvaluacion_Click(object sender, EventArgs e)
        {
            string evaluacion = textBoxEvaluacion.Text;
            if (evaluacion.Equals(""))
            {
                MessageBox.Show("Quedan campos por rellenar");
            }
            else
            {
                AltasEvaluaciones(evaluacion);
                textBoxEvaluacion.ResetText();
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarAlumnos();
            dataGridView1.ReadOnly = true;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarEvaluaciones();
            dataGridView2.ReadOnly = true;
            buttonModificarEvaluacion.Enabled = false;
            buttonBorrarEvaluacion.Enabled = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarAlumnos();
            dataGridView1.ReadOnly = false;
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = false;
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarEvaluaciones();
            dataGridView2.ReadOnly = false;
            buttonModificarEvaluacion.Enabled = true;
            buttonBorrarEvaluacion.Enabled = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            oleAdapter.Update(table);
            listarAlumnos();
            dataGridView1.ReadOnly = true;
        }

        private void buttonModificarEvaluacion_Click(object sender, EventArgs e)
        {
            oleAdapter.Update(table);
            listarEvaluaciones();
            dataGridView2.ReadOnly = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarAlumnos();
            dataGridView1.ReadOnly = false;
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = true;
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelListarEvaluaciones();
            dataGridView2.ReadOnly = false;
            buttonModificarEvaluacion.Enabled = false;
            buttonBorrarEvaluacion.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Object item = dataGridView1.SelectedRows[0].Index;
                if (MessageBox.Show("¿Seguro que quieres borrar a este alumno?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    oleAdapter.Update(table);
                    listarAlumnos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay alumno seleccionado");
            }
        }

        private void buttonBorrarEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                Object item = dataGridView2.SelectedRows[0].Index;
                if (MessageBox.Show("¿Seguro que quieres borrar esta evaluacion?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                    oleAdapter.Update(table);
                    listarEvaluaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay evaluacion seleccionada");
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaneles();
            mostrarPanelNotas();
        }

        private void cargarAlumnosEnNotas()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "select Id, Nombre, Apellidos FROM Alumnos";
            OleDbConnection connection;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                this.oleCommand = new OleDbCommand(sentencia, connection);
                this.oleAdapter = new OleDbDataAdapter(this.oleCommand);
                this.oleBuilder = new OleDbCommandBuilder(this.oleAdapter);
                this.dataSet = new DataSet();
                this.oleAdapter.Fill(dataSet, "Alumnos");
                this.table = dataSet.Tables["Alumnos"];
                connection.Close();
                listBox1.DataSource = dataSet.Tables["Alumnos"];
                listBox1.ValueMember = "Id";
                table.Columns.Add("NombreCompleto", typeof(string), "Id + ' - ' + Nombre + ' ' + Apellidos");
                listBox1.DisplayMember = "NombreCompleto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.ToString());
            }
        }

        private void cargarComboBoxEvaluaciones()
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string ole = null;
            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            ole = "select Id, Evaluacion from Evaluaciones";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(ole, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBoxEvaluaciones.DataSource = ds.Tables[0];
                comboBoxEvaluaciones.ValueMember = "Id";
                comboBoxEvaluaciones.DisplayMember = "Evaluacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
        }

        private void listarNotasEvaluaciones()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "select DI, PMDM, AD from Notas where id_Evaluacion = " + comboBoxEvaluaciones.SelectedValue.ToString() + " AND id_Alumno = " + listBox1.SelectedValue.ToString() ;
            OleDbConnection connection;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                this.oleCommand = new OleDbCommand(sentencia, connection);
                this.oleAdapter = new OleDbDataAdapter(this.oleCommand);
                this.oleBuilder = new OleDbCommandBuilder(this.oleAdapter);
                this.dataSet = new DataSet();
                this.oleAdapter.Fill(dataSet, "Notas");
                this.table = dataSet.Tables["Notas"];
                connection.Close();
                dataGridView3.DataSource = dataSet.Tables["Notas"];
                dataGridView3.ReadOnly = true;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.ToString());
            }
        }

        private void buttonVerNotas_Click(object sender, EventArgs e)
        {
            if (checkBoxTotal.Checked) {
                listarTodasNotasEvaluaciones();
            }
            else
            {
                listarNotasEvaluaciones();
            }
            
        }
        
        private void listarTodasNotasEvaluaciones()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "select id_Alumno , DI, PMDM, AD from Notas where id_Evaluacion = " + comboBoxEvaluaciones.SelectedValue.ToString() ;
            OleDbConnection connection;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                this.oleCommand = new OleDbCommand(sentencia, connection);
                this.oleAdapter = new OleDbDataAdapter(this.oleCommand);
                this.oleBuilder = new OleDbCommandBuilder(this.oleAdapter);
                this.dataSet = new DataSet();
                this.oleAdapter.Fill(dataSet, "Notas");
                this.table = dataSet.Tables["Notas"];
                connection.Close();
                dataGridView3.DataSource = dataSet.Tables["Notas"];
                dataGridView3.ReadOnly = true;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open the connection ! " + ex.ToString());
            }
        }
       
        //Metodo para insertar notas para probar
        private void AltasNotas()
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "insert into Notas (id_Alumno, id_Evaluacion,DI,PMDM,AD) values (" + 6 + "," + 5 + "," + 10 + "," + 10 + "," + 10 + ")";
            OleDbConnection connection;
            OleDbCommand command;
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sentencia, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
        }


        private void checkBoxTotal_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = !listBox1.Enabled;
        }
    }
}
