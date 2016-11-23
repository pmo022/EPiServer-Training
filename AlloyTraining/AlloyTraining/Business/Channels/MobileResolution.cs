using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels
{
    public class MobileResolution : IDisplayResolution
    {
        public string Id { get { return this.GetType().FullName; } }
        public string Name { get { return "Mobile 320x480"; } }
        public int Width { get { return 320;  } }
        public int Height { get { return 480; } }
    }
}