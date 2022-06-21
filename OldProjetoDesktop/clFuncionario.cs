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
    class clFuncionario
    {
        public int IdFuncionario;
        public string nome;
        public string CPF;
        public DateTime dataCadastroFuncionario;
        public string senha;
        public string re;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int IdFuncionario = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FUNCIONARIO ( NOME, CPF, DATACADASTRO, SENHA, RE )" +
                                                        " values ( '{0}','{1}','{2}','{3}','{4}' )",
                                                        dataCadastroFuncionario.ToShortTimeString(), nome, CPF, senha, re) + "; SELECT SCOPE_IDENTITY(); ";
                BD.ExecutaComando(false, out IdFuncionario);

                if (IdFuncionario > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!", "Cadastro concluido com sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return IdFuncionario;

        }

        public void Excluir()
        {

        }      

    }

}

