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
        public static Vector256<T> vector<T>(in Fixed256V src)
            where T : unmanaged
                => src.ToVector<T>();

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vector<T>(in Fixed128V src)
            where T : unmanaged
                => src.ToVector<T>();

        [MethodImpl(Inline), Op, Closures(Integers)]        
        public static Vector128<T> vector<T>(in Fixed128 src)
            where T : unmanaged
                => Unsafe.As<Fixed128,Vector128<T>>(ref Unsafe.AsRef(in src));

        [MethodImpl(Inline), Op, Closures(Integers)]        
        public static Vector256<T> vector<T>(in Fixed256 src)
            where T : unmanaged
                => Unsafe.As<Fixed256,Vector256<T>>(ref Unsafe.AsRef(in src));
    }
}