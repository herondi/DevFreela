﻿using DevFreela.API.Entities;

namespace DevFreela.API.Models
{
    public class CreateProjectInputModel
    {

        public string Title { get; set; } 
        public string Description { get; set; }
        public string IdClient { get; set; }

        public string IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }

        internal Project ToEntity()
        {
            throw new NotImplementedException();
        }
    }
}
