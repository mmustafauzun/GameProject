using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Remove(Game game);
        void Update(Game game);
    }
}
