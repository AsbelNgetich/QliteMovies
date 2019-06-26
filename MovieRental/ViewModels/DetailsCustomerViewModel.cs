using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;

namespace MovieRental.ViewModels
{
    public class DetailsCustomerViewModel : Controller
    {
        public List<Customer> Customers { get; set; }
    }
}