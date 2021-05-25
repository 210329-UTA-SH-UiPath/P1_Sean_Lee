using MVCFrontend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrontend
{
    public class Client
    {
        string url = "https://localhost:44311/api/";

        public IEnumerable<Store> GetAllStores()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Store");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask =  result.Content.ReadAsAsync<Store[]>();
                readTask.Wait();

                var stores = readTask.Result;
                return stores;
            }
            else
            {
                return null;
            }    
        }
        public IEnumerable<Order> GetAllOrders()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "CustOrder");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Order[]>();
                readTask.Wait();

                var orders = readTask.Result;
                return orders;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<PizzaOrder> GetAllPizzaOrders()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "PizzaOrder");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<PizzaOrder[]>();
                readTask.Wait();

                var pizzaorders = readTask.Result;
                return pizzaorders;
            }
            else
            {
                return null;
            }
        }

        
        public IEnumerable<Customer> GetAllCustomers()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Cust");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Customer[]>();
                readTask.Wait();

                var customers = readTask.Result;
                return customers;
            }
            else
            {
                return null;
            }
        }
        public async void AddCustomer(Customer customer)
        {
            var json = JsonConvert.SerializeObject(customer);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync(url + "Cust", data);
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        public async void AddPizzaOrder(PizzaOrder order)
        {
            var json = JsonConvert.SerializeObject(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync(url + "PizzaOrder", data);
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        public async void AddOrder(Order order)
        {
            var json = JsonConvert.SerializeObject(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync(url + "CustOrder", data);
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
        public Customer GetCustomerById(int id)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Cust/" + id);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Customer>();
                readTask.Wait();

                var customers = readTask.Result;
                return customers;
            }
            else
                return null;
        }

        public PizzaOrder GetPizzaOrderByCustomerOrder(int oId, int cId)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "PizzaOrder/" + oId + "/" + cId);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<PizzaOrder>();
                readTask.Wait();

                var pizzaorders = readTask.Result;
                return pizzaorders;
            }
            else
                return null;
        }
        
        public IEnumerable<Pizza> GetAllPizzas()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Pizza");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Pizza[]>();
                readTask.Wait();

                var pizzas = readTask.Result;
                return pizzas;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<Size> GetAllSizes()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Size");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Size[]>();
                readTask.Wait();

                var sizes = readTask.Result;
                return sizes;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<Crust> GetAllCrusts()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Crust");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Crust[]>();
                readTask.Wait();

                var crusts = readTask.Result;
                return crusts;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<Topping> GetAllToppings()
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url + "Topping");
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result; //holds output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Topping[]>();
                readTask.Wait();

                var toppings = readTask.Result;
                return toppings;
            }
            else
            {
                return null;
            }
        }
        //public Customer GetCustomerByName(string name)
        //{
        //    using var client = new HttpClient();
        //    client.BaseAddress = new Uri(url + "Cust/" + name);
        //    var response = client.GetAsync("");
        //    response.Wait();

        //    var result = response.Result;// this holds the output

        //    if (result.IsSuccessStatusCode)
        //    {
        //        var readTask = result.Content.ReadAsAsync<Customer>();
        //        readTask.Wait();

        //        var customers = readTask.Result;
        //        return customers;
        //    }
        //    else
        //        return null;
        //}
    }
}
