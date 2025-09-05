using MCC02.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCC02.Controllers
{
    public class ProductsControllers : Controller
    {
        // model binder
        // route data=> /baseurl/c/a/{value}
        // query string=> /baseurl/c/a?id=value
        // html form
        // req body=>xml\\json
        // headers=>[from headers]
        public string Get(int id)
        {
            return $"product id ={id}";
        }

        public string Create(int id,string name, product product)
        {
            return $"product id ={id} name={name}\n {product.Id}{product.Name}";
        }
    }
}
