using Unice.ViewHelpers.TestRunner;
using UnityEngine;
using UnityEngine.UI;

namespace Unice.Samples.ButtonView
{
    /// <summary>
    /// Sample Button MB (MonoBehaviour).
    /// </summary>
    public class SampleButtonMB : MonoBehaviour, ITestable
    {
        /// <summary>
        /// Button component.
        /// Needed for CO (controller) to know when to process.
        /// </summary>
        public Button Button;
        
        /// <summary>
        /// The CO (controller) needed to operate this MB.
        /// </summary>
        public SampleButtonCO Controller { set; get; }
        
        /************************************* Test Variables *************************************/
        #if UNITY_EDITOR

        /// <summary>
        /// Convenience test running flag.
        /// </summary>
        public bool IsTestRunning { get; set; }
        
        [Tooltip("the receiver that will handle main menu outputs in test")]
        public DummySampleButtonCoordinator TestCoordinator;

        public void RunTest()
        {
            Controller.Outputs = Controller.Outputs ?? TestCoordinator;
        }
        
        #endif
        /******************************************************************************************/

        void Awake()
        {
            Controller = new SampleButtonCO(this);
        }
    }
}