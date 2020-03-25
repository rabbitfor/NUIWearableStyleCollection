using Tizen.NUI.Components;
using Tizen.NUI.BaseComponents;
using Tizen;

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

            var button = new Button(new RoundButtonStyle(), new Button.PressAnimationUIAdapter())
            {
                Text = "Hello World!",
                IconURL = "/home/jy/2019/dali/TizenFX/src/Tizen.NUI.Components/res/nui_component_default_switch_thumb_n.png",
                ParentOrigin = ParentOrigin.Center,
                PivotPoint = PivotPoint.Center,
                PositionUsesPivotPoint = true
            };
            window.Add(button);
        }

    }
}