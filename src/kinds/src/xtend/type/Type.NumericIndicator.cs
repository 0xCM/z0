//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    using NI = NumericIndicator;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Option<NumericIndicator> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i != 0 ? Option.some(i) : Option.none<NumericIndicator>();
        }           
    }
}