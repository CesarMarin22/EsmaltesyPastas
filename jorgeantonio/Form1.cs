using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregadas
using System.Data.SqlClient;

namespace jorgeantonio
{
    public partial class FormaReporte : Form
    {
        conexion c;
        SqlDataAdapter da;//select
        DataTable dt;//datos a tabla
        SqlCommand cmd;//comando
        DataGridView dgv;
        SqlDataReader dr;
        public FormaReporte()
        {
            
            InitializeComponent();
            Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cargaTurnoCombo();
            cargaMolinoCombo();
            cargaEsmalteCombo();
            //AgregarBoton.Enabled = false;//evita mandar datos nullos
            cargarDatos(dataGridBaseDatos);
        }

        private void cargaTurnoCombo()
        {        
            TurnoCombo.Items.Insert(0,"Matutino");
            TurnoCombo.SelectedIndex = 0; /// hace que aparezca la opcion de matutino por default
            TurnoCombo.Items.Insert(1,"Vespertino");
            TurnoCombo.Items.Insert(2,"Nocturno");
        }

        private void cargaEsmalteCombo()
        {
            EsmalteCombo.Items.Insert(0,"Engobe B/D");
            EsmalteCombo.SelectedIndex = 0; // hace qe aparezca la opcion de engobe B/D por default 
            EsmalteCombo.Items.Insert(1,"Engobe Baja Pieza");
            EsmalteCombo.Items.Insert(2,"Mate");
            EsmalteCombo.Items.Insert(3,"Semibrillo");
            EsmalteCombo.Items.Insert(4,"Cerosa");
            EsmalteCombo.Items.Insert(5,"Cubierta");
            EsmalteCombo.Items.Insert(6,"Cristalina(2387)");
            EsmalteCombo.Items.Insert(7,"Cristalina(2377)");
            EsmalteCombo.Items.Insert(8,"Arteza");
            EsmalteCombo.Items.Insert(9,"Lybia");
        }

        private void cargaMolinoCombo()
        {
            MolinoCombo.Items.Insert(0,"1");
            MolinoCombo.SelectedIndex = 0; // hace que parezca la opcion de 1 por default
            MolinoCombo.Items.Insert(1,"2");
            MolinoCombo.Items.Insert(2,"3");
            MolinoCombo.Items.Insert(2,"4");
            MolinoCombo.Items.Insert(3,"5");
            MolinoCombo.Items.Insert(4,"6");
            MolinoCombo.Items.Insert(5,"7");
            MolinoCombo.Items.Insert(6,"8");
            MolinoCombo.Items.Insert(7,"9");
            MolinoCombo.Items.Insert(8,"10");
            MolinoCombo.Items.Insert(9,"11");
            MolinoCombo.Items.Insert(10,"12");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new conexion();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormaReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.cerrarConexion();
        }

        public void cargarDatos(DataGridView d)
        {
          try
          {
            
             c = new conexion();
             da = new SqlDataAdapter("SELECT * FROM GENERAL.REPORTE", c.regresaConexion());
             dt = new DataTable();
             da.Fill(dt);
             d.DataSource = dt;
             c.cerrarConexion();
                if (dataGridBaseDatos.RowCount == 0)
                {
                    ModificarBoton.Enabled = false;
                    EliminarBoton.Enabled = false;
                }
                if (dataGridBaseDatos.RowCount != 0)
                {
                    ModificarBoton.Enabled = true;
                    EliminarBoton.Enabled = true;
                }

            }
          catch (Exception ex)
           {
               MessageBox.Show("No se cargar los datos");
               c.cerrarConexion();
           }
            
        }

        private void FormaReporte_Click(object sender, EventArgs e)
        {
           
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            bool existe = false;
            c = new conexion();
            try
            {
              if (FolioText.Text == "" || LoteText.Text == "" || OperadorText.Text == "" || TiempoText.Text == "" || DensidadText.Text == "" || ResiduoText.Text == "" || ViscosidadText.Text == "" || CtdAguaText.Text == "")
              {
                 MessageBox.Show("Faltan campos por llenar");
              }
              else
              {
                    for(int i = 0; i < dataGridBaseDatos.RowCount; i++)
                    {
                        if(dataGridBaseDatos.Rows[i].Cells[1].Value.ToString() == FolioText.Text)
                        {
                            existe = true;
                            if (existe == true)
                            {
                                MessageBox.Show("El reporte ya esta dado de alta");
                                ClaveText.Text = "";
                                FolioText.Text = "";
                                TurnoCombo.Text = "";
                                EsmalteCombo.Text = "";
                                LoteText.Text = "";
                                OperadorText.Text = "";
                                MolinoCombo.Text = "";
                                TiempoText.Text = "";
                                DensidadText.Text = "";
                                ResiduoText.Text = "";
                                ViscosidadText.Text = "";
                                CtdAguaText.Text = "";
                            }
                        }
                    }
                    if(existe==false)
                    {
                        if (FolioText.Text == "" || LoteText.Text == "" || OperadorText.Text == "" || TiempoText.Text == "" || DensidadText.Text == "" || ResiduoText.Text == "" || ViscosidadText.Text == "" || CtdAguaText.Text == "")
                            MessageBox.Show("Falatan campos por llenar");
                        else
                        {
                            string sq = "INSERT INTO  GENERAL.REPORTE(folio, turno, esmalte, lote, operador, molino, tiempo, densidad, residuos, viscosidad, cantidadAgua, fecha) VALUES (" + FolioText.Text + ",'" + TurnoCombo.SelectedItem + "','" + EsmalteCombo.SelectedItem + "'," + LoteText.Text + ",'" + OperadorText.Text + "'," + MolinoCombo.SelectedItem + ", '" + TiempoText.Text + "', " + DensidadText.Text + ", " + ResiduoText.Text + ", " + ViscosidadText.Text + ", " + CtdAguaText.Text + ",GETDATE())";
                            cmd = new SqlCommand(sq, c.regresaConexion());
                            MessageBox.Show("Reporte Insertado");
                            cmd.ExecuteNonQuery();
                            ClaveText.Text = "";
                            FolioText.Text = "";
                            TurnoCombo.Text = "";
                            EsmalteCombo.Text = "";
                            LoteText.Text = "";
                            OperadorText.Text = "";
                            MolinoCombo.Text = "";
                            TiempoText.Text = "";
                            DensidadText.Text = "";
                            ResiduoText.Text = "";
                            ViscosidadText.Text = "";
                            CtdAguaText.Text = "";
                            cargarDatos(dataGridBaseDatos);
                        }
                    }
                   

                }
                      
            }
            catch (Exception ex)
            {
               MessageBox.Show("error de inserccion" + ex);
            }
                        c.cerrarConexion();           
        }

