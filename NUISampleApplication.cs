using Tizen.NUI.Components;

namespace Tizen.NUI.Samples
{
    public class NUISampleApplication : NUIApplication
    {
        public NUISampleApplication(int width, int hight) : base(new Size2D(width, hight), new Position2D(0, 0))
        {
        }

        protected override void OnCreate()
        {
            base.OnCreate();
            
            Window window = NUIApplication.GetDefaultWindow();
            window.BackgroundColor = Color.Black;

            var button = new Button(BottomButtonStyle.GetStyle(), new Button.PressAnimationUIAdapter());
            button.ParentOrigin = ParentOrigin.BottomCenter;
            button.PivotPoint = PivotPoint.BottomCenter;
            button.PositionUsesPivotPoint = true;
            button.Position = new Position(0, -20);
            // button.IsEnabled = false;
            window.Add(button);
        }
    }
}
