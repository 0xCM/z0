//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Characterizes a segment within a bitfield
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct BitFieldPart
    {
        [FieldOffset(0)]
        readonly ulong Data;

        /// <summary>
        /// The postion of the least-significant bit
        /// </summary>
        [FieldOffset(0)]
        public readonly uint Lsb;

        /// <summary>
        /// The postion of the most-significant bit
        /// </summary>
        [FieldOffset(4)]
        public readonly uint Msb;

        [MethodImpl(Inline)]
        public BitFieldPart(uint lsb, uint msb)
        {
            Data = 0;
            Lsb = lsb;
            Msb = msb;
            //Data = (ulong)lsb | (ulong)msb << 32;
        }

        [MethodImpl(Inline)]
        public BitFieldPart(ulong data)
        {
            Lsb = 0;
            Msb = 0;
            Data = data;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitFieldPart((uint lsb, uint msb) src)
            => new BitFieldPart(src.lsb, src.msb);

        [MethodImpl(Inline)]
        public static implicit operator BitFieldPart(ulong src)
            => new BitFieldPart(src);
    }
}