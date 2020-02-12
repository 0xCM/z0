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

    using static zfunc;
    using static TypeIdentity;

    public static class TypeIdentities
    {
        /// <summary>
        /// Defines a source type identifier, intended to be unique within a caller-determined scope
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        internal static ITypeIdentityProvider provider(Type src)
            => IdentityProviders.find(src, CreateProvider);

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

        static Option<TypeIdentity> CommonIdentity(this Type arg)
        {
            if(arg.IsPointer)
                return from id in arg.Unwrap().CommonIdentity()
                let idptr = concat(id, IDI.ModSep, IDI.Pointer)
                select TypeIdentity.Define(idptr);    
            else
            {                        
                if(arg.IsNat())
                    return arg.NatIdentity();
                else if(arg.IsPrimal())
                    return arg.PrimalIdentity();
                else if(arg.IsEnum)
                    return arg.EnumIdentity();
                else if(arg.IsSegmented())
                    return arg.SegmentedIdentity();
                else if(arg.IsSpan())
                    return arg.SpanIdentity();
                else if(arg.IsNatSpan())
                    return arg.NatSpanIdentity();
            }

                return none<TypeIdentity>();
        }

        static Option<TypeIdentity> EnumIdentity(this Type t)
            =>  TypeIdentity.Define($"{t.Name}{IDI.ModSep}{t.GetEnumUnderlyingType().NumericKind().Signature()}");
                
        static Option<TypeIdentity> NatIdentity(this Type arg)
            => from v in arg.NatValue() 
                let id = concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        static Option<TypeIdentity> PrimalIdentity(this Type arg)
        {
            if(arg.IsNumeric())
                return TypeIdentity.Define(arg.NumericKind().Signature());
            else if(arg.IsPrimalNonNumeric())
                return TypeIdentity.Define(arg.PrimitiveKeyword());
            else
                return none<TypeIdentity>();
        }

        static Option<TypeIdentity> SpanIdentity(this Type arg)
        {
            return 
                from info in arg.SpanInfo()
                from cell in info.celltype.CommonIdentity()
                select TypeIdentity.Define(concat(info.kind.Format(), cell));            
        }
                                
        static Option<char> SegIndicator(this Type t)
        {
            if(t.IsBlocked())
                return IDI.Block;
            else if(t.IsVector())
                return IDI.Vector;
            else 
                return none<char>();
        }

        /// <summary>
        /// Defines an identity for a type-natural span type
        /// </summary>
        /// <param name="src">The type to examin</param>
        static Option<TypeIdentity> NatSpanIdentity(this Type src)
        {
            if(src.IsNatSpan())
            {
                var typeargs = src.SuppliedTypeArgs().ToArray();                    
                var text = IDI.NSpan;
                text += typeargs[0].NatValue();
                text += IDI.SegSep;
                text += typeargs[1].NumericKind().Signature();
                return TypeIdentity.Define(text);
            }
            else
                return none<TypeIdentity>();
        }

        //$"{(int)TotalWidth}{TypeIdentity.SegSep}{(int)SegWidth}{(char)Indicator}";
        static Option<TypeIdentity> SegmentedIdentity(this Type t)
            =>  from i in t.SegIndicator()
                let segwidth = t.Width()                
                where segwidth.IsSome()
                let segfmt = segwidth.Format()
                let arg = t.GetGenericArguments().Single()
                let argwidth = arg.Width()                
                where   argwidth.IsSome()
                let argfmt = argwidth.Format()
                let nk = arg.NumericKind()
                where  nk.IsSome()                
                let nki = nk.Indicator().Format()
                let identifer = concat(i,segfmt,IDI.SegSep,argfmt, nki)                
                select TypeIdentity.Define(identifer);

        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(arg => arg.CommonIdentity().ValueOrElse(() => TypeIdentity.Empty));

        static ITypeIdentityProvider CreateProvider(this Type t)
        {
            var provider = none<ITypeIdentityProvider>();   

            if(t.IsAttributed<IdentityProviderAttribute>())
                provider = t.FromAttributed();
            else if(t.Realizes<ITypeIdentityProvider>())
                provider = t.FromHost();

            return provider.ValueOrElse(() => DefaultProvider);
        }


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