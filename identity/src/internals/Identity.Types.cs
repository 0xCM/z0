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

    using static Root;
    using static TypeIdentities;

    public interface ITypeIdentityDispatcher
    {
        Option<TypeIdentity> Dispatch(Type arg);
    }

    readonly struct TypeIdentityDispatcher : ITypeIdentityDispatcher
    {
        [MethodImpl(Inline)]
        public static ITypeIdentityDispatcher Create()
            => default(TypeIdentityDispatcher);

        public Option<TypeIdentity> Dispatch(Type arg)
        {
            if(arg.IsPointer)
                return PointerId(arg);
            else if(arg.IsNat())
                return NatId(arg);
            else if(arg.IsSystemType())
                return TypeIdentities.IdentifyPrimitive(arg);
            else if(arg.IsEnum)
                return EnumTypes.identify(arg).ToOption();
            else if(IsSegmented(arg))
                return SegmentedIdentity(arg);
            else if(TypeIdentities.IsSpan(arg))
                return SpanId(arg);
            else if(IsNatSpan(arg))
                return NatSpanId(arg);  
            else           
                return TypeIdentity.Define(arg.DisplayName());
        }

        internal static Option<TypeIdentity> PointerId(Type arg)
            => from id in arg.Unwrap().Dispatch()
                let idptr = text.concat(id, IDI.ModSep, IDI.Pointer)
                select TypeIdentity.Define(idptr);    

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        internal static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<IdentityPart>();
        }
        
        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        internal static Option<SegmentedIdentity> segmented(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(Z0.SegmentedIdentity.TryParse(part.Identifier, out var seg))
                    return seg;                
            }

            return none<SegmentedIdentity>();                
        }

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(Type t)
            => SegmentedTypes.test(t);

        internal static Option<TypeIdentity> SegmentedIdentity(Type t)
            => SegmentedTypes.identify(t);

        internal static Option<TypeIdentity> NatId(Type arg)
            => from v in arg.NatValue() 
                let id = text.concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        internal static Option<TypeIdentity> SpanId(Type arg)
        {
            var kind = SpanKind(arg);
            if(kind != 0)
            {
                var cellid = arg.GetGenericArguments().Single().Dispatch();
                return cellid.TryMap(id => TypeIdentity.Define(text.concat(kind.Format(), id)));
            }
            else
                return none<TypeIdentity>();
        }
                                
        internal static Option<TypeIndicator> SegIndicator(Type t)
        {
            if(t.IsBlocked())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else 
                return none<TypeIndicator>();
        }

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        internal static bool IsNatSpan(Type t)
            => NatSpan.test(t);

        /// <summary>
        /// Defines an identity for a type-natural span type
        /// </summary>
        /// <param name="src">The type to examin</param>
        internal static Option<TypeIdentity> NatSpanId(Type src)
        {
            if(IsNatSpan(src))
            {
                var typeargs = src.SuppliedTypeArgs().ToArray();                    
                var text = IDI.NSpan;
                text += typeargs[0].NatValue();
                text += IDI.SegSep;
                text += typeargs[1].NumericKind().Format();
                return TypeIdentity.Define(text);
            }
            else
                return none<TypeIdentity>();
        }

        internal static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(arg => arg.Dispatch().ValueOrElse(() => TypeIdentity.Empty));

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        internal static ITypeIdentityProvider provider(Type src)
            => IdentityProviders.find(src, CreateProvider);

        internal static ITypeIdentityProvider CreateProvider(Type t)
        {
            var provider = none<ITypeIdentityProvider>();   

            if(t.IsAttributed<IdentityProviderAttribute>())
                provider = TypeIdentities.AttributedProvider(t);
            else if(t.Realizes<ITypeIdentityProvider>())
                provider = TypeIdentities.HostedProvider(t);

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

    partial class Identity
    {
        internal static Option<TypeIdentity> Dispatch(this Type arg)
            => TypeIdentityDispatcher.Create().Dispatch(arg);
        
        // {
        //     if(arg.IsPointer)
        //         return PointerId(arg);
        //     else if(arg.IsNat())
        //         return NatId(arg);
        //     else if(arg.IsSystemType())
        //         return TypeIdentities.IdentifyPrimitive(arg);
        //     else if(arg.IsEnum)
        //         return TypeIdentities.IdentifyEnum(arg);
        //     else if(IsSegmented(arg))
        //         return SegmentedId(arg);
        //     else if(TypeIdentities.IsSpan(arg))
        //         return SpanId(arg);
        //     else if(IsNatSpan(arg))
        //         return NatSpanId(arg);  
        //     else           
        //         return TypeIdentity.Define(arg.DisplayName());
        // }

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        internal static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<IdentityPart>();
        }
        
        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        internal static Option<SegmentedIdentity> segmented(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(Z0.SegmentedIdentity.TryParse(part.Identifier, out var seg))
                    return seg;                
            }

            return none<SegmentedIdentity>();                
        }

        // /// <summary>
        // /// Returns true if the source type is intrinsic or blocked
        // /// </summary>
        // /// <param name="t">The type to examine</param>
        // [MethodImpl(Inline)]
        // public static bool IsSegmented(Type t)
        //     => t.IsBlocked() || t.IsVector();

        // internal static Option<TypeIdentity> PointerId(Type arg)
        //     => from id in arg.Unwrap().Dispatch()
        //         let idptr = text.concat(id, IDI.ModSep, IDI.Pointer)
        //         select TypeIdentity.Define(idptr);    

        // internal static Option<TypeIdentity> SegmentedId(Type t)
        //     =>  from i in SegIndicator(t)
        //         let segwidth = Identity.width(t)
        //         where segwidth.IsSome()
        //         let segfmt = segwidth.Format()
        //         let arg = t.GetGenericArguments().Single()
        //         let argwidth = Identity.width(arg)
        //         where   argwidth.IsSome()
        //         let argfmt = argwidth.Format()
        //         let nk = arg.NumericKind()
        //         where  nk.IsSome()                
        //         let nki = nk.Indicator().Format()
        //         let identifer = text.concat(i, segfmt, IDI.SegSep,argfmt, nki)                
        //         select SegmentedIdentity.Define(i,segwidth,nk).AsTypeIdentity();

        // internal static Option<TypeIdentity> NatId(Type arg)
        //     => from v in arg.NatValue() 
        //         let id = text.concat(IDI.Nat, v.ToString())
        //         select TypeIdentity.Define(id);
        
        // internal static Option<TypeIdentity> SpanId(Type arg)
        // {
        //     var kind = SpanKind(arg);
        //     if(kind != 0)
        //     {
        //         var cellid = arg.GetGenericArguments().Single().Dispatch();
        //         return cellid.TryMap(id => TypeIdentity.Define(text.concat(kind.Format(), id)));
        //     }
        //     else
        //         return none<TypeIdentity>();
        // }
                                
        // internal static Option<TypeIndicator> SegIndicator(Type t)
        // {
        //     if(t.IsBlocked())
        //         return TypeIndicator.Define(IDI.Block);
        //     else if(t.IsVector())
        //         return TypeIndicator.Define(IDI.Vector);
        //     else 
        //         return none<TypeIndicator>();
        // }

        // /// <summary>
        // /// Defines an identity for a type-natural span type
        // /// </summary>
        // /// <param name="src">The type to examin</param>
        // internal static Option<TypeIdentity> NatSpanId(Type src)
        // {
        //     if(IsNatSpan(src))
        //     {
        //         var typeargs = src.SuppliedTypeArgs().ToArray();                    
        //         var text = IDI.NSpan;
        //         text += typeargs[0].NatValue();
        //         text += IDI.SegSep;
        //         text += typeargs[1].NumericKind().Format();
        //         return TypeIdentity.Define(text);
        //     }
        //     else
        //         return none<TypeIdentity>();
        // }

        // internal static readonly ITypeIdentityProvider DefaultProvider
        //     = new FunctionalProvider(arg => arg.Dispatch().ValueOrElse(() => TypeIdentity.Empty));

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        internal static ITypeIdentityProvider provider(Type src)
            =>  TypeIdentityDispatcher.provider(src); 
             //IdentityProviders.find(src, CreateProvider);

        // /// <summary>
        // /// Determines whether a type is parametric over the natural numbers
        // /// </summary>
        // /// <param name="t">The type to examine</param>
        // internal static bool IsNatSpan(Type t)
        //     => NatSpan.test(t);

        // internal static ITypeIdentityProvider CreateProvider(Type t)
        // {
        //     var provider = none<ITypeIdentityProvider>();   

        //     if(t.IsAttributed<IdentityProviderAttribute>())
        //         provider = TypeIdentities.AttributedProvider(t);
        //     else if(t.Realizes<ITypeIdentityProvider>())
        //         provider = TypeIdentities.HostedProvider(t);

        //     return provider.ValueOrElse(() => DefaultProvider);
        // }

        // readonly struct FunctionalProvider : ITypeIdentityProvider
        // {     
        //     readonly Func<Type, TypeIdentity> f;
            
        //     [MethodImpl(Inline)]
        //     public FunctionalProvider(Func<Type, TypeIdentity> f)
        //         => this.f = f;
            
        //     [MethodImpl(Inline)]
        //     public TypeIdentity DefineIdentity(Type src)
        //         => f(src);
        // }
    }
}