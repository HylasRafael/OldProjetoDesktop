using OldProjetoDesktop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldProjetoDesktop
{
    class clUsuario
    {
        public int idFuncionario;
        public string nome;
        public string cpf;
        public string dataCadastro;
        public string senha;
        public string re;

        conectaBD BD = new conectaBD();

        public DataTable EfetuarLogin()
        {
            try
            {
                BD._sql = "SELECT * FROM FUNCIONARIO " + 
                         " WHERE RE LIKE '" + re + "' ";

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
