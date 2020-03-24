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
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumeric(MethodInfo m)
            => NumericMethods.test(m);

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(TypeCode tc)
            => NumericTypes.kind(tc);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(Type src)
            => NumericTypes.test(src);

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(Type src)
            => NumericTypes.kind(src);

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericClass NumericClass(Type src)
            => NumericClasses.classify(src);

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

        [MethodImpl(Inline)]
        public static FixedWidth CpuVectorWidth(Type t)
            => VectorTypes.width(t);

        public static Option<TypeIdentity> IdentifyEnum(Type t)        
            => EnumTypes.identify(t).ToOption();

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
            => src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString() || src.IsObject();

        /// <summary>
        /// Determines whether a type is system-defined
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsSystemType(Type src)
            => src.IsNumeric() || IsNonNumericSystemType(src);

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