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
        public struct VolumeNumber
        {
            public byte Value;

            [MethodImpl(Inline)]
            public VolumeNumber(byte value)
            {
                Value = value;
            }
        }
    }
}