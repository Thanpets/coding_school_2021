using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session25Exercise.Services
{
    public interface ICustomerStorage
    {
        public void AddItem(Customer customerItem);
        public void RemoveItem(int id);
        public List<Customer> GetAllCustomerItems();
        public Customer GetById(int id);
    }
    public class MemoryCustomerStorage : ICustomerStorage
    {
        private List<Customer> CustomerInnerList { get; set; }

        public MemoryCustomerStorage()
        {
            CustomerInnerList = new List<Customer>();
        }
        public void AddItem(Customer customerItem)
        {
            if (customerItem.Id == 0)
            {
                customerItem.Id = CustomerInnerList.Count + 1;
                CustomerInnerList.Add(customerItem);
                return;
            }

            var selectedItem = GetById(customerItem.Id);            
            selectedItem.Name = customerItem.Name;
            selectedItem.Surname = customerItem.Surname;
            selectedItem.AFM = customerItem.AFM;
            selectedItem.Active = customerItem.Active;
            
        }

        public List<Customer> GetAllCustomerItems()
        {
            return CustomerInnerList;
        }

        public Customer GetById(int id)
        {
            return CustomerInnerList.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveItem(int id)
        {
            var selectedItem = GetById(id);
            if (selectedItem==null)
            {
                throw new Exception($"Item with id = {id} was not found.");
            }
            CustomerInnerList.Remove(selectedItem);
        }
    }
}
