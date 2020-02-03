//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static zfunc;

    public static class TypeIdentities
    {
        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        /// <summary>
        /// Attempts to create a type identity prodiver as directed by an attributed type
        /// or by a type that realizes the required interface
        /// </summary>
        /// <param name="t">The source type</param>
        internal static ITypeIdentityProvider provider(Type src)
        {
            var t = src.EffectiveType();
            return t.FromCache().ValueOrElse(() => t.CreateProvider());            
        }

        static ITypeIdentityProvider CreateProvider(this Type t)
        {
            var provider = default(ITypeIdentityProvider);   

            if(t.IsAttributed<IdentityProviderAttribute>())
                provider = t.FromAttributed().ValueOrElse(DefaultProvider);
            else if(t.Realizes<ITypeIdentityProvider>())
                provider = t.FromHost().ValueOrElse(DefaultProvider);
            else
                provider = DefaultProvider;
            return t.Cache(provider);
        }

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromHost(this Type host)
            => Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromAttributed(this Type t)
            => from a in t.CustomAttribute<IdentityProviderAttribute>()
               from tid in FromHost(a.Host)
               select tid;

        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromCache(this Type t)
            => CachedProviders.TryFind(t);
        
        [MethodImpl(Inline)]
        static ITypeIdentityProvider Cache(this Type t, ITypeIdentityProvider provider)
        {
            CachedProviders.TryAdd(t,provider);
            return provider;
        }

        static TypeIdentity defaultid(this Type arg)
        { 
            Option<string> text = default;

            if(arg.HasCommonIdentity())
                text = arg.CommonIdentity();
            else if(arg.IsConstructedGenericType)              
            {
                var typeargs = arg.SuppliedTypeArgs().ToArray();
                var typearg = typeargs[0];                
                if(arg.HasCommonIdentity())
                    text = arg.CommonIdentity();
                else if(arg.IsSegmented())
                    text = arg.SegmentedIdentity(typearg).ValueOrDefault();
            }   
                
            return text.MapValueOrElse(t => TypeIdentity.Define(t), () => TypeIdentity.Empty);
        } 

        static Option<string> CommonIdentity(this Type arg)
        {
            if(arg.IsPointer)
                return from id in arg.Unwrap().CommonIdentity()
                let idptr = concat(id, TypeIdentity.Modifier, TypeIdentity.Pointer)
                select idptr;    
            else
            {                        
                if(arg.IsNat())
                    return arg.NatIdentity();
                else if(NumericType.test(arg))
                    return arg.NumericIdentity();
                else if(arg.IsEnum)
                    return arg.EnumIdentity();
                else if(arg.IsSpan())
                    return arg.SpanIdentity();
                else if(arg.IsNatSpan())
                    return arg.NatSpanIdentity();
                else if(arg == typeof(bit))
                    return "1u";                
            }

            return default;
        }

        static bool HasCommonIdentityRaw(this Type t)
            => t.IsNat() || NumericType.test(t) || t.IsEnum || t.IsSpan() || t.IsNatSpan();

        static bool HasCommonIdentity(this Type t)
            => t.HasCommonIdentityRaw() || t.Unwrap().HasCommonIdentityRaw();

        static Option<string> EnumIdentity(this Type arg)
            => $"enum{OpIdentity.SegSep}{NumericType.signature(arg.GetEnumUnderlyingType())}";
                
        static Option<string> NatIdentity(this Type arg)
            => from v in arg.NatValue() 
                let id = concat(OpIdentity.Nat, v.ToString())
                select id;

        static Option<string> NumericIdentity(this Type arg)
            => NumericType.test(arg) 
                ? NumericType.signature(arg) 
                : default;

        static Option<string> SpanIdentity(this Type arg)
            => arg.IsSpan() ? arg.GetGenericArguments().Single().CommonIdentity().MapValueOrDefault(x => concat(OpIdentity.Span,x))
             : none<string>();
                                
        static Option<string> SegIndicator(this Type t)
        {
            if(t.IsBlocked())
                return $"{OpIdentity.Block}";
            else if(t.IsVector())
                return $"{OpIdentity.Vector}";
            else return none<string>();
        }

        static Option<string> SegmentedIdentity(this Type t, Type arg)
            => from i in t.SegIndicator()
                let segwidth = t.Width()
                let argwidth = arg.Width()
                let nk = arg.NumericKind()
                where segwidth.IsSome() && argwidth.IsSome() && nk.IsSome()
                select $"{i}{segwidth.Format()}{OpIdentity.SegSep}{argwidth.Format()}{nk.Indicator().Format()}";
 
        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(defaultid);

        static ConcurrentDictionary<Type, ITypeIdentityProvider> CachedProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();

        readonly struct FunctionalProvider : ITypeIdentityProvider
        {     
            readonly Func<Type, TypeIdentity> f;
            
            [MethodImpl(Inline)]
            public FunctionalProvider(Func<Type, TypeIdentity> f)
                => this.f = f;
            
            [MethodImpl(Inline)]
            public TypeIdentity DefineIdentity(Type src)
                => f(src);
        }
    }
}