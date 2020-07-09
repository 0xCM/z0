//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct core
    {                
        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static byte uint8<T>(T src)
            => As<T,byte>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref byte uint8<T>(ref T src)
            => ref As<T,byte>(ref src);
    }
}