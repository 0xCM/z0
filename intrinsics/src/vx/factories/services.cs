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
        public static BitLogic128<T> vbitlogic<T>(N128 w, T t = default)
            where T : unmanaged
                => BitLogic128<T>.Svc;

        [MethodImpl(Inline)]
        public static BitLogic256<T> vbitlogic<T>(N256 w, T t = default)
            where T : unmanaged
                => BitLogic256<T>.Svc;
    }
}