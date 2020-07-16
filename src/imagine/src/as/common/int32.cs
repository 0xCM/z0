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
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref int int32<T>(ref T src)
            => ref As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool bool8<T>(T src)
            => As<T,bool>(ref src);        
    }
}