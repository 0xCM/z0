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
        public static short int16<T>(T src)
            => As<T,short>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref short int16<T>(ref T src)
            => ref As<T,short>(ref src);


    }
}