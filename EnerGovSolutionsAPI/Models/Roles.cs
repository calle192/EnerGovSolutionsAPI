﻿using System.ComponentModel.DataAnnotations;
namespace EnerGovSolutionsAPI.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
