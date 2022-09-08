using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crud_Renovare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;

        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=Augusta;Data Source=BEATRIZCAMARA\SQLSERVER"; // Necessária alteração para a conexão do banco de dados utilizado

        private string strSql = string.Empty;

        private void tsbSalvar_Click(object sender, EventArgs e)
        {

            strSql = "insert into Renovare (Tipo, Modalidade, Endereco, Numero, Complemento, CEP, Cidade, UF, Area, Quartos, Banheiros, Vagas) values (@Tipo, @Modalidade, @Endereco, @Numero, @Complemento, @CEP, @Cidade, @UF, @Area, @Quartos, @Banheiros, @Vagas)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //comando.Parameters.Add("ID", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("Tipo", SqlDbType.VarChar).Value = cmbTipo.Text;
            comando.Parameters.Add("Modalidade", SqlDbType.VarChar).Value = cmbModalidade.Text;
            comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("Numero", SqlDbType.Int).Value = txtNumero.Text;
            comando.Parameters.Add("Complemento", SqlDbType.VarChar).Value = txtComplemento.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
            comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("UF", SqlDbType.VarChar).Value = cmbUf.Text;
            comando.Parameters.Add("Area", SqlDbType.Int).Value = txtArea.Text;
            comando.Parameters.Add("Quartos", SqlDbType.Int).Value = cmbQuartos.Text;
            comando.Parameters.Add("Banheiros", SqlDbType.Int).Value = cmbBanheiros.Text;
            comando.Parameters.Add("Vagas", SqlDbType.Int).Value = cmbVagas.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado com sucesso!");
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close(); 
            }

            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            tstIdBuscar.Enabled = true;
            txtId.Enabled = false;
            cmbTipo.Enabled = false;
            cmbModalidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            mskCep.Enabled = false;
            txtCidade.Enabled = false;
            cmbUf.Enabled = false;
            txtArea.Enabled = false;
            cmbQuartos.Enabled = false;
            cmbBanheiros.Enabled = false;
            cmbVagas.Enabled = false;
            txtId.Clear();
            cmbTipo.Text = "";
            cmbModalidade.Text = "";
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            mskCep.Clear();
            txtCidade.Clear();
            cmbUf.Text = "";
            txtArea.Clear();
            cmbQuartos.Text = "";
            cmbBanheiros.Text = "";
            cmbVagas.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Renovare where ID = @ID";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("ID", SqlDbType.Int).Value = tstIdBuscar.Text;

            try
            {
                if(tstIdBuscar.Text == String.Empty)
                {
                    throw new Exception("ID não informado!");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("ID não cadastrado!");
                }

                dr.Read();

                txtId.Text = Convert.ToString(dr["ID"]);
               cmbTipo.Text = Convert.ToString(dr["Tipo"]);
                cmbModalidade.Text = Convert.ToString(dr["Modalidade"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
                txtNumero.Text = Convert.ToString(dr["Numero"]);
                txtComplemento.Text = Convert.ToString(dr["Complemento"]);
                mskCep.Text = Convert.ToString(dr["CEP"]);
                txtCidade.Text = Convert.ToString(dr["Cidade"]);
                cmbUf.Text = Convert.ToString(dr["UF"]);
                txtArea.Text = Convert.ToString(dr["Area"]);
                cmbQuartos.Text = Convert.ToString(dr["Quartos"]);
                cmbBanheiros.Text = Convert.ToString(dr["Banheiros"]);
                cmbVagas.Text = Convert.ToString(dr["Vagas"]);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbEditar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbBuscar.Enabled = true;
            tstIdBuscar.Enabled = true;
            txtId.Enabled = false;
            cmbTipo.Enabled = true;
            cmbModalidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mskCep.Enabled = true;
            txtCidade.Enabled = true;
            cmbUf.Enabled = true;
            txtArea.Enabled = true;
            cmbQuartos.Enabled = true;
            cmbBanheiros.Enabled = true;
            cmbVagas.Enabled = true;

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            strSql = "update Renovare set Tipo = @Tipo, Modalidade = @Modalidade, Endereco = @Endereco, Numero = @Numero, Complemento = @Complemento, CEP = @CEP, Cidade = @Cidade, UF = @UF, Area = @Area, Quartos = @Quartos, Banheiros = @Banheiros, Vagas = @Vagas where ID = @IdBuscar";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("IdBuscar", SqlDbType.Int).Value = tstIdBuscar.Text;
            comando.Parameters.Add("ID", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("Tipo", SqlDbType.VarChar).Value = cmbTipo.Text;
            comando.Parameters.Add("Modalidade", SqlDbType.VarChar).Value = cmbModalidade.Text;
            comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("Numero", SqlDbType.Int).Value = txtNumero.Text;
            comando.Parameters.Add("Complemento", SqlDbType.VarChar).Value = txtComplemento.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
            comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("UF", SqlDbType.VarChar).Value = cmbUf.Text;
            comando.Parameters.Add("Area", SqlDbType.Int).Value = txtArea.Text;
            comando.Parameters.Add("Quartos", SqlDbType.Int).Value = cmbQuartos.Text;
            comando.Parameters.Add("Banheiros", SqlDbType.Int).Value = cmbBanheiros.Text;
            comando.Parameters.Add("Vagas", SqlDbType.Int).Value = cmbVagas.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();

            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            tstIdBuscar.Enabled = true;
            txtId.Enabled = false;
            cmbTipo.Enabled = false;
            cmbModalidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            mskCep.Enabled = false;
            txtCidade.Enabled = false;
            cmbUf.Enabled = false;
            txtArea.Enabled = false;
            cmbQuartos.Enabled = false;
            cmbBanheiros.Enabled = false;
            cmbVagas.Enabled = false;
             txtId.Clear();
             cmbTipo.Text = "";
             cmbModalidade.Text = "";
             txtEndereco.Clear();
             txtNumero.Clear();
             txtComplemento.Clear();
             mskCep.Clear();
             txtCidade.Clear();
             cmbUf.Text = "";
             txtArea.Clear();
             cmbQuartos.Text = "";
             cmbBanheiros.Text = "";
             cmbVagas.Text = "";
             tstIdBuscar.Text = "";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir este Registro?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");

            }
            else
            {
                strSql = "delete from Renovare where ID = @IdBuscar";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tstIdBuscar.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Excluído com sucesso!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbEditar.Enabled = false;
                tsbExcluir.Enabled = false;
                tsbBuscar.Enabled = true;
                tstIdBuscar.Enabled = true;
                txtId.Enabled = false;
                cmbTipo.Enabled = false;
                cmbModalidade.Enabled = false;
                txtEndereco.Enabled = false;
                txtNumero.Enabled = false;
                txtComplemento.Enabled = false;
                mskCep.Enabled = false;
                txtCidade.Enabled = false;
                cmbUf.Enabled = false;
                txtArea.Enabled = false;
                cmbQuartos.Enabled = false;
                cmbBanheiros.Enabled = false;
                cmbVagas.Enabled = false;
                txtId.Clear();
                cmbTipo.Text = "";
                cmbModalidade.Text = "";
                txtEndereco.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                mskCep.Clear();
                txtCidade.Clear();
                cmbUf.Text = "";
                txtArea.Clear();
                cmbQuartos.Text = "";
                cmbBanheiros.Text = "";
                cmbVagas.Text = "";
                tstIdBuscar.Text = "";

            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = false;
            tstIdBuscar.Enabled = false;
            txtId.Enabled = false;
            cmbTipo.Enabled = true;
            cmbModalidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mskCep.Enabled = true;
            txtCidade.Enabled = true;
            cmbUf.Enabled = true;
            txtArea.Enabled = true;
            cmbQuartos.Enabled = true;
            cmbBanheiros.Enabled = true;
            cmbVagas.Enabled = true;
            txtId.Clear();
            cmbTipo.Text = "";
            cmbModalidade.Text = "";
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            mskCep.Clear();
            txtCidade.Clear();
            cmbUf.Text = "";
            txtArea.Clear();
            cmbQuartos.Text = "";
            cmbBanheiros.Text = "";
            cmbVagas.Text = "";
            tstIdBuscar.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            tstIdBuscar.Enabled = true;
            txtId.Enabled = false;
            cmbTipo.Enabled = false;
            cmbModalidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            mskCep.Enabled = false;
            txtCidade.Enabled = false;
            cmbUf.Enabled = false;
            txtArea.Enabled = false;
            cmbQuartos.Enabled = false;
            cmbBanheiros.Enabled = false;
            cmbVagas.Enabled = false;
        }
    }
}