//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    partial struct Addressable
    {        
        [MethodImpl(Inline)]
        public static RelAddress<BW,RW,B,R> relative<BW,RW,B,R>(B @base, R offset, BW bw = default, RW rw = default)
            where BW: unmanaged, INumericWidth 
            where RW: unmanaged, INumericWidth        
            where B: unmanaged
            where R: unmanaged
                => new RelAddress<BW,RW,B,R>(@base, offset);

        [MethodImpl(Inline), Op]
        public static RelAddress<W32,W16,uint,ushort> relative(uint @base, ushort offset)
            => relative(@base, offset, w32, w16);

        [MethodImpl(Inline), Op]
        public static RelAddress<W64,W8,ulong,byte> relative(ulong @base, byte offset)
            => relative(@base, offset, w64, w8);

        [MethodImpl(Inline), Op]
        public static RelAddress<W64,W16,ulong,ushort> relative(ulong @base, ushort offset)
            => relative(@base, offset, w64, w16);            
    }
}