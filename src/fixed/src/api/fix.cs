//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {
        [MethodImpl(Inline)]
        public static F fix<T,F>(T src)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => Unsafe.As<T,F>(ref src);

        [MethodImpl(Inline)]
        public static T unfix<F,T>(F src)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => Unsafe.As<F,T>(ref src);
    }
}