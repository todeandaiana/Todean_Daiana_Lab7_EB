﻿namespace Todean_Daiana_Lab2.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
     //   public IEnumerable<Customer> Customers { get; set; }
    }
}
