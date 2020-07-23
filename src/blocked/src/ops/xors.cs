//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static z;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> xors<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.xors<T>(w128).Invoke(a, count, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> xors<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.xors<T>(w256).Invoke(a, count, dst);
    }
}