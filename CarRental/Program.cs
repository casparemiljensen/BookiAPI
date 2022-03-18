using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BookiAPI;

namespace BookiAPI {
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetEmployeeAsync("https://localhost:44336/api/cars/").GetAwaiter().GetResult();

            Console.WriteLine(result);
            
            var employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
            
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadLine();
        }

        static async Task<string> GetEmployeeAsync(string path)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}
