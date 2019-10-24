using Unice.Samples.ButtonView;
using Unice.Util;
using Unice.ViewHelpers.TestRunner;
using UniRx.Async;
using UnityEngine;

namespace Unice.Samples.Coordinator
{
    /// <summary>
    /// Sample Coordinator.
    /// </summary>
    public class SampleCoordinator : MonoBehaviour, ISampleButtonCoordination, ITestable
    {
        [SerializeField]
        SampleButtonMB sampleButton = null;

        /************************************* Test Variables *************************************/
        #if UNITY_EDITOR

        bool ITestable.IsTestRunning { get; set; }
        
        /// <summary>
        /// Run test. The TestRunner executes this method if it exists in scene.
        /// Otherwise, we wait for the Game coordinator to call RunAsync() for us.
        /// </summary>
        void ITestable.RunTest()
        {
            RunAsync().Forget();
        }
        
        #endif
        /******************************************************************************************/

        bool isClicked = false;

        /// <summary>
        /// The run method.
        /// When it returns, the coordinator is considered "done" and a game coordinator takes
        /// control of the next process.
        /// </summary>
        public async UniTask RunAsync()
        {
            // Assign coordinator as the output for the CO.
            sampleButton.Controller.Outputs = this;

            // Wait for the sample button click.
            while (!isClicked) await Delay.NextFrame();
            
            // Proceed once sample button clicked.
            Debug.Log("Coordinator: Sample Button clicked.");
        }

        void ISampleButtonCoordination.OnStartTest()
        {
            isClicked = true;
        }
    }
}
