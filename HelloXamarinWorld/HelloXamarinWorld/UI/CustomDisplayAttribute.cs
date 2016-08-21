using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarinWorld.UI
{
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class CustomDisplayAttribute : Attribute
    {

        public string Text { get; set; }

        public CustomDisplayAttribute(string text)
        {
            this.Text = text;
        }
    }
}
