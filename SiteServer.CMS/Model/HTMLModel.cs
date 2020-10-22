using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteServer.CMS.Model
{
    public class HTMLModel
    {
        public class Video
        {
            public const string autoplay = nameof(autoplay);
            public const string controls = nameof(controls);
            public const string height = nameof(height);
            public const string loop = nameof(loop);
            public const string muted = nameof(muted);
            public const string poster = nameof(poster);
            public const string preload = nameof(preload);
            public const string src = nameof(src);
            public const string width = nameof(width);
            
        }

        public class Audio
        {
            public const string autoplay = nameof(autoplay);
            public const string controls = nameof(controls);
            public const string loop = nameof(loop);
            public const string muted = nameof(muted);
            public const string preload = nameof(preload);
            public const string src = nameof(src);
        }
    }
}
