using SistemaHotel.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace SistemaHotel.Produtos 
   

{
    public partial class FrmProdutos : Form
    {


        string id;

        public FrmProdutos()
        {
            InitializeComponent();
        }


        private void CarregarCombobox()
        {

        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {



            FormatarDG();
        }


        private void BuscarNome()
        {


            FormatarDG();
        }



        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            //txtEstoque.Enabled = true;
            btnImg.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            btnImg.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            LimparFoto();
        }



        private void LimparFoto()
        {
            img.Image = Properties.Resources.sem_foto;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            CarregarCombobox();
            Listar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {


            if (cbFornecedor.Text == "")
            {
                MessageBox.Show("Cadastre Antes um Fornecedor!");
                Close();
            }

            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR

           string conexao = "Host=dpg-daoqgd740ujc7389oejg-a.oregon.render-db;Port=5432;Database=dbdevback_vni0;Username=dbdevback_vni0_user;Password=FlXktdy92QC0gFy3xUgmlnlQYZrRMi5F;";

            private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                txtNome.Text = "";

                MessageBox.Show(
                    "Preencha o Nome",
                    "Campo Vazio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtNome.Focus();
                return;
            }

            if (txtValor.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Preencha o Valor",
                    "Campo Vazio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtValor.Focus();
                return;
            }

            if (txtEstoque.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Preencha o Estoque",
                    "Campo Vazio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtEstoque.Focus();
                return;
            }

            if (cbFornecedor.SelectedValue == null)
            {
                MessageBox.Show(
                    "Selecione um Fornecedor",
                    "Campo Vazio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                cbFornecedor.Focus();
                return;
            }

            // Converter estoque
            if (!int.TryParse(txtEstoque.Text.Trim(), out int estoque))
            {
                MessageBox.Show(
                    "Informe um estoque válido.",
                    "Valor Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEstoque.Focus();
                return;
            }

            // Converter valor usando padrão brasileiro
            if (!decimal.TryParse(
                txtValor.Text.Trim(),
                NumberStyles.Number,
                new CultureInfo("pt-BR"),
                out decimal valor))
            {
                MessageBox.Show(
                    "Informe um valor válido.",
                    "Valor Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtValor.Focus();
                return;
            }

            string conexao =
                "Host=dpg-daoqgd740ujc7389oejg-a.oregon-render-db;" +
                "Port=5432;" +
                "Database=dbdevback_vni0;" +
                "Username=dbdevback_vni0_user;" +
                "Password=SUA_SENHA_AQUI;";

            string sql = @"
        INSERT INTO produtos
        (
            nome,
            descricao,
            estoque,
            id_fornecedor,
            valor
        )
        VALUES
        (
            @nome,
            @descricao,
            @estoque,
            @id_fornecedor,
            @valor
        );
    ";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nome",
                            txtNome.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@descricao",
                            txtDescricao.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@estoque",
                            estoque
                        );

                        cmd.Parameters.AddWithValue(
                            "@id_fornecedor",
                            Convert.ToInt32(cbFornecedor.SelectedValue)
                        );

                        cmd.Parameters.AddWithValue(
                            "@valor",
                            valor
                        );

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Registro Salvo com Sucesso!",
                    "Dados Salvos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;

                limparCampos();
                desabilitarCampos();

                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar o produto:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }





        MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR


            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR


                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                limparCampos();
                desabilitarCampos();
                Listar();
            }
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                img.ImageLocation = foto;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaProdutos == "estoque")
            {
                Program.nomeProduto = grid.CurrentRow.Cells[1].Value.ToString();
                Program.estoqueProduto = grid.CurrentRow.Cells[3].Value.ToString();
                Program.idProduto = grid.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
        }
    }
}