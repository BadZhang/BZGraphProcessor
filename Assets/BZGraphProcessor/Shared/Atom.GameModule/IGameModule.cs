namespace BZGraphProcessor.Shared
{
    public interface IGameModule
    {
        void Init();

        void UnInit();

        void FixedUpdate();

        void Update();

        void LateUpdate();
    }
}