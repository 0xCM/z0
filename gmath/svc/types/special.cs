//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    

    partial class GXTypes
    {
        [NumericClosures(NumericKind.All)]
        public readonly struct Parse<T>  : INumericParser<T>
            where T : unmanaged        
        {
            public const string Name = "parse";

            public static Parse<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => NumericParser.parse<T>(a);
        }
    }
}