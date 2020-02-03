//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class BVTypes
    {
        public readonly struct Width<T> : IUnaryMeasure<BitVector<T>,int>
            where T : unmanaged        
        {    
            public static Width<T> Op => default;

            public const string Name = "bvwidth";

            public OpIdentity Moniker => Identity.operation<T>(Name);

            [MethodImpl(Inline)]
            public readonly int Invoke(BitVector<T> a) => BitVector.width(a);

        }
    }
}