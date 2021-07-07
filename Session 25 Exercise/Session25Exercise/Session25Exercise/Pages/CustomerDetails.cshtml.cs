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
    public class CustomerDetailsModel : PageModel
    {
        [BindProperty]

        public Customer SelectedListItem { get; set; }
        private ICustomerStorage _storage { get; set; }
        public CustomerDetailsModel(ICustomerStorage storage)
        {
            _storage = storage;
        }

        public void OnGet(int id)
        {
            if (id == 0)
            {
                SelectedListItem = new Customer();
                return;
            }

            SelectedListItem = _storage.GetById(id);
        }
        public IActionResult OnPost()
        {
            //if (SelectedListItem.AFM.Length != 9 || SelectedListItem.AFM == null)
            //{
            //    //messagebox($"AFM field can only take 9 characters.");              
            //}
            if (ModelState.IsValid)
            {
                _storage.AddItem(SelectedListItem);
                return RedirectToPage("List");
            }

            return Page();
            
        }
        public IActionResult OnPostCancel()
        {
            return RedirectToPage("List");
        }
        public IActionResult OnPostDelete()
        {
            _storage.RemoveItem(SelectedListItem.Id);
            return RedirectToPage("List");
        }
    }
}
