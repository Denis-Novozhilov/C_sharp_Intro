namespace TodoList.API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }
    public int Temperature_TEST { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public string? TestNameProperty2 { get; set; }
    public string? TestNameProperty { get; set; }
}
