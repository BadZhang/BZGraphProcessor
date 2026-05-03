
#if UNITY_EDITOR
using System.Collections;

namespace BZGraphProcessor.Shared.UnityEditors.EditorCoroutine
{
    public partial class EditorCoroutineService : CoroutineService<EditorCoroutine>
    {
        public override EditorCoroutine StartCoroutine(IEnumerator enumerator)
        {
            EditorCoroutine coroutine = new EditorCoroutine(enumerator);
            coroutineQueue.Enqueue(coroutine);
            return coroutine;
        }

        public override void StopCoroutine(EditorCoroutine coroutine)
        {
            coroutine.Stop();
        }
    }
}
#endif