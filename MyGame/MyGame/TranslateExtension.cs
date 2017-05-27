using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyGame
{
    [ContentProperty("Key")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Key { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Properties.Resources.ResourceManager.GetString(Key) ?? "(no text.)";
        }
    }
}
