using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace DisplaySizeSample
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.SizeChanged += MainPage_SizeChanged;

            DisplayProperties.LogicalDpiChanged += DisplayProperties_LogicalDpiChanged;
        }

        void DisplayProperties_LogicalDpiChanged(object sender)
        {
            this.dpiText.Text = DisplayProperties.LogicalDpi.ToString();
        }

        void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.widthText.Text = e.NewSize.Width.ToString();
            this.heightText.Text = e.NewSize.Height.ToString();
            this.dpiText.Text = DisplayProperties.LogicalDpi.ToString();
        }

        /// <summary>
        /// このページがフレームに表示されるときに呼び出されます。
        /// </summary>
        /// <param name="e">このページにどのように到達したかを説明するイベント データ。Parameter 
        /// プロパティは、通常、ページを構成するために使用します。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
