using System;

namespace CiclosDeVidaMetodos;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);
		window.Created += Window_Created;
        window.Activated += Window_Activated;
		window.Deactivated += Window_Deactivated;
		window.Stopped += Window_Stopped;
		window.Resumed += Window_Resumed;
		window.Destroying += Window_Destroying;
		return window;
    }

    private void Window_Destroying(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Se destruyo-----------------");
    }
    private void Window_Resumed(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Se Reaunodo-----------------");
    }
    private void Window_Stopped(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Se puso stop-----------------");
    }
    private void Window_Deactivated(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Se desactivo-----------------");
    }
    private void Window_Activated(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Se Activo-----------------");

    }
    private void Window_Created(object sender, EventArgs e)
	{
        System.Diagnostics.Debug.WriteLine("Se creo-----------------");
    }

}
