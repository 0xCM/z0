//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static VXTypes;

    partial class VX
    {
        [MethodImpl(Inline)]
        public static LoadSpan128<T> vloadspan<T>(N128 w, T t = default)
            where T : unmanaged
                => LoadSpan128<T>.Op;

        [MethodImpl(Inline)]
        public static LoadSpan256<T> vloadspan<T>(N256 w, T t = default)
            where T : unmanaged
                => LoadSpan256<T>.Op;
    }
}