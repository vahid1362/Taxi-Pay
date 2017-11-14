using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rayak.Framework.Domain.BaseModule
{
    [DisplayName("موجودیت نوع")]
    public abstract class TypeEntity
    {
        /// <summary>کد</summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id { get; set; }

        /// <summary>نام</summary>
        [MaxLength(200)]
        public string Name { get; set; }

        /// <summary>اولویت</summary>
        [DefaultValue(0)]
        public short Priority { get; set; }
    }
}