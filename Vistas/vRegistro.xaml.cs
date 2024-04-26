namespace ponaExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double costo = 1500;
        double interes = 60;
        double monto = Convert.ToDouble(txtMontoIni.Text);
        double cuota = 0.00;


        if (monto < costo)
        {
            cuota = ((costo - monto) / 4) + interes;

            txtPago = 3;

            /*string mensaje = "Cuota calculada es: " + cuota.ToString();*/
            DisplayAlert("Alerta", "Cuota calculada es: " +cuota.ToString(), "Cerrar");
        }
        else
        {
            DisplayAlert("Alerta", "El monto es mayor al costo", "Cerrar");
        }

            
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vResumen());
    }
}