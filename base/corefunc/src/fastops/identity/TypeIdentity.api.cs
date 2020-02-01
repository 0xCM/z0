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
        public static string ResourceIdentity(string basename, ITypeNat w, NumericKind kind)
            => $"{basename}{w}x{kind.Signature()}";
        
        [MethodImpl(Inline)]
        public static string ResourceIdentity(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => $"{basename}{w1}x{w2}x{kind.Signature()}";   

        public static Option<Moniker> ProvidedIdentity(this Type t)
            => Provider(t).DefineIdentity(t);

        static Option<string> CommonIdentity(this Type arg)
        {
            if(arg.IsPointer)
                return from id in arg.Unwrap().CommonIdentity()
                let idptr = concat(id, parenthetical(Moniker.Pointer))
                select idptr;            
            if(arg.IsNat())
                return arg.NatIdentity();
            else if(NumericType.test(arg))
                return arg.NumericIdentity();
            else if(arg.IsEnum)
                return arg.EnumIdentity();
            else if(arg.IsSpan())
                return arg.SpanIdentity();
            else if(arg.IsNatSpan())
                return arg.NatSpanIdentity().MapRequired(x => x.Text);
            else if(arg == typeof(bit))
                return "1u";

            return default;
        }

        static bool HasIdentityProvider(this Type arg)
            => arg.IsAttributed<IdentityProviderAttribute>();

        static bool HasCommonIdentityRaw(this Type t)
            => t.IsNat() || NumericType.test(t) || t.IsEnum || t.IsSpan() || t.IsNatSpan();

        static bool HasCommonIdentity(this Type t)
            => t.HasCommonIdentityRaw() || t.Unwrap().HasCommonIdentityRaw();

        static Option<string> EnumIdentity(this Type arg)
            =>  TypeIdentities.EnumIdentity(arg) 
                ? $"enum{Moniker.SegSep}{NumericType.signature(arg.GetEnumUnderlyingType())}" 
                : default;

        static Option<string> NatIdentity(this Type arg)
            => from v in arg.NatValue() 
                let id = concat(Moniker.Nat, v.ToString())
                select id;

        static Option<string> NumericIdentity(this Type arg)
            => NumericType.test(arg) 
                ? NumericType.signature(arg) 
                : default;

        static Option<string> SpanIdentity(this Type arg)
            => arg.IsSpan() ? arg.GetGenericArguments().Single().CommonIdentity().MapValueOrDefault(x => concat(Moniker.Span,x))
             : none<string>();
                            
        static Option<string> SegIndicator(this Type t)
        {
            if(t.IsBlocked())
                return $"{Moniker.Block}";
            else if(t.IsVector())
                return $"{Moniker.Vector}";
            else return none<string>();
        }

        static Option<string> SegmentedIdentity(this Type t, Type arg)
            => from i in t.SegIndicator()
                let segwidth = t.Width()
                let argwidth = arg.Width()
                let nk = arg.NumericKind()
                where segwidth.IsSome() && argwidth.IsSome() && nk.IsSome()
                select $"{i}{segwidth.Format()}{Moniker.SegSep}{argwidth.Format()}{nk.Indicator().Format()}";
        
        /// <summary>
        /// Attempts to create a type identity prodiver as directed by an attributed type
        /// or by a type that realizes the required interface
        /// </summary>
        /// <param name="t">The source type</param>
        static ITypeIdentityProvider Provider(Type src)
        {
            var t = src.EffectiveType();
            var provider = FromCache(t);
            if(provider)
                return provider.Value;
            else 
            {
                if(t.IsAttributed<IdentityProviderAttribute>())
                {
                    provider = FromAttributed(t);
                    provider.OnSome(p => Cache(t,p));                
                }
                else if(t.Realizes<ITypeIdentityProvider>())
                {
                    provider = FromHost(t);
                    provider.OnSome(p => Cache(t,p));
                }
                else
                    provider = some(default(TypeIdentityDefault) as ITypeIdentityProvider);
            }
            return provider.Require();            
        }

        internal static Option<Moniker> DefineDefaultIdentity(this Type arg)
        { 
            Option<string> text = default;
            if(arg.HasCommonIdentity())
                text = TypeIdentities.CommonIdentity(arg);
            else if(arg.IsConstructedGenericType)              
            {
                var typeargs = arg.SuppliedGenericArguments().ToArray();
                var typearg = typeargs[0];                
                if(arg.HasCommonIdentity())
                    text = arg.CommonIdentity();
                if(arg.HasIdentityProvider())
                    text = TypeIdentities.Provider(typearg).DefineIdentity(typearg).TryMap(x => x.Text);                        
                else if(arg.IsSegmented())
                    text = arg.SegmentedIdentity(typearg).ValueOrDefault();
            }   
                
            return from t in text
                select Moniker.Parse(t);
        } 

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();

        static Option<ITypeIdentityProvider> FromCache(Type t)
            => TypeIdentityProviders.TryFind(t);
        
        static void Cache(Type t, ITypeIdentityProvider provider)
            => TypeIdentityProviders.TryAdd(t,provider);

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        [MethodImpl(Inline)]
        static Option<ITypeIdentityProvider> FromHost(Type host)
            => Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        static Option<ITypeIdentityProvider> FromAttributed(Type t)
            => from a in t.CustomAttribute<IdentityProviderAttribute>()
               from tid in FromHost(a.Host)
               select tid;
    }
}