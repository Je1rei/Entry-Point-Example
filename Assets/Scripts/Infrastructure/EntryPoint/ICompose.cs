using Zenject;

namespace Infrastructure.EntryPoint
{
    public interface ICompose
    {
        public void Compose(DiContainer container);
    }
}