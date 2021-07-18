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
        public enum VolDigit : byte
        {
            V1 = 1,

            V2 = 2,

            V3 = 3,

            V4 = 4
        }
    }
}