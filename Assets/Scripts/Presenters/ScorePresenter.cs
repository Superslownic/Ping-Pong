using TMPro;
using UnityEngine;

namespace Idler.Presenters
{
    public class ScorePresenter : MonoBehaviour, IPresenter<uint>
    {
        [SerializeField] private TextMeshPro _textField;

        public void Present(uint data)
        {
            _textField.text = data.ToString();
        }
    }
}
