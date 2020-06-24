using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polarizelab.Blazor.Components.Material
{
    public abstract class ButtonBase: ComponentBase
    {
        [Parameter] public string Text { get; set; }
        [Parameter] public string Classes { get; set; }
        [Parameter] public Dictionary<string, object> Attributes { get; set; }
        [Parameter] public EventCallback OnClick { get; set; }
        [Parameter] public bool IsEnabled { get; set; } = true;
        [Parameter] public ButtonStyle Style { get; set; }
        [Parameter] public ButtonSize Size { get; set; }
        [Parameter] public bool Stretch { get; set; }
        [Parameter] public ButtonType Type { get; set; } = ButtonType.Button;
        protected string GetButtonSizeClass()
        => Size switch
        {
            ButtonSize.Large => "btn-lg",
            ButtonSize.Small => "btn-sm",
            _ => string.Empty
        };
        protected string GetButtonType()
           => Type switch
           {
               ButtonType.Submit => "submit",
               ButtonType.Reset => "reset",
               _ => "button"
           };
    }
}
