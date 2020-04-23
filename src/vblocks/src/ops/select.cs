
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

    partial class VBlockHosts
    {
        [Closures(Integers), Select]
        public readonly struct Select128<T> : IBlockedTernaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst)            
                => ref zip(a,b,c,dst, VSvc.vselect<T>(w128));
        }

        [Closures(Integers), Select]
        public readonly struct Select256<T> : IBlockedTernaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst)            
                => ref zip(a,b,c,dst, VSvc.vselect<T>(w256));
        }
    }
}