//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ImageLiterals
    {
        public const ushort Magical = 0x5A4D;

        public const byte SigOffset = 0x3C;

        public const uint SigExpect = 0x00004550;

        public const byte ImageDataDirectoryCount = 15;

        public const byte ComDataDirectory = 14;

        public const byte DebugDataDirectory = 6;

        public const byte IMAGE_SIZEOF_SHORT_NAME = 8;
    }

}