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

    partial class Cells
    {
        [MethodImpl(Inline)]
        public static ref T segment<C,T,W>(in C src, W w, out T dst)
            where T : unmanaged
            where C : IDataCell
            where W : unmanaged, INumericWidth
                => ref seg1(src,w,out dst);

        [MethodImpl(Inline)]
        static ref T seg1<C,T,W>(in C src, W w, out T dst)
            where T : unmanaged
            where C : IDataCell
            where W : unmanaged, INumericWidth
        {
            dst = default;
            ref var input = ref @as<C,byte>(src);
            var size = w.BitWidth/8u;
            ref var output = ref @as<T,byte>(dst);
            if(typeof(W) == typeof(W8))
                copy(w8, input, ref output);
            else if(typeof(W) == typeof(W16))
                copy(w16, input, ref output);
            else if(typeof(W) == typeof(W32))
                copy(w32, input, ref output);
            else if(typeof(W) == typeof(W64))
                copy(w64, input, ref output);
            else
                throw no<W>();

            return ref dst;
        }

    }
}