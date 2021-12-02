using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JamesBondGadetsEntity.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName("The movie it appears")]
        public string AppearsIn { get; set; }  // the particular movie in appears in
        [Required]
        public string WithThisActor { get; set; }    // the particular James bond character since they where different


        //Constructor to set some default parameter'
        public GadgetModel()
        {
            Id = 0;
            Name = Name;
            Description = Description;
            AppearsIn = AppearsIn;
            WithThisActor = WithThisActor;

        }
        // constructor with all the parameters
        public GadgetModel(int id, string name, string description, string appearsIn, string withThisActor)
        {
            Id = id;
            Name = name;
            Description = description;
            AppearsIn = appearsIn;
            WithThisActor = withThisActor;
        }
    }
}