namespace ponaExamen.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;

        List<Usuario> usuariosPermitidos = new List<Usuario>()
        {
            new Usuario { NombreUsuario = "estudiante2024", Contrasena = "uisrael2024" },
            new Usuario { NombreUsuario = "examen1", Contrasena = "parcial1" },
            new Usuario { NombreUsuario = "pona", Contrasena = "2024" }
        };


        bool inicioSesionValido = usuariosPermitidos.Any(usuario =>
       usuario.NombreUsuario == usuarioIngresado && usuario.Contrasena == contrasenaIngresada);


        if (inicioSesionValido)
        {

            Navigation.PushAsync(new vRegistro());

        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrasena incorrectos", "Cerrar");
        }




    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcercaDe());
    }
}