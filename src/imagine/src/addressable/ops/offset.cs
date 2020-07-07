//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    
    partial struct Addressable
    {
        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, byte offset)
            => new MemoryOffset(@base, offset, NumericWidth.W8);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset, NumericWidth.W16);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, uint offset)
            => new MemoryOffset(@base, offset, NumericWidth.W32);

        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, ulong offset)
            => new MemoryOffset(@base, offset, NumericWidth.W64);



        [MethodImpl(Inline), Op]
        public static MemoryOffset offset(MemoryAddress @base, MemoryAddress src)
        {
            var delta = src - @base;

            if(delta <= byte.MaxValue)
                return offset(@base, (byte)delta);
            else if(delta <= ushort.MaxValue)
                return offset(@base, (ushort)delta);
            else if(delta <= uint.MaxValue)
                return offset(@base, (uint)delta);
            else
                return offset(@base, (ulong)delta);
        }
    }
}