//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        public enum CILMethodFlags : byte
        {
            ILTinyFormat = 0x02,

            ILFatFormat = 0x03,

            ILFormatMask = 0x03,

            ILTinyFormatSizeShift = 2,

            ILMoreSects = 0x08,

            ILInitLocals = 0x10,

            ILFatFormatHeaderSize = 0x03,

            ILFatFormatHeaderSizeShift = 4,

            SectEHTable = 0x01,

            SectOptILTable = 0x02,

            SectFatFormat = 0x40,

            SectMoreSects = 0x40,
        }

    }

}