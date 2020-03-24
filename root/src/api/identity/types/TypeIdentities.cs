//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Root;

    public static class TypeIdentities
    {


        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(Type t)
            => SpanTypes.kind(t);

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(Type t)
            => SpanTypes.test(t);
        
        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsCpuVector(Type t)
            => VectorTypes.test(t);

        public static Option<TypeIdentity> IdentifyPrimitive(Type arg)
        {
            var id = PrimalIdentity.From(arg);
            return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        }

        /// <summary>
        /// Determines whether a type is a non-numeric primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsNonNumericSystemType(Type src)
            => SystemTypes.nonnumeric(src);

        /// <summary>
        /// Determines whether a type is system-defined
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsSystemType(Type src)
            => SystemTypes.test(src);

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        public static Option<ITypeIdentityProvider> HostedProvider(Type host)
            => Root.Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        public static Option<ITypeIdentityProvider> AttributedProvider(Type t)
            => from a in t.Tag<IdentityProviderAttribute>()
               from tid in  HostedProvider(a.Host.ToOption().ValueOrDefault(t))
               select tid;
    }
}