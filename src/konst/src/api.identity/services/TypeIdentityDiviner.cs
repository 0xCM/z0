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

    using static Part;
    using static z;

    readonly struct TypeIdentityDiviner : ITypeIdentityDiviner
    {
        public TypeIdentity DivineIdentity(Type arg)
            => TryDivine(arg).ValueOrElse(() => TypeIdentity.define(arg.DisplayName()));

        public Option<TypeIdentity> TryDivine(Type arg)
        {
            if(arg.IsPointer)
                return PointerId(arg);
            else if(arg.IsTypeNat())
                return NatId(arg);
            else if(arg.IsSystemDefined())
                return ApiUri.primal(arg).AsTypeIdentity().ToOption();
            else if(arg.IsEnum)
                return some(EnumIdentity.define(arg).AsTypeIdentity());
            else if(arg.IsSegmented())
                return SegmentedId(arg);
            else if(arg.IsArray)
                return ArrayId(arg);
            else if(SpanTypes.IsSystemSpan(arg))
                return SystemSpanId(arg);
            else if(ApiIdentity.IsNatSpan(arg))
                return NatSpanId(arg);
            else
                return root.none<TypeIdentity>();
        }

        /// <summary>
        /// Retrieves a cached identity provider, if found; otherwise, creates and caches the identity provider for the source type
        /// </summary>
        /// <param name="t">The source type</param>
        [MethodImpl(Inline)]
        public static ITypeIdentityProvider IdentityProvider(Type src)
            => TypeIdentityProviders.create(src, DefaultProvider);

        static TypeIdentity DoDivination(Type arg)
            => default(TypeIdentityDiviner).DivineIdentity(arg);

        static TypeIdentity PointerId(Type arg)
            => TypeIdentity.define(text.concat(DoDivination(arg.Unwrap()), IDI.ModSep, IDI.Pointer));

        static Option<TypeIdentity> SegmentedId(Type t)
            =>  from i in ApiIdentity.SegIndicator(t)
                let segwidth = ApiIdentity.width(t)
                where segwidth.IsSome()
                let segFmt = segwidth.FormatValue()
                let arg = t.GetGenericArguments().Single()
                let argwidth = ApiIdentity.width(arg)
                where argwidth.IsSome()
                let argFmt = argwidth.FormatValue()
                let nk = arg.NumericKind()
                where  nk != 0
                let nki = nk.Indicator().Format()
                let identifer = text.concat(i, segFmt, IDI.SegSep, argFmt, nki)
                select SegmentedIdentity.define(i, segwidth, nk).AsTypeIdentity();

        static Option<TypeIdentity> NatId(Type arg)
            => from v in arg.NatValue()
                let id = text.concat(IDI.Nat, v.ToString())
                select TypeIdentity.define(id);

        static Option<TypeIdentity> SystemSpanId(Type arg)
        {
            var kind = SpanTypes.kind(arg);
            if(kind != 0 && kind != SpanKind.Custom)
            {
                var idCell = DoDivination(arg.GetGenericArguments().Single());
                return TypeIdentity.define(text.concat(kind.Format(), idCell));
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
                return TypeIdentity.define(text.concat(IDI.Array, Chars.Underscore, cellId));
            }
            else
                return none<TypeIdentity>();
        }

        /// <summary>
        /// Defines an identity for a type-natural span type
        /// </summary>
        /// <param name="src">The type to examine</param>
        static Option<TypeIdentity> NatSpanId(Type src)
        {
            if(ApiIdentity.IsNatSpan(src))
            {
                var typeargs = src.SuppliedTypeArgs();
                var text = IDI.NatSpan;
                text += typeargs[0].NatValue();
                text += IDI.SegSep;
                text += typeargs[1].NumericKind().Format();
                return TypeIdentity.define(text);
            }
            else
                return none<TypeIdentity>();
        }

        static readonly ITypeIdentityProvider DefaultProvider
            = new TypeIdentityProvider(DoDivination);

        // internal static ITypeIdentityProvider CreateProvider(Type t)
        // {
        //     var provider = none<ITypeIdentityProvider>();
        //     if(t.Tagged<IdentityProviderAttribute>())
        //         provider = TypeIdentityProviders.attributed(t);
        //     else if(t.Reifies<ITypeIdentityProvider>())
        //         provider = TypeIdentityProviders.hosted(t);
        //     return provider.ValueOrElse(() => DefaultProvider);
        // }
    }
}