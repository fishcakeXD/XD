namespace Entity練習.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Total { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        internal static ContactsTable ParseRow(string row)
        {
            var data = row.Split(',');
            return new ContactsTable()
            {
                Id = data[0],
                Name = data[1],
                Total = (data[2]),
                Price = (data[3]),
                Type = data[4]
            };
        }
    }
}
