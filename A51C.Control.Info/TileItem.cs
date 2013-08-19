﻿using A51C.Control.Fase;

namespace A51C.Control.Info
{
    public class TileItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Copyright { get; set; }
        public string Version { get; set; }
        public string Guid { get; set; }
        public string File { get; set; }
        public System.Drawing.Color BColor { get; set; }
        public System.Drawing.Image PluginBg { get; set; }
        public System.Drawing.Image PluginLogo { get; set; }
        public System.Drawing.FontFamily LogoFontFamily { get; set; }
        public System.IO.Stream LogoFontStream { get; set; }
        public string LogoFontDesc { get; set; }
        public System.Drawing.Color FColor { get; set; }
        public System.Drawing.Color FBolor { get; set; }
        public dynamic Dynamic { get; set; }
        public bool IsHidden { get; set; }
        public LPanel PluginPanel { get; set; }
    }
}