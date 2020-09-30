//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class MSvcHosts
    {
        [Closures(Integers)]
        public readonly struct NumericUnaryBitLogic<T> : IUnaryBitLogic<T>
            where T : unmanaged
        {
           [MethodImpl(Inline)]
            public T not(T a)
                => gmath.not(a);

            [MethodImpl(Inline)]
            public T identity(T a)
                => gmath.identity(a);
        }
    }
}