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

    partial class Identity
    {
        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<IdentityPart>();
        }

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        static Option<NumericIdentity> scalar(IdentityPart part)
        {
            var nk = part.PartKind == IdentityPartKind.Scalar ? NumericIdentity.kind(part.Identifier) : NumericKind.None;
            if(nk.IsSome())
                return NumericIdentity.Define(nk);                
            else                
                return none<NumericIdentity>();                
        }
        
        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        static Option<SegmentedIdentity> segmented(IdentityPart part)
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
        public static bool IsSegmented(this Type t)
            => t.IsBlocked() || t.IsVector();

        static Option<TypeIdentity> CommonId(this Type arg)
        {
            if(arg.IsPointer)
                return arg.PointerId();
            else if(arg.IsNat())
                return arg.NatId();
            else if(arg.IsSystemType())
                return TypeIdentities.IdentifyPrimitive(arg);
            else if(arg.IsEnum)
                return TypeIdentities.IdentifyEnum(arg);
            else if(arg.IsSegmented())
                return arg.SegmentedId();
            else if(TypeIdentities.IsSpan(arg))
                return arg.SpanId();
            else if(arg.IsNatSpan())
                return arg.NatSpanId();  
            else           
                return TypeIdentity.Define(arg.DisplayName());
        }

        static Option<TypeIdentity> PointerId(this Type arg)
            => from id in arg.Unwrap().CommonId()
                let idptr = text.concat(id, IDI.ModSep, IDI.Pointer)
                select TypeIdentity.Define(idptr);    

        static Option<TypeIdentity> SegmentedId(this Type t)
            =>  from i in t.SegIndicator()
                let segwidth = Identity.width(t)
                where segwidth.IsSome()
                let segfmt = segwidth.Format()
                let arg = t.GetGenericArguments().Single()
                let argwidth = Identity.width(arg)
                where   argwidth.IsSome()
                let argfmt = argwidth.Format()
                let nk = arg.NumericKind()
                where  nk.IsSome()                
                let nki = nk.Indicator().Format()
                let identifer = text.concat(i, segfmt, IDI.SegSep,argfmt, nki)                
                select SegmentedIdentity.Define(i,segwidth,nk).AsTypeIdentity();

        // static Option<TypeIdentity> EnumId(this Type t)        
        // {
        //     var id = EnumIdentity.From(t);
        //     return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        // } 
                
        static Option<TypeIdentity> NatId(this Type arg)
            => from v in arg.NatValue() 
                let id = text.concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        // static Option<TypeIdentity> PrimalId(this Type arg)
        // {
        //     var id = PrimalIdentity.From(arg);
        //     return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        // }


        static Option<TypeIdentity> SpanId(this Type arg)
        {
            var kind = SpanKind(arg);
            if(kind.IsSome())
            {
                var cellid = arg.GetGenericArguments().Single().CommonId();
                return cellid.TryMap(id => TypeIdentity.Define(text.concat(kind.Format(), id)));
            }
            else
                return none<TypeIdentity>();
        }
                                
        static Option<TypeIndicator> SegIndicator(this Type t)
        {
            if(t.IsBlocked())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else 
                return none<TypeIndicator>();
        }

        /// <summary>
        /// Defines an identity for a type-natural span type
        /// </summary>
        /// <param name="src">The type to examin</param>
        static Option<TypeIdentity> NatSpanId(this Type src)
        {
            if(src.IsNatSpan())
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

        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(arg => arg.CommonId().ValueOrElse(() => TypeIdentity.Empty));


        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        static ITypeIdentityProvider provider(Type src)
            => IdentityProviders.find(src, CreateProvider);


        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        static bool IsNatSpan(this Type t)
            => NatSpan.@is(t);

        static ITypeIdentityProvider CreateProvider(this Type t)
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
}