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
    using System.Linq;

    public static class TypeIdentities
    {
        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(Type t)
            => t.GenericDefinition() == typeof(Span<>) 
                    ? Z0.SpanKind.Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) 
                ? Z0.SpanKind.Immutable
              : 0;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(Type t)
            => SpanKind(t) != 0;
        
        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsCpuVector(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return false;

            return def == typeof(Vector128<>) || def == typeof(Vector256<>) || CpuVectorAttribute.Test(def);             
        }

        [MethodImpl(Inline)]
        public static FixedWidth CpuVectorWidth(Type t)
        {
            var eff = t.EffectiveType();
            var def = eff.IsGenericType ? eff.GetGenericTypeDefinition() : (eff.IsGenericTypeDefinition ? eff : null);
            if(def == null)
                return FixedWidth.None;
            else if(def == typeof(Vector128<>))            
                return FixedWidth.W128;
            else if(def == typeof(Vector256<>))
                return FixedWidth.W256;
            else
            {
                var tag = t.Tag<CpuVectorAttribute>();
                if(tag)
                    return tag.Value.TotalWdth;
                else
                    return FixedWidth.None;
            }                                         
        }

        public static Option<TypeIdentity> IdentifyEnum(Type t)        
        {
            var id = EnumIdentity.From(t);
            return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        } 

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
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(Type src)
            => NumericIdentity.kind(src).ValueOrDefault();

        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericClass NumericClass(Type src)
            => NumericClasses.classify(src);

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(TypeCode tc)
            => NumericIdentity.kind(tc);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(Type src)
            => NumericKind(src) != 0;

        /// <summary>
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumeric(MethodInfo m)
            => (m.HasVoidReturn() || IsNumeric(m.ReturnType)) 
             && m.ParameterTypes().All(t => IsNumeric(t));

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        public static Option<ITypeIdentityProvider> HostedProvider(Type host)
            => Root.Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        public static Option<ITypeIdentityProvider> AttributedProvider(Type t)
            => from a in t.Tag<IdentityProviderAttribute>()
               from tid in  HostedProvider(a.Host.ValueOrDefault(t))
               select tid;

    }

}