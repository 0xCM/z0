
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static SBlock;

    partial class BSvcHosts
    {
        [Closures(Integers), Sll]
        public readonly struct Sll128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, [Imm] byte count, in Block128<T> dst)            
                => ref zip(a, count, dst, VSvc.vsll<T>(n128));
        }

        [Closures(Integers), Sll]
        public readonly struct Sll256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, [Imm] byte count, in Block256<T> dst)            
                => ref zip(a, count, dst, VSvc.vsll<T>(n256));
        }    
    }
}