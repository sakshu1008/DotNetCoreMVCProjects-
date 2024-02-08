﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Cityinfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfPointsOdInterest
        {
            get
            {
                return PointOfInterests.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointOfInterests { get; set; } = new List<PointOfInterestDto>();
    }
}
