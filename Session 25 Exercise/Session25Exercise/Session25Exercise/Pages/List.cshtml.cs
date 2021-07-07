using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using Session25Exercise.Services;

namespace Session25Exercise.Pages
{
    public class ListModel : PageModel
    {
        public List<Customer> CustomerItems = new List<Customer>();

        public ICustomerStorage _storage { get; set; }
        public ListModel(ICustomerStorage storage)
        {
            _storage = storage;
        }

        public void OnGet()
        {
            CustomerItems = _storage.GetAllCustomerItems();
        }
    }
}
