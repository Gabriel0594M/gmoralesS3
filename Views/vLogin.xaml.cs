namespace gmoralesS3.Views;

public partial class vLogin : ContentPage
{

	string usuario = " ", contraseña = " ";

	public vLogin()
	{
		InitializeComponent();
	}

	public vLogin(string ususarioNuevo, string contrasenaNueva)
	{
		InitializeComponent();
		usuario = ususarioNuevo;
		contraseña = contrasenaNueva;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {

		try
		{
			string usuarioIngreso = txtUsuario.Text;
			string contrasenaIngreso = txtContraseña.Text;

			if  (usuarioIngreso == usuario && contrasenaIngreso == contraseña)
            {
				Navigation.PushAsync(new vReporte(usuario));
            }
			else
			{
				DisplayAlertAsync("Alerta", "Usuario/Contraseña Incorrectos", "ok");
			}




        }
		catch (Exception ex)
		{

			DisplayAlertAsync("Error", ex.Message, "Cerrar");
		}

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {

		Navigation.PushAsync(new vRegistro());

    }
}