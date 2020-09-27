//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static MSvcHosts;

    using K = Kinds;

    partial class MSvc
    {
        [MethodImpl(Inline)]
        public static PrimalBinaryBitLogic<T> bitlogic<T>(T t = default)
            where T : unmanaged
                => default(PrimalBinaryBitLogic<T>);
    }
}