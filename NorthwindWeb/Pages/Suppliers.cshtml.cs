using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace NorthwindWeb.Pages 
{
    public class SuppliersModel: PageModel
    {
        public IEnumerable<string> Suppliers {get;set;}
        private Northwind db;
        [BindProperty]
        public Supplier Supplier {get;set;}

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
        }
        public SuppliersModel(Northwind injectedContext)
        {
            db=injectedContext;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Suppliers";
            //Suppliers = new [] {"Alpha Co", "Beta Limited", "Gamma Corp"};
            Suppliers = db.Suppliers.Select(s => s.CompanyName);
         }
    }
}