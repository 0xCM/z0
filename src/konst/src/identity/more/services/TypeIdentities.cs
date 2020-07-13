//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    public class TypeIdentities
    {
        /// <summary>
        /// Retrieves a type's specialized identity provider, if it has one; otherwise, returns a caller-supplied fallback
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="fallback">The identity provider to yield if the type does not have a specialized provider</param>
        public static ITypeIdentityProvider provider(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src.EffectiveType(), fallback);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeWidth w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeWidth w1, ITypeWidth w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on natural bitwidth
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on two natural bitwidths
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   
         
        /// <summary>
        /// Defines a segmented type identity predicated on type width numeric kind specifications
        /// </summary>
        /// <param name="name">The type name</param>
        /// <param name="wk">The width kind</param>
        /// <param name="nk">The numeric kind</param>
        [MethodImpl(Inline)]
        public static TypeIdentity segmented(string name, TypeWidth wk, NumericKind nk)
            => TypeIdentity.Define($"{name}{wk.FormatValue()}x{nk.Format()}");

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders {get;}
                    = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }
}