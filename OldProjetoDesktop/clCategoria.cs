using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OldProjetoDesktop
{
    class clCategoria
    {
        public int IDCategoria;
        public string nome;

        conectaBD BD = new conectaBD();

        public int Salvar() 
        {
            int IDCategoria = 0;
            try 
            {
                BD._sql = string.Format(new CultureInfo("en-US"), "INSERT INTO CATEGORIA ( NOME) " +
                                                                  " values ('{0}')", nome ) + "; SELECT SCOPE_IDENTITY();";
                BD.ExecutaComando(false, out IDCategoria);

                if (IDCategoria > 0) 
                {
                    MessageBox.Show("Categoria cadastrada com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Erro ao cadastrar Categoria", "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return IDCategoria;
        }
    }

    


}
