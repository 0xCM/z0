//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class KOpStructs
    {
        public readonly struct Parse<T>  : IPrimalParser<T>
            where T : unmanaged        
        {
            public static Parse<T> Op => default;

            public const string Name = "parse";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => gmath.parse<T>(a);
        }
    }
}