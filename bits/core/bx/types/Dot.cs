//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;

    partial class BitCoreServices
    {
        public readonly struct Dot<T> : ISFuncApi<T,T,bit>
            where T : unmanaged        
        {
            public static Dot<T> Op => default;

            public const string Name = "dot";

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public bit Invoke(T a, T b) => gbits.dot(a,b);
        }
    }
}