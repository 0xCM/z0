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

    using static zfunc;

    partial class Identity
    {
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string host(Type t)
        {
            var defaultName = t.Name.ToLower();
            var query = from a in t.Tag<ApiHostAttribute>()
                        where a.HostName.IsNotBlank()
                        select a.HostName;
            return query.ValueOrDefault(defaultName);            
        }    

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");
        
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<ScalarIdentity> scalar(IdentityPart part)
        {
            var nk = part.PartKind == IdentityPartKind.Scalar ? Numeric.kind(part.Identifier) : NumericKind.None;
            if(nk.IsSome())
                return ScalarIdentity.Define(nk);                
            else                
                return none<ScalarIdentity>();                
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segmented(p)
                select s;

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> segmented(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(Z0.SegmentedIdentity.TryParse(part.Identifier, out var seg))
                    return seg;                
            }

            return none<SegmentedIdentity>();                
        }

        static Option<TypeIdentity> CommonId(this Type arg)
        {
            if(arg.IsPointer)
                return arg.PointerId();
            else if(arg.IsNat())
                return arg.NatId();
            else if(arg.IsSystemType())
                return arg.PrimalId();
            else if(arg.IsEnum)
                return arg.EnumId();
            else if(arg.IsSegmented())
                return arg.SegmentedId();
            else if(IsSpan(arg))
                return arg.SpanId();
            else if(arg.IsNatSpan())
                return arg.NatSpanId();  
            else           
                return none<TypeIdentity>();
        }

        static Option<TypeIdentity> PointerId(this Type arg)
            => from id in arg.Unwrap().CommonId()
                let idptr = text.concat(id, IDI.ModSep, IDI.Pointer)
                select TypeIdentity.Define(idptr);    

        static Option<TypeIdentity> SegmentedId(this Type t)
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
                let identifer = text.concat(i, segfmt, IDI.SegSep,argfmt, nki)                
                select SegmentedIdentity.Define(i,segwidth,nk).AsTypeIdentity();

        static Option<TypeIdentity> EnumId(this Type t)        
        {
            var id = EnumIdentity.From(t);
            return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        } 
                
        static Option<TypeIdentity> NatId(this Type arg)
            => from v in arg.NatValue() 
                let id = text.concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        static Option<TypeIdentity> PrimalId(this Type arg)
        {
            var id = PrimalIdentity.From(arg);
            return id.IsEmpty ? none<TypeIdentity>() : id.AsTypeIdentity();
        }

        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        static SpanKind SpanKind(this Type t)
            => t.GenericDefinition() == typeof(Span<>) ? Z0.SpanKind.Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) ? Z0.SpanKind.Immutable
              : 0;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        static bool IsSpan(this Type t)
            => t.SpanKind().IsSome();

        static Option<TypeIdentity> SpanId(this Type arg)
        {
            var kind = arg.SpanKind();
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

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        static ITypeIdentityProvider provider(Type src)
            => IdentityProviders.find(src, CreateProvider);

        static readonly ITypeIdentityProvider DefaultProvider
            = new FunctionalProvider(arg => arg.CommonId().ValueOrElse(() => TypeIdentity.Empty));

        /// <summary>
        /// Creates a type identity provider from a host type that realizes the required interface, if possible;
        /// otherwise, returns none
        /// </summary>
        /// <param name="host">A type that realizes an identity provider</param>
        static Option<ITypeIdentityProvider> FromHost(this Type host)
            => Root.Try(() => Activator.CreateInstance(host) as ITypeIdentityProvider);

        static Option<ITypeIdentityProvider> FromAttributed(this Type t)
            => from a in t.Tag<IdentityProviderAttribute>()
               from tid in  FromHost(a.Host.ValueOrDefault(t))
               select tid;

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