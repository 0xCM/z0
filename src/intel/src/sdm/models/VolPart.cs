//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// EG Vol. 1 iii
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct VolPart
        {
            public CharBlock8 Volume;

            public byte Part;
        }
    }
}