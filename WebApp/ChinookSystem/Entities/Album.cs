using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Entities
{

    //annotate
    [Table("Albums")]
    internal class Album

    {
        
        //private data members
    
        private string _ReleaseLabel;


        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Album title is required")]
        [StringLength(160, ErrorMessage = "Name is limited to 160 characters.")]
        public string Title { get; set; }
       

       //[ForeignKey] DO NOT USE!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Entity framework has enough sense to match up identity fields if 
       //they match up with SQL DB tables - if the names do not match FK is required
        public int ArtistId { get; set; }

        public int ReleaseYear { get; set; }

        [StringLength(50,ErrorMessage = "Release label is limited to 50 characters.")]
        public string ReleaseLabel
        {
            get { return _ReleaseLabel; }
            set { _ReleaseLabel = string.IsNullOrEmpty(value) ? null : value; }
        }

    
        //navigational properties
        //use to overlay a model of the database ERD relationships
        //you need to know the ERD relationship between Table A and Table B
        //we have a relationship between Artist and Album 
        //that relationship is parent (Arist) to child (Album)
        //an Album has one parent
        //an Artist has many children
        //an Artist has zero, one or more children
        
        //the relationship in Album is child to parent or (1 : 1)
        public virtual Artist Artist { get; set; }

    }
}
