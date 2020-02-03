//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class GXTypes
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Parse<T>  : IParser<T>
            where T : unmanaged        
        {
            public const string Name = "parse";

            public static Parse<T> Op => default;

            public OpIdentity Moniker => Identity.operation<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => gmath.parse<T>(a);
        }
    }
}