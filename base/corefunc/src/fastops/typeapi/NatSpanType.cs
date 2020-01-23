//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class NatSpanType
    {
        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t)
            => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(NatSpan<,>);

        public static Option<Moniker> id(Type src)
        {
            if(src.IsNatSpan())
            {
                var typeargs = src.GetGenericArguments().ToArray();                    
                var text = "ns";
                text += TypeNatType.value(typeargs[0]);
                text += Moniker.SegSep;
                text += PrimalType.primalsig(typeargs[1]);
                return Moniker.Parse(text);
            }
            else
                return default;
        }

    }
}