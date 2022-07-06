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
    class clCliente
    {
        // atributos
        public int IDCliente;
        public DateTime dataCadastro;
        public string nome;
        public DateTime dataNascimento;
        public string CPF;
        public string telefone;
        public string endereco;
        public string bairro;
        public string cidade;
        public string UF;
        

        conectaBD BD = new conectaBD();

        // métodos
        public int Salvar()
        {
            int IDCliente = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE ( DATACADASTRO,NOME,DATANASCIMENTO, " +
                                                       "CPF,TELEFONE,ENDERECO,BAIRRO,CIDADE,UF) " +
                                              " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' )",
                                                dataCadastro.ToShortDateString(), nome, dataNascimento.ToShortDateString(), CPF, telefone, endereco,
                                                bairro, cidade, UF) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out IDCliente);

                if (IDCliente > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, 
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, 
                                 MessageBoxIcon.Error);
            }

            return IDCliente;


        }

        public void Excluir()
        {
            try
            {
                int exOK = 0;

                BD._sql = "DELETE FROM CLIENTE = " + IDCliente;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Cliente Deletado!", "Salvo com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao Deletar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void Atualizar()
        {

        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM CLIENTE " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void PesquisaPorCPFCNPJ()
        {

        }

        public void PesquisaPorRGIE()
        {

        }
    }
}
