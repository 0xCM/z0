//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public readonly struct VexPrefix
    {
        readonly uint Data;

        internal VexPrefix(byte b0, byte b1)
        {
            Data = (uint)b0 | ((uint)b1 << 8) | (2 << 16);
        }


        public byte Size
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 24);
        }
    }
}