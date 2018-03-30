 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        // automatically increased when we add row to the table
        // auto increment
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        //Allows HTML code to database
        [AllowHtml]
        public string HTML { get; set; }


        [DefaultValue(0)]
        public int WaitDays { get; set; }

        public string HTMLShort
        {
            get
            {
                return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50);
            }
        }

        public int ProductId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }
        public int IsFree { get; set; }

        [DisplayName("Item Types")]
        //Always use ICollection when LazyCoding
        public ICollection<ItemType> ItemTypes { get; set; }

        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }

        [DisplayName("Parts")]
        public ICollection<Part> Parts { get; set; }
    }
}