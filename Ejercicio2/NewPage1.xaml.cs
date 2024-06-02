namespace Ejercicio2;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        double resultado, dato1, dato2;
        dato1 = Convert.ToDouble(entry1.Text);
        dato2 = Convert.ToDouble(entry2.Text);


        resultado = Math.Pow((dato1 + dato2), 2) / 2;
        entry3.Text = resultado.ToString();



    }
}