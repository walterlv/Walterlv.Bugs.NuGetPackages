using System.Windows;

// ReSharper disable CheckNamespace

namespace Walterlv.Themes
{
    public partial class UniversalWindowStyle
    {
        public static readonly DependencyProperty TitleBarProperty = DependencyProperty.RegisterAttached(
            "TitleBar", typeof(string), typeof(UniversalWindowStyle),
            new PropertyMetadata(""));

        public static string GetTitleBar(DependencyObject element)
            => (string)element.GetValue(TitleBarProperty);

        public static void SetTitleBar(DependencyObject element, string value)
            => element.SetValue(TitleBarProperty, value);
    }
}
