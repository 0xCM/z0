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
        public readonly struct Parse<T>  : IParser<T>
            where T : unmanaged        
        {
            public static Parse<T> Op => default;

            public const string Name = "parse";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => gmath.parse<T>(a);
        }
    }
}