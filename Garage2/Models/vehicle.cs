using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class vehicle
    {
        public int Id { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 6)]
        [RegularExpression(@"^[a-zA-Z]{3}\s\d{3}$",
            ErrorMessage = "Registreringsnummer ska följa ABC 123 med mellanslag!")]
        [Display(Name = "Registreringsnummer")]
        public string RegNumber { get; set; }
        [Display(Name = "Färg")]
        public string Colour { get; set; }
        [Display(Name = "Märke")]
        public Brand Brand { get; set; }
        [Display(Name = "Modell")]
        public string Model { get; set; }
        [Range(3,8 ,
            ErrorMessage = "Fordon med hjul färre än 3 eller mer än 8 är icke parkeringsbara!")]
        [Display(Name = "Antal hjul")]
        public int Wheels { get; set; }
        [Display(Name = "Parkerades vid")]
        public DateTime TimeStamp { get; set; }
    }
    public enum Brand
    {

        Volvo,
        Saab,
        Audi,
        BMW,
        Mazda,
        Nissan,
        Kia
    }
}