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

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    partial class Identity
    {
        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(this Type t)
            => t.GenericDefinition() == typeof(Span<>) ? Z0.SpanKind.Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) ? Z0.SpanKind.Immutable
              : 0;


        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(this Type t)
        {
            var query =    
                from def in t.GenericDefinition() 
                where def == typeof(NatSpan<,>) && t.IsClosedGeneric()
                select def;

            return query.IsSome();            
        }

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t)
            => t.SpanKind().IsSome();


        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        /// <summary>
        /// Produces an identifier of the form {width(nk)}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity identify(NumericKind nk)
            => TypeIdentity.Define(nk.Format());

        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");
        
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numericid<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());

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
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<SegmentedIdentity> segment(IdentityPart part)
        {
            if(part.PartKind == IdentityPartKind.Segment)
            {
                if(Z0.SegmentedIdentity.TryParse(part.Identifier, out var seg))
                    return seg;                
            }

            return none<SegmentedIdentity>();                
        }

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        static ITypeIdentityProvider provider(Type src)
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
            =>  TypeIdentity.Define($"{t.Name}{IDI.ModSep}{t.GetEnumUnderlyingType().NumericKind().Format()}");
                
        static Option<TypeIdentity> NatIdentity(this Type arg)
            => from v in arg.NatValue() 
                let id = concat(IDI.Nat, v.ToString())
                select TypeIdentity.Define(id);
        
        static Option<TypeIdentity> PrimalIdentity(this Type arg)
        {
            if(arg.IsNumeric())
                return TypeIdentity.Define(arg.NumericKind().Format());
            else if(arg.IsPrimalNonNumeric())
                return TypeIdentity.Define(arg.PrimitiveKeyword());
            else
                return none<TypeIdentity>();
        }

        [MethodImpl(Inline)]
        static T MapSomeOrElse<T>(this SpanKind kind, Func<SpanKind,T> ifSome, Func<T> ifNone)
            => kind.IsSome() ? ifSome(kind) : ifNone();

        [MethodImpl(Inline)]
        static Option<(SpanKind kind, Type celltype)> SpanInfo(this Type arg)
            => arg.SpanKind().MapSomeOrElse(
                  k => (k, arg.GetGenericArguments().Single()), 
                 () => none<(SpanKind, Type)>());

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
                text += typeargs[1].NumericKind().Format();
                return TypeIdentity.Define(text);
            }
            else
                return none<TypeIdentity>();
        }

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