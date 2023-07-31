
using MauiAppSQlite.DataAccess;

namespace MauiAppSQlite;

public partial class MainPage : ContentPage
{
	int count = 0;

	private readonly DemoDbContext _dbcontext;
	public MainPage(DemoDbContext dbcontext)
	{
        _dbcontext = dbcontext;
        InitializeComponent();

		_dbcontext.Empleados.Add(new Modelos.Empleado
		{
			IdEmpleado = Guid.NewGuid().ToString("N"),
			Nombre = "Jose",
			Correo = "Jose@gmail.com"
		});
		_dbcontext.Empleados.Add(new Modelos.Empleado
		{
			IdEmpleado = Guid.NewGuid().ToString("N"),
			Nombre = "Maria",
			Correo = "Maria@gmail.com"
		});
		_dbcontext.Empleados.Add(new Modelos.Empleado
		{
			IdEmpleado = Guid.NewGuid().ToString("N"),
			Nombre = "Carmen",
			Correo = "Carmen@gmail.com"
		});

		_dbcontext.SaveChanges();

		lvEmpleado.ItemsSource = _dbcontext.Empleados.ToList();


    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

