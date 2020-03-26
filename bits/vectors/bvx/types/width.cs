//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static partial class BVTypes
    {
        public readonly struct Width<T> : ISFuncApi<BitVector<T>,int>
            where T : unmanaged        
        {    
            public static Width<T> Op => default;

            public const string Name = "bvwidth";

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly int Invoke(BitVector<T> a) => BitVector.width(a);
        }
    }
}