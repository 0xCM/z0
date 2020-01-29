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

    using static zfunc;

    public static class TypeIdentity
    {
        /// <summary>
        /// Attempts to create a type identity prodiver as directed by an attributed type
        /// or by a type that realizes the required interface
        /// </summary>
        /// <param name="t">The source type</param>
        public static ITypeIdentityProvider Provider(Type t)
        {
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
                    provider = some(default(DefaultTypeIdentityProvider) as ITypeIdentityProvider);
            }
            return provider.Require();            
        }

        /// <summary>
        /// Creates a type identity provider from a function
        /// </summary>
        /// <param name="f">The defining function</param>
        public static ITypeIdentityProvider Provider(Func<Type,Moniker> f)
            => new TypeIdentityProvider(f);

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();

        static Option<ITypeIdentityProvider> FromCache(Type t)
            => TypeIdentityProviders.TryFind(t);
        
        static void Cache(Type t, ITypeIdentityProvider provider)
        {
            TypeIdentityProviders.TryAdd(t,provider);
        }

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

    readonly struct DefaultTypeIdentityProvider : ITypeIdentityProvider
    {                    
        public Moniker DefineIdentity(Type arg)
        { 
            var id = string.Empty;
            if(HasDirectAlgorithm(arg))
                id += DirectAlgorithm(arg);
            else if(arg.IsConstructedGenericType)              
                id += ConsructedId(arg);
            else
                id += arg.Name;    
            return Moniker.Parse(id);                        
        } 


        static bool HasDirectAlgorithm(Type t)
            => NatType.test(t) || NumericType.test(t) || t.IsEnum || t.IsSpan() || t.IsNatSpan();

        static string DirectAlgorithm(Type t)
        {
            if(NatType.test(t))
                return NatTypeId(t);
            else if(NumericType.test(t))
                return NumericTypeId(t);
            else if(t.IsEnum)
                return EnumTypeId(t);
            else if(t.IsNumericSpan())
                return NumericSpanTypeId(t);
            else if(t.IsNatSpan())
                return NatSpanType.id(t).MapRequired(x => x.Text);                
            else
                return $"ed_{t.Name}";

        }

        static string EnumTypeId(Type arg)
            => $"enum{Moniker.SegSep}{NumericType.signature(arg.GetEnumUnderlyingType())}";

        static string NatTypeId(Type arg)
            => NatType.name(arg).ValueOrDefault(arg.Name);

        static string NumericTypeId(Type arg)
            => NumericType.signature(arg);

        static string NumericSpanTypeId(Type arg)
            => $"span{NumericType.signature(arg)}";

        static bool HasSpecializedProvider(Type arg)
            => arg.IsAttributed<IdentityProviderAttribute>();

        static string SegmentedId(Type t, Type arg)
        {
            var id = string.Empty;
            var w = (int)t.Width();
            if(w != 0)
            {
                id += $"{w}";
                var segwidth = (int)arg.Width();
                if(segwidth != 0)
                    id += $"{Moniker.SegSep}{segwidth}{arg.NumericKind().Indicator()}";
            }
            else 
                id += "~ew";                
            return id;
        }

        static string ConsructedId(Type t)
        {
            var id = string.Empty;
            var typeargs = t.SuppliedGenericArguments().ToArray();
            var arg = typeargs[0];
            if(HasDirectAlgorithm(t))
                return DirectAlgorithm(t);
            if(HasSpecializedProvider(t))
                return TypeIdentity.Provider(arg).DefineIdentity(arg);                        
            else if(t.IsSegmented())
                return SegmentedId(t, arg);
            else 
                return $"~eg_{t.Name}_{arg.Name}";                
        }
   
    }

}
