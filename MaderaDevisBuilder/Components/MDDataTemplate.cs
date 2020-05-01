using System.Collections.Generic;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.Components
{
    public class MDDataTemplate : DataTemplateSelector
    {
        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate UnevenTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((List<Client>)((ListView)container).ItemsSource).IndexOf(item as Client) % 2 == 0 ? EvenTemplate : UnevenTemplate;
        }
    }
}