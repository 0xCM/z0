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
        public readonly struct Gather<T> : IBVBinaryOp<T>
            where T : unmanaged        
        {    
            public static Gather<T> Op => default;

            public const string Name = "bvgather";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly BitVector<T> Invoke(BitVector<T> a, BitVector<T> b) => BitVector.gather(a,b);

        }
    }
}