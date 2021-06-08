//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial class AsmEncoderPrototype : AppService<AsmEncoderPrototype>
    {
        static ReadOnlySpan<byte> _RexPrefixBytes
            => new byte[16]{0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,0x48,0x49,0x4A,0x4B,0x4C,0x4D,0x4E,0x4F};

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexPrefix> RexPrefixBits()
            => recover<RexPrefix>(_RexPrefixBytes);
   }
}