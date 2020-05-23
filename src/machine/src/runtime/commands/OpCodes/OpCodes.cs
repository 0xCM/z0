//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static HexCodes;
    using static Seed;
    using static Memories;
 

    [ApiHost]
    public class OpCodes : IApiHost<OpCodes>
    {

        [Op, MethodImpl(Inline)]
        public static OpCodeOperand operand(ulong src, duet index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));


        [Op, MethodImpl(Inline)]
        public static ReadOnlySpan<byte> encode(in OpCodeSpec src)
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).AsBytes();     
    }
}