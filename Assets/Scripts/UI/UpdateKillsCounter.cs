using Enemies;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UpdateKillsCounter : MonoBehaviour
    {
        private int _counter = 0;
        public Text textField;

        private void Start()
        {
            SetCounter();
            AddListenersForDeadEnemies();
        }

        private void AddListenersForDeadEnemies()
        {
            var killableTargets = FindObjectsOfType<KillableTarget>();
            foreach (var killableTarget in killableTargets)
            {
                killableTarget.targetDied.AddListener(UpdateCounter);
            }
        }

        public void UpdateCounter()
        {
            _counter++;
            SetCounter();
        }

        private void SetCounter()
        {
            textField.text = $"Kills: {_counter}";
        }
    }
}
