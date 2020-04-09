//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class MathSvcHosts
    {
        [Closures(NumericKind.All)]
        public readonly struct Parse<T>  : ISFNumericParserApi<T>
            where T : unmanaged        
        {
            public const string Name = "parse";

            public static Parse<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => Numeric.parse<T>(a).ValueOrDefault();
        }
    }
}