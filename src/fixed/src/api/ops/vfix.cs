//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class Fixed    
    {
        [MethodImpl(Inline), Op, Closures(Integers)]        
        public static Fixed128 fix<T>(Vector128<T> x)
            where T : unmanaged
                => Unsafe.As<Vector128<T>,Fixed128>(ref x);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Fixed256 fix<T>(Vector256<T> x)
            where T : unmanaged
                => Unsafe.As<Vector256<T>,Fixed256>(ref x); 

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Fixed128V vfix<T>(Vector128<T> x)
            where T : unmanaged
                => new Fixed128V(v64u(x));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Fixed256V vfix<T>(Vector256<T> x)
            where T : unmanaged
                => new Fixed256V(v64u(x));
    }
}