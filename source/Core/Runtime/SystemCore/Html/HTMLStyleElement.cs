//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLStyleElement : HTMLElement
    {
        internal HTMLStyleElement() { }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public string media { get; set; }

        [ScriptField]
        public string type { get; set; }
    }
}