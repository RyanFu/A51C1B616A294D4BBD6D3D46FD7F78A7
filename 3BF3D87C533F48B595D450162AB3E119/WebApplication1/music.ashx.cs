﻿using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// music 的摘要说明
    /// </summary>
    public class music : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            const string sss = "﻿<!DOCTYPE html><html><head><!--[if lt IE 9]><script src=\"http://html5shiv.googlecode.com/svn/trunk/html5.js\"></script><![endif]--><!--[if IE 6]><link href=\"http://jplayer.org/css/ie6.css\" rel=\"stylesheet\" type=\"text/css\" /><![endif]--><link rel=\"stylesheet\" href=\"http://jplayer.org/latest/skin/circle.skin/circle.player.css\"><script type=\"text/javascript\" src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/jquery.jplayer.min.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/jquery.jplayer.inspector.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/jquery.transform2d.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/jquery.grab.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/mod.csstransforms.min.js\"></script><script type=\"text/javascript\" src=\"http://jplayer.org/latest/js/circle.player.js\"></script><style>body,html {margin: 0px;padding: 0px;background-color: #F0F0F0;}#cp_container_1 {position: absolute;top: 50%;left: 50%;margin-left: -100px;margin-top: -100px;}</style><script type=\"text/javascript\">$(document).ready(function () {var myCirclePlayer = new CirclePlayer(\"#jquery_jplayer_1\",{mp3: \"AAACCC\",},{cssSelectorAncestor: \"#cp_container_1\",swfPath: \"/js\",wmode: \"window\",keyEnabled: true,supplied: \"m4a,oga,mp3\",canplay: function () {$(\"#jquery_jplayer_1\").jPlayer(\"play\");}});});</script><script type=\"text/javascript\">(function () {var s = document.createElement('script'), t = document.getElementsByTagName('script')[0];s.type = 'text/javascript';s.async = true;s.src = 'http://api.flattr.com/js/0.6/load.js?mode=auto';t.parentNode.insertBefore(s, t);})();</script></head><body><div id=\"jquery_jplayer_1\" class=\"cp-jplayer\"></div><div id=\"cp_container_1\" class=\"cp-container\"><div class=\"cp-buffer-holder\"><div class=\"cp-buffer-1\"></div><div class=\"cp-buffer-2\"></div></div><div class=\"cp-progress-holder\"><div class=\"cp-progress-1\"></div><div class=\"cp-progress-2\"></div></div><div class=\"cp-circle-control\"></div><ul class=\"cp-controls\"><li><a class=\"cp-play\" tabindex=\"1\">play</a></li><li><a class=\"cp-pause\" style=\"display:none;\" tabindex=\"1\">pause</a></li></ul></div></body></html>";
            context.Response.Write(sss.Replace("AAACCC", context.Request["url"]));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}