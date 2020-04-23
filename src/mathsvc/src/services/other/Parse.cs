//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 
    
    partial class MSvcHosts
    {
        [Closures(AllNumeric)]
        public readonly struct Parse<T>  : ISFParser<T>
            where T : unmanaged        
        {

            [MethodImpl(Inline)]
            public readonly T Invoke(string a) => NumericParser.create<T>().Parse(a).ValueOrDefault();
        }
    }
}