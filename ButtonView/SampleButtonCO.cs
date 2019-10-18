namespace Unice.Samples.ButtonView
{
    /// <summary>
    /// Sample Button CO (Controller).
    /// </summary>
    public class SampleButtonCO
    {
        /// <summary>
        /// Output interface to communicate with a coordinator.
        /// </summary>
        public ISampleButtonCoordination Outputs { set; get; }

        public SampleButtonCO(SampleButtonMB sampleButton)
        {
            // Listen to button click event.
            sampleButton.Button.onClick.AddListener(OnClickButton);
        }

        void OnClickButton()
        {
            Outputs.OnStartTest();
        }
    }
}