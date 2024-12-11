namespace HW_ASP_10._2
{
    public interface IWeatherService
    {
        Task<WeatherInfo> GetWeatherAsync(string city);
    }

    public class WeatherInfo
    {
        public string City { get; set; } = string.Empty;
        public string Condition { get; set; } = "Солнечно";
        public double Temperature { get; set; }
    }

    public class FakeWeatherService : IWeatherService
    {
        private static Random rnd = new Random();
        private static string[] conditions = new[] { "Солнечно", "Дождь", "Облачно", "Пасмурно", "Снег" };

        public Task<WeatherInfo> GetWeatherAsync(string city)
        {
            // Случайно выбираем состояние из массива conditions
            var randomCondition = conditions[rnd.Next(conditions.Length)];

            // Возвращаем фейковые данные
            var info = new WeatherInfo
            {
                City = city,
                Condition = randomCondition,
                Temperature = 15 + rnd.NextDouble() * 10 // от 15 до 25 градусов
            };
            return Task.FromResult(info);
        }
    }
}
