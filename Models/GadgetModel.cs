using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BondGadgetCollection.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName ("Appears in this movie")]
        public string Appears { get; set; }
        [Required]
        public string WithThisActor { get; set; }

        public GadgetModel() 
        {
            Id = -1;
            Name = "Nothing";
            Description = "Nothing yet";
            Appears = "Nowhere";
            WithThisActor = "With no one";
        }

        public GadgetModel(int id, string name, string description, string appears, string withThisActor)
        {
            Id = id;
            Name = name;
            Description = description;
            Appears = appears;
            WithThisActor = withThisActor;
        }
    }
}