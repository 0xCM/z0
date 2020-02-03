//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class BCTypes
    {
        public readonly struct Dot<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public static Dot<T> Op => default;

            public const string Name = "dot";

            public OpIdentity Moniker => identify<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => gbits.dot(a,b);
        }
    }

}