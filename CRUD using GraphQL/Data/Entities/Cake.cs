﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_using_GraphQL.Data.Entities
{
    public class Cake
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
