//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Memories;

    readonly struct TypeIdentityDiviner : ITypeIdentityDiviner
    {        
        /// <summary>
        /// Determines whether a type is a natural span
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(Type t)
            => t.GenericDefinition2() == typeof(NatSpan<,>) && t.IsClosedGeneric();

        public TypeIdentity DivineIdentity(Type arg)
            => TryDivine(arg).ValueOrElse(() => TypeIdentity.Define(arg.DisplayName()));

        public Option<TypeIdentity> TryDivine(Type arg)
        {
            if(arg.IsPointer)
                return PointerId(arg);
            else if(arg.IsTypeNat())
                return NatId(arg);
            else if(arg.IsSystemDefined())
                return Identify.primal(arg).AsTypeIdentity().ToOption();
            else if(arg.IsEnum)
                return some(EnumIdentity.Define(arg).AsTypeIdentity());
            else if(arg.IsSegmented())
                return SegmentedId(arg);
            else if(arg.IsArray)
                return ArrayId(arg);
            else if(SpanTypes.IsSystemSpan(arg))
                return SystemSpanId(arg);
            else if(IsNatSpan(arg))
                return NatSpanId(arg);  
            else           
                return none<TypeIdentity>();
        }

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        public static Option<ITypeIdentityProvider> HostedProvider(Type host)
            => Option.Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        public static Option<ITypeIdentityProvider> AttributedProvider(Type t)
            => from a in t.Tag<IdentityProviderAttribute>()
               from tid in HostedProvider(a.Host.ToOption().ValueOrDefault(t))
               select tid;

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static ITypeIdentityProvider IdentityProvider(Type src)
            => TypeIdentities.provider(src, CreateProvider);

        static TypeIdentity DoDivination(Type arg)
            => default(TypeIdentityDiviner).DivineIdentity(arg);        

        static TypeIdentity PointerId(Type arg)
            => TypeIdentity.Define(text.concat(DoDivination(arg.Unwrap()), IDI.ModSep, IDI.Pointer));    

        static Option<TypeIndicator> SegIndicator(Type t)
        {
            if(t.IsBlocked())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else 
                return none<TypeIndicator>();
        }

        static Option<TypeIdentity> SegmentedId(Type t)
            =>  from i in SegIndicator(t)
                let segwidth = Identity.BitWidth(t)
                where segwidth.IsSome()
                let segfmt = segwidth.FormatValue()
                let arg = t.GetGenericArguments().Single()
                let argwidth = Identity.BitWidth(arg)
                where argwidth.IsSome()
                let argfmt = argwidth.FormatValue()
                let nk = arg.NumericKind()
                where  nk != 0
                let nki = nk.Indicator().Format()
                let identifer = concat(i, segfmt, IDI.SegSep,argfmt, nki)                
                select SegmentedIdentity.identify(i,segwidth,nk).AsTypeIdentity();

        static Option<TypeIdentity> NatId(Type arg)
            => from v in arg.NatValue() 
                let id = concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        static Option<TypeIdentity> SystemSpanId(Type arg)
        {
            var kind = SpanTypes.kind(arg);
            if(kind != 0 && kind != SpanKind.Custom)
            {
                var cellid = DoDivination(arg.GetGenericArguments().Single());
                return TypeIdentity.Define(text.concat(kind.Format(), cellid));
            }
            else
                return none<TypeIdentity>();
        }

        static Option<TypeIdentity> ArrayId(Type arg)
        {
            if(arg.IsArray)
            {
                var cellType = arg.GetElementType();
                var cellId = DoDivination(cellType);
                return TypeIdentity.Define(text.concat(IDI.Array, cellId));
            }
            else
                return none<TypeIdentity>();
        }

        /// <summary>
        /// Defines an identity for a type-natural span type
        /// </summary>
        /// <param name="src">The type to examin</param>
        static Option<TypeIdentity> NatSpanId(Type src)
        {
            if(IsNatSpan(src))
            {
                var typeargs = src.SuppliedTypeArgs();
                var text = IDI.NSpan;
                text += typeargs[0].NatValue();
                text += IDI.SegSep;
                text += typeargs[1].NumericKind().Format();
                return TypeIdentity.Define(text);
            }
            else
                return none<TypeIdentity>();
        }

        
        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(DoDivination);

        internal static ITypeIdentityProvider CreateProvider(Type t)
        {
            var provider = none<ITypeIdentityProvider>();   
            if(t.Tagged<IdentityProviderAttribute>())
                provider = AttributedProvider(t);
            else if(t.Reifies<ITypeIdentityProvider>())
                provider = HostedProvider(t);
            return provider.ValueOrElse(() => DefaultProvider);
        }

        readonly struct FunctionalProvider : ITypeIdentityProvider
        {     
            readonly Func<Type,TypeIdentity> f;
            
            [MethodImpl(Inline)]
            public FunctionalProvider(Func<Type, TypeIdentity> f)
                => this.f = f;
            
            [MethodImpl(Inline)]
            public TypeIdentity Identify(Type src)
                => f(src);
        }
    }
}