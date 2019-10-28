using System.ComponentModel.DataAnnotations;

namespace FishAquariumWebApp.Models
{
 
    public enum UserTypes
    {
        [Display(Name = "Admin")]
        Admin,
        [Display(Name = "Worker")]
        Worker,
        [Display(Name = "Visitor")]
        Visitor
    }
}
