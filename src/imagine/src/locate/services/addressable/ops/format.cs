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
        public static string format(RelAddress<W32,W16,uint,ushort> src)
            => gFormat(src);

        [MethodImpl(Inline)]
        static string gFormat<BW,RW,B,R>(RelAddress<BW,RW,B,R> src)
            where BW: unmanaged, INumericWidth 
            where RW: unmanaged, INumericWidth        
            where B: unmanaged
            where R: unmanaged
                => Formatters.format<RW,R>(src.Offset);
    }
}