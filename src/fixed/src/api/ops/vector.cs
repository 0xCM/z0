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
    }
}