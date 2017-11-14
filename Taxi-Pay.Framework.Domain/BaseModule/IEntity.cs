namespace Rayak.Framework.Domain.BaseModule
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

}