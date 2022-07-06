using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OldProjetoDesktop
{
    class clProduto
    {
        public int IDProduto;
        public DateTime dataCadastro;
        public string nome;
        public string descricao;
        public decimal valor;
        public int id_categoria;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int IDProduto = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTOS ( DATACADASTRO, NOME, DESCRICAO, VALOR, ID_CATEGORIA ) " +
                                                                  " values ('{0}','{1}','{2}','{3}','{4}')",
                                                dataCadastro.ToShortDateString(), nome, descricao, valor, id_categoria) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out IDProduto);

                if (IDProduto > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            return IDProduto;
        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM produtos " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PesquisaCategoria()
        {
            try
            {
                BD._sql = "SELECT id_categoria, nome FROM Categoria";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
