using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface ISaleService
    {
        void Add(Sale sale);
        void Remove(Sale sale);
        void Update(Sale sale);
    }
}