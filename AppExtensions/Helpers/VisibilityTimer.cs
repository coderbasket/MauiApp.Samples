using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace MauiAppExtensions
{
    public class VisibilityTimer
    {
        View Parent { get; }
        View Target { get; }
        public VisibilityTimer(View parent, View target)
        {
            Parent = parent;
            Target = target;
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += GestureRecognizer_Tapped;
            //parent.PointerMoved += UIRenderControl_PointerMoved;
            //parent.PointerEntered += OnArrowPointerEntered;
            //parent.PointerExited += OnArrowPointerExited;
            CreateFadeTimer();
        }

        private void GestureRecognizer_Tapped(object sender, EventArgs e)
        {
            UIRenderControl_PointerMoved(sender,e);
        }

        public bool IsOpen
        {
            get { return Parent.IsVisible; }
        }
        private async void ShowAction()
        {
            if (Target.IsVisible)
                return;
            this.Target.IsVisible = true;
            await this.Target.FadeTo(1);

        }

        private async void HideAction()
        {
            if (Target.IsVisible == false)
                return;
            await this.Target.FadeTo(0);
            this.Target.IsVisible = false;

        }
        private bool _isArrowVisible = false;
        private bool _isArrowOver = false;

        private System.Timers.Timer _fadeTimer = null;

        #region Create/Dispose FadeTimer
        private void CreateFadeTimer()
        {
            _fadeTimer = new System.Timers.Timer(1500);         
            _fadeTimer.Elapsed +=  (sender, e) => OnFadeTimerTick();

        }
       
        private void DisposeFadeTimer()
        {
            var fadeTimer = _fadeTimer;
            _fadeTimer = null;
            if (fadeTimer != null)
            {
                fadeTimer.Stop();
            }
        }
        #endregion

        #region ArrowPointerEntered/ArrowPointerExited
        private void OnArrowPointerEntered(object sender, EventArgs e)
        {
            if (this.IsOpen == false)
                return;
            _isArrowOver = true;
        }

        private void OnArrowPointerExited(object sender, EventArgs e)
        {
            if (this.IsOpen == false)
                return;
            _isArrowOver = false;
        }
        #endregion



        private void UIRenderControl_PointerMoved(object sender, EventArgs e)
        {
            if (this.IsOpen == false)
                return;
            if (!_isArrowVisible)
            {
                ShowAction();
                _isArrowVisible = true;
            }
            this._fadeTimer.Start();
        }

        private void OnFadeTimerTick()
        {
            if (_isArrowVisible)
            {
                _isArrowVisible = false;
                HideAction();
            }
        }
    }
}
