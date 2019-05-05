﻿using MMTools.Options;

namespace MMTools
{
    public class FFMPEGInput : FFMPEGOptionsBase
    {
        public IMMInputOutput Input { get; set; }
        public double? InputOffset { get; set; }
        public VsyncType? VSync { get; set; }
    }
}