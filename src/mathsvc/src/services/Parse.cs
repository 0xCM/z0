//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 
    
    partial class MathSvcTypes
    {
        [Closures(AllNumeric)]
        public readonly struct Parse<T>  : ISFNumericParserApi<T>
            where T : unmanaged        
        {
            public const string Name = "parse";

            public static Parse<T> Op => default;

            public OpIdentity Id => Identities.sfunc<T>(Name);            

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => NumericParser.create<T>().Parse(a).ValueOrDefault();
        }
    }
}