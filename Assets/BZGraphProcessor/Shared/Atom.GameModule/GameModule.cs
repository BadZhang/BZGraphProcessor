namespace BZGraphProcessor.Shared
{
    public abstract class GameModule : IGameModule
    {
        public void Init()
        {
            this.OnInit();
        }

        public void UnInit()
        {
            this.OnUnInit();
        }

        public void FixedUpdate()
        {
            this.OnFixedUpdate();
        }

        public void Update()
        {
            this.OnUpdate();
        }

        public void LateUpdate()
        {
            this.OnLateUpdate();
        }

        protected virtual void OnInit()
        {
        }

        protected virtual void OnUnInit()
        {
        }

        protected virtual void OnFixedUpdate()
        {
        }

        protected virtual void OnUpdate()
        {
        }

        protected virtual void OnLateUpdate()
        {
        }
    }
}