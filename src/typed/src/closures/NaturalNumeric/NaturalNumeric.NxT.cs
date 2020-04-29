//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Typed;

    public readonly struct NaturalNumericClosure<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged        
    {
        public readonly MethodInfo Definition;

        [MethodImpl(Inline)]
        public NaturalNumericClosure(MethodInfo def) 
        {
            this.Definition = def;
        }

        public NaturalNumericClosure Untyped 
            => new NaturalNumericClosure(Definition, null, value<N>(), typeof(T).NumericKind());
    }

}