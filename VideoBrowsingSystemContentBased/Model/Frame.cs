using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoBrowsingSystemContentBased.Model
{
    public class Frame
    {
        private String FrameName { get; set; }
        private String SemanticContent { get; set; }
        private String VideoId { get; set; }
        private int Shot { get; set; }
        private String VideoName { get; set; }
        private String Thumb { get; set; }

        private Bitmap FrameImage { get; set; }

        public Frame()
        {
           
        }

        public Frame(String frameName, String semanticContent, String videoId, int shot, String videoName, String thumb)
        {
            this.FrameName = frameName;
            this.SemanticContent = semanticContent;
            this.VideoId = videoId;
            this.Shot = shot;
            this.VideoName = this.VideoName;
            this.Thumb = thumb;
        }
    }
}
