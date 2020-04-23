
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
        [Closures(Integers), Xors]
        public readonly struct Xors128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, [Imm] byte count, in Block128<T> dst)            
                => ref Blocked.xors(a, count, dst);
        }

        [Closures(Integers), Xors]
        public readonly struct Xors256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, [Imm] byte count, in Block256<T> dst)            
                => ref Blocked.xors(a, count, dst);
        }    
    }
}