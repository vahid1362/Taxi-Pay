using System.ComponentModel;
using Taxi_Pay.Framework.Domain.BaseModule;

namespace Rayak.Framework.Domain.BaseModule
{
    public abstract class KeyValueEntity : Entity<int>
    {
        protected KeyValueEntity()
        {
        }

        protected KeyValueEntity(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [DisplayName("نام")]
        public string Name { get; set; }

        [DisplayName("مقدار")]
        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
