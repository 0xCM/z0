//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static ApiUriDelimiters;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct ApiIdentityBuilder
    {
        [MethodImpl(Inline), Op]
        public static ApiClassKind klass(MethodInfo src)
        {
            if(src.Tag<OpKindAttribute>(out var dst))
                return dst.ClassId;
            else
                return 0;
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp(string opname, NumericKind k, bool generic = false)
            => build(opname, TypeWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static OpIdentity NumericOp<T>(string opname, bool generic = true)
            where T : unmanaged
                => build(opname, TypeWidth.None, NumericKinds.kind<T>(), generic);

        public static string name<W,C>(Type host, string label, bool generic)
            where W : unmanaged, ITypeWidth
            where C : unmanaged
                => $"{PartName.from(host)}/{host.Name}{UriPathSep}{build(label, default(W).TypeWidth, NumericKinds.kind<C>(), generic)}";

        /// <summary>
        /// Produces a test case identifier predicated on a parametrically-specialized label
        /// <param name="label">The case label</param>
        /// <typeparam name="T">The label specialization type</typeparam>
        public static OpIdentity NumericId<T>([Caller] string label = null)
            where T : unmanaged
                => numeric($"{label}", typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity numeric(string opname, NumericKind k, bool generic = false)
            => build(opname, TypeWidth.None, k, generic);

        public static OpIdentity kind<K,T>(K kind, T t = default)
            where K : unmanaged
            where T : unmanaged
                => build(kind.ToString().ToLower(), (TypeWidth)memory.width<T>(), NumericKinds.kind<T>(), true);

        public static OpIdentity klass<K,T>(K @class, T t = default)
            where K : unmanaged, IApiClass
            where T : unmanaged
                => build(@class.Format(), (TypeWidth)memory.width<T>(), NumericKinds.kind<T>(), true);

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [Op]
        public static OpIdentity build(string opname, TypeWidth tw, NumericKind k,  bool generic)
        {
            var w = (CellWidth)tw;
            var g = generic ? $"{IDI.Generic}" : EmptyString;
            if(generic && k == 0)
                return ApiUri.opid(text.concat(opname, IDI.PartSep, IDI.Generic));
            else if(w.IsSome())
                return ApiUri.opid(text.concat(opname, IDI.PartSep, $"{g}{w.FormatValue()}{IDI.SegSep}{k.Format()}"));
            else
                return ApiUri.opid(text.concat($"{opname}_{g}{k.Format()}"));
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [Op]
        public static OpIdentity build(string opname, NumericKind k, bool generic)
            => build(opname, TypeWidth.None, k, generic);

        [Op]
        public static OpIdentity build(ApiClassKind k, NumericKind nk, bool generic)
            => build(k.Format(), nk, generic);

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static OpIdentity build<W,T>(string opname, W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => build(opname, w.TypeWidth, NumericKinds.kind<T>(), true);
    }
}