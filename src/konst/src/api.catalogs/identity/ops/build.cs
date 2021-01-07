//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiIdentify
    {
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
                return OpIdentityParser.parse(text.concat(opname, IDI.PartSep, IDI.Generic));
            else if(w.IsSome())
                return OpIdentityParser.parse(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}"));
            else
                return OpIdentityParser.parse(TextFormatter.concat($"{opname}_{g}{k.Format()}"));
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity build(string opname, NumericKind k, bool generic)
            => build(opname, TypeWidth.None, k, generic);

        [MethodImpl(Inline), Op]
        public static OpIdentity build(ApiClass k, NumericKind nk, bool generic)
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
                => build(opname, w.TypeWidth, Numeric.kind<T>(), true);
    }
}