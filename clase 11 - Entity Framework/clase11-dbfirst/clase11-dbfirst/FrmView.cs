using clase11_dbfirst.Database;
using clase11_dbfirst.Models;
using System.Linq;

namespace clase11_dbfirst
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        public void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using(CoderContext database =  new CoderContext())
            {
                List<Usuario> usuarios = database.Usuarios.ToList();

                this.dgvListado.DataSource = usuarios;

                
                var usuarioSeleccionado = from usuario in usuarios where usuario.Id == 3 select usuario;

                var user = usuarioSeleccionado.ToList().First();


                var user2   = usuarios.Where(u=> u.Id == 3).ToList().First();



                MessageBox.Show(user.Nombre);
                MessageBox.Show(user2.Nombre);



            }
        }
    }
}
