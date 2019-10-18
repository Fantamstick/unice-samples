using UnityEngine;

namespace Unice.Samples.ButtonView
{
    public class DummySampleButtonCoordinator : MonoBehaviour, ISampleButtonCoordination
    {
        public void OnStartTest()
        {
            Debug.Log("DummyCoordinator: Sample button was clicked!");
        }
    }
}
