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
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        [Display(Name = "Gross Salary")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal GrossSalary { get; set; }

        [Display(Name = "Net Salary")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal NetSalary { get; set; }

        [Display(Name = "Additional Income")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal AdditionalIncome { get; set; }

        [Display(Name = "Total Monthly Income")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal TotalIncome { get; set; }

        [Display(Name = "Housing Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal HousingExpense { get; set; }

        [Display(Name = "Utilities Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal UtilitiesExpense { get; set; }

        [Display(Name = "Food Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal FoodExpense { get; set; }

        [Display(Name = "Debt Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal DebtExpense { get; set; }

        [Display(Name = "Additional Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal AdditionalExpense { get; set; }

        [Display(Name = "Total Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal TotalExpenses { get; set; }
    }
}
