//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline)]
        public static NumericBitLogic<T> bitlogic<T>()
            where T : unmanaged
                => default(NumericBitLogic<T>);
    }
}