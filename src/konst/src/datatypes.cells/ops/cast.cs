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
        public static ref T cast<S,T>(in S src, ref T dst)
            where S : unmanaged, IDataCell<S>
            where T : unmanaged, IDataCell<T>
        {
            dst = ref @as<S,T>(src);
            return ref dst;
        }
    }
}