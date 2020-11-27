// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct RowBitsIdentityProvider : ITypeIdentityProvider
    {
        public static TypeIdentity NumericClosure(string root, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.define($"{root}{width}{indicator}");
        }

        const string @base = "rowbits";

        public IEnumerable<Type> Identifiable
            => Collective.defer(typeof(RowBits<>));

        public TypeIdentity Identify(Type src)
        {
            var t = src.GenericDefinition2();
            if(t == typeof(void))
                return TypeIdentity.Empty;

            if(t != typeof(RowBits<>))
                return TypeIdentity.Empty;

            if(src.IsOpenGeneric())
                return TypeIdentity.define($"{@base}G");
            else
            {
                var arg = src.GetGenericArguments().Single();
                return ApiIdentify.numeric(@base, arg);
            }
        }
    }
}