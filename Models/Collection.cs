using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace elements.Models
{
    public enum CollectionType
    {
        PureForm,
        PureFormMakable,
        Compound,
    }

    public class Collection
    {
        [Key]
        public int CollectionID { get; set; }

        public int ElementNumber { get; set; }
        public CollectionType Type { get; set; }
        public string Description { get; set; }
        public string Storage { get; set; }
    }
}