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
    using static As;

    partial struct V0
    {           
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector128<T> src, W128 w = default)
            where T : unmanaged            
        {
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, vcount<T>(w));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector256<T> src, W256 w = default)
            where T : unmanaged            
        {
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, vcount<T>(w));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector512<T> src, W512 w = default)
            where T : unmanaged            
        {
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, vcount<T>(w));
        }
    }
}