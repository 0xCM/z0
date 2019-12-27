//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class PrimalX
    {
        [MethodImpl(Inline)]
        public static bit Is<T>(this PrimalKind kind, T t = default)
            where T : unmanaged
                => Primitive.iskind(kind,t);
    }

}