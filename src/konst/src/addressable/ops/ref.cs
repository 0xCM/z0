//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;
    
    partial struct Addressable
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> @ref<T>(in T src, uint size)
            => new Ref<T>(new Ref(z.address(src),size));

        [MethodImpl(Inline), Op]
        public static Ref @ref(in byte src, uint size)
            => new Ref(z.address(src),size);

        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef((ulong)pchar(src), src.Length);
    }
}