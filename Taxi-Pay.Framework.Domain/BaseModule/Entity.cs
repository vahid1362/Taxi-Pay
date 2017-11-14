using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Rayak.Framework.Domain.BaseModule;

namespace Taxi_Pay.Framework.Domain.BaseModule
{
    /// <summary>موجودیت</summary>
    [Serializable]
    public abstract class Entity<TKey> : IEntity<TKey>, IEquatable<TKey>, IAuditable
    {
        /// <summary>شناسه</summary>
        [Key]
        public virtual TKey Id { get; set; }

        /// <summary>تاریخ/زمان ایجاد</summary>
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        ///// <summary>ایجاد کننده</summary>
        //public int CreatedBy { get; set; }

        /// <summary>تاریخ/زمان ایجاد</summary>
        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedOn { get; set; }

        public bool IsTransient()
        {
            return this.Id.Equals(default(TKey));
        }

        public void ChangeIdentity(TKey id)
        {
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Entity<TKey>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            var item = (Entity<TKey>) obj;

            if (item.IsTransient() || IsTransient())
                return false;

            return item.Id.Equals(this.Id);
        }

        public virtual bool Equals(TKey other)
        {
            return other != null && other.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                return this.Id.GetHashCode() ^ 31;
            }
            return 1;
        }

        public static bool operator ==(Entity<TKey> left, Entity<TKey> right)
        {
            return Equals(left, null) ? (Equals(right, null)) : left.Equals(right);
        }

        public static bool operator !=(Entity<TKey> left, Entity<TKey> right)
        {
            return !(left == right);
        }
    }

    public abstract class Entity : Entity<Guid>
    {
        public void GenerateNewIdentity()
        {
            if (IsTransient())
            {
                Id = IdentityGenerator.NewSequentialId();
            }
        }
    }
}
