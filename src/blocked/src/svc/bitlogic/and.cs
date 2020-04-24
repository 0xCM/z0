
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static SBlock;

    partial class BSvcHosts
    {
        // [Closures(Integers), And]
        // public readonly struct And64<T> : IBlockedBinaryOp64<T>
        //     where T : unmanaged
        // {
        //     [MethodImpl(Inline)]
        //     public ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> dst)            
        //         => ref zip(a, b, dst, MSvc.and<T>);
        // }

        [Closures(Integers), And]
        public readonly struct And128<T> : IBlockedBinaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> dst)            
                => ref zip(a, b, dst, VSvc.vand<T>(w128));
        }

        [Closures(Integers), And]
        public readonly struct And256<T> : IBlockedBinaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> dst)            
                => ref zip(a, b, dst, VSvc.vand<T>(w256));
        } 
    }
}