using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace PracticeApp.Models
{
    public class Budget
    {
        [Key]
        public string Id { get; set; }
        //public IdentityUser User { get; set; }
        public double NetSalary { get; set; }
        public double AdditionalIncome { get; set; }
        public double TotalIncome { get; set; }
        public double HousingExpense { get; set; }
        public double UtilitiesExpense { get; set; }
        public double FoodExpense { get; set; }
        public double DebtExpense { get; set; }
        public double AdditionalExpense { get; set; }
        public double TotalExpenses { get; set; }
    }
}
