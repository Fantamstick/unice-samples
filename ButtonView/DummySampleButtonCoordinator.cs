using UnityEngine;

namespace Unice.Samples.ButtonView
{
    public class DummySampleButtonCoordinator : MonoBehaviour, ISampleButtonCoordination
    {
        void ISampleButtonCoordination.OnStartTest()
        {
            Debug.Log("DummyCoordinator: Sample button was clicked!");
        }
    }
}
