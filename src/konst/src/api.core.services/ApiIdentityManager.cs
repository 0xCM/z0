//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Konst;

    using api = ApiIdentity;

    [ApiHost]
    public readonly struct ApiIdentityManager
    {
        public static ApiIdentityManager create(IWfShell wf)
            => new ApiIdentityManager(wf);

        readonly IWfShell Wf;

        readonly ConcurrentDictionary<NumericKind, HashSet<NumericKind>> NumericKindSets;

        readonly ConcurrentDictionary<NumericKind, HashSet<Type>> NumericTypeSets;

        internal ApiIdentityManager(IWfShell wf)
        {
            Wf = wf;
            NumericKindSets = new ConcurrentDictionary<NumericKind, HashSet<NumericKind>>();
            NumericTypeSets = new ConcurrentDictionary<NumericKind, HashSet<Type>>();
        }

        [MethodImpl(Inline), Op]
        public EnumIdentityProvider EnumProvider()
            => new EnumIdentityProvider();

        [MethodImpl(Inline), Op]
        public NumericIdentityProvider NumericProvider()
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