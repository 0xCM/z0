//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    using api = ApiIdentity;

    [ApiHost]
    public readonly struct ApiIdentityProviders
    {
        [MethodImpl(Inline), Op]
        public static EnumIdentityProvider enums()
            => new EnumIdentityProvider();

        [MethodImpl(Inline), Op]
        public static NumericIdentityProvider numeric()
            => new NumericIdentityProvider();

        public readonly struct EnumIdentityProvider : ITypeIdentityProvider<EnumIdentityProvider,EnumIdentity>
        {
            [MethodImpl(Inline)]
            public EnumIdentity Identify(Type src)
                => api.@enum(src);

            [MethodImpl(Inline)]
            bool CanIdentify(Type src)
                => src.IsEnum;
        }

        public readonly struct NumericIdentityProvider : ITypeIdentityProvider<NumericIdentityProvider,TypeIdentity>
        {
            public TypeIdentity Identify(Type src)
                => TypeIdentity.define(src.NumericKind().Format());

            public IEnumerable<Type> Identifiable
                => z.stream(
                    typeof(byte), typeof(ushort), typeof(uint), typeof(ulong),
                    typeof(sbyte), typeof(short), typeof(int), typeof(long),
                    typeof(float), typeof(double)
                    );
        }
    }
}