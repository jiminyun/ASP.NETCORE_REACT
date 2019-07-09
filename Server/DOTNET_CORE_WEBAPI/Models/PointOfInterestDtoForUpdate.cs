using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_CORE_WEBAPI.Models
{
    public class PointOfInterestDtoForUpdate
    {
        [Required(ErrorMessage = "You should proive a name value.")]
        [MaxLength(90)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