        private void dataGridBaseDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                dataGridBaseDatos.Rows[e.RowIndex].Selected = true;
                ClaveText.Text = dataGridBaseDatos.CurrentRow.Cells[0].Value.ToString();
                FolioText.Text = dataGridBaseDatos.CurrentRow.Cells[1].Value.ToString();
                TurnoCombo.Text = dataGridBaseDatos.CurrentRow.Cells[2].Value.ToString();
                EsmalteCombo.Text = dataGridBaseDatos.CurrentRow.Cells[3].Value.ToString();
                LoteText.Text = dataGridBaseDatos.CurrentRow.Cells[4].Value.ToString();
                OperadorText.Text = dataGridBaseDatos.CurrentRow.Cells[5].Value.ToString();
                MolinoCombo.Text = dataGridBaseDatos.CurrentRow.Cells[6].Value.ToString();
                TiempoText.Text = dataGridBaseDatos.CurrentRow.Cells[7].Value.ToString();
                DensidadText.Text = dataGridBaseDatos.CurrentRow.Cells[8].Value.ToString();
                ResiduoText.Text = dataGridBaseDatos.CurrentRow.Cells[9].Value.ToString();
                ViscosidadText.Text = dataGridBaseDatos.CurrentRow.Cells[10].Value.ToString();
                CtdAguaText.Text = dataGridBaseDatos.CurrentRow.Cells[11].Value.ToString();
                Fecha.Text = DateTime.Parse(dataGridBaseDatos.CurrentRow.Cells[12].Value.ToString()).ToString("yyyy-MM-dd");
           
           
        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("UPDATE GENERAL.REPORTE SET folio ="+FolioText.Text+",turno='"+TurnoCombo.SelectedItem+"',esmalte='"+EsmalteCombo.SelectedItem+"',lote="+LoteText.Text+",operador='"+OperadorText.Text+"',molino="+MolinoCombo.SelectedItem+",tiempo='"+TiempoText.Text+"',densidad="+DensidadText.Text+",residuos="+ResiduoText.Text+",viscosidad="+ViscosidadText.Text+",cantidadAgua="+CtdAguaText.Text+" WHERE id_reporte="+dataGridBaseDatos[0,0].Value, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("Reporte modificado");
                ClaveText.Text = "";
                FolioText.Text = "";
                TurnoCombo.Text = "";
                EsmalteCombo.Text = "";
                LoteText.Text = "";
                OperadorText.Text = "";
                MolinoCombo.Text = "";
                TiempoText.Text = "";
                DensidadText.Text = "";
                ResiduoText.Text = "";
                ViscosidadText.Text = "";
                CtdAguaText.Text = "";
                cargarDatos(dataGridBaseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM GENERAL.REPORTE WHERE id_reporte =" + ClaveText.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                cargarDatos(dataGridBaseDatos);
                MessageBox.Show("Reporte eliminado");
                FolioText.Text = "";
                TurnoCombo.Text = "";
                EsmalteCombo.Text = "";
                LoteText.Text = "";
                OperadorText.Text = "";
                MolinoCombo.Text = "";
                TiempoText.Text = "";
                DensidadText.Text = "";
                ResiduoText.Text = "";
                ViscosidadText.Text = "";
                CtdAguaText.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar reporte");
                c.cerrarConexion();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

//////////////////////////en este metodo se hace que el textbox de densidad solo acepte numeros y solo un pnto decimal////////////////////
        private void DensidadText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DensidadText.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                       {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar =='.' || e.KeyChar =='\b')
                          {
                    e.Handled = false;
                }
            }
        }

        private void ResiduoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResiduoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ResiduoText.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void ViscosidadText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ViscosidadText.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void CtdAguaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CtdAguaText.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void FolioText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LoteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void OperadorText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}




/*for (int i = 0; i < dataGridBaseDatos.RowCount; i++)
                   {
                       if (dataGridBaseDatos.Rows[i].Cells[1].Value.ToString() == FolioText.Text)
                       {
                           existe = true;
                           if (existe == true)
                           {
                               MessageBox.Show("El reporte ya esta dado de alta");
                               ClaveText.Text = "";
                               FolioText.Text = "";
                               TurnoCombo.Text = "";
                               EsmalteCombo.Text = "";
                               LoteText.Text = "";
                               OperadorText.Text = "";
                               MolinoCombo.Text = "";
                               TiempoText.Text = "";
                               DensidadText.Text = "";
                               ResiduoText.Text = "";
                               ViscosidadText.Text = "";
                               CtdAguaText.Text = "";
                           }
                       }
                   }*/
