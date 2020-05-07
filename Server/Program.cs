using ElectronCgi.DotNet;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new ConnectionBuilder().Build();

            connection.On<string, string>("hello", (data) =>
            {
                return $"Hello from Console App, your name: {data}";
            });

            connection.Listen();
        }
    }
}
