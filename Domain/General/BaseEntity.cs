using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.General
{
    public class BaseEntity
    {
        [Column("CreatedBy")]
        public long? CreatedBy { get; set; }

        [Column("CreatedOn", TypeName = "datetime")]

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedOn { get; set; }

        [Column("ModifiedBy")]
        public long? ModifiedBy { get; set; }

        [Column("ModifiedOn", TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }

        [Column("IsDeleted")]
        [DefaultValue(false)]
        public bool? IsDeleted { get; set; } = false;

        public void setCreatedBy(long user_Id)
        {
            this.CreatedBy = user_Id;
            this.CreatedOn = DateTime.Now;

        }
        public void setModifiedBy(long user_Id)
        {
            this.ModifiedBy = user_Id;
            this.ModifiedOn = DateTime.Now;

        }
        public void setIsDeleted(long user_Id)
        {
            this.IsDeleted = true;
            this.ModifiedBy = user_Id;
            ModifiedOn = DateTime.Now;
        }
    }
}
