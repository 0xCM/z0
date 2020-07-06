//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort uint16<T>(T src)
            => As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort uint16<T>(ref T src)
            => ref As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As<T?, ushort?>(ref src);
    }

}