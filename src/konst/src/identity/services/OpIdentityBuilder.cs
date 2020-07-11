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

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Konst;
    
    [ApiHost]
    public readonly struct OpIdentityBuilder
    {
        [Op]   
        public static OpIdentity build(params IdentityPart[] parts)
            => OpIdentityParser.parse(string.Join(IDI.PartSep, parts.Select(x =>x.Identifier)));

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]   
        public static OpIdentity build(string opname, TypeWidth tw, NumericKind k,  bool generic)
        {
            var w = (FixedWidth)tw;
            var g = generic ? $"{IDI.Generic}" : string.Empty;
            if(generic && k == NumericKind.None)
                return OpIdentityParser.parse(text.concat(opname, IDI.PartSep, IDI.Generic));
            else if(w.IsSome())
                return OpIdentityParser.parse(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}"));
            else
                return OpIdentityParser.parse(text.concat($"{opname}_{g}{k.Format()}"));
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
        public static OpIdentity build(OpKindId k, NumericKind nk, bool generic)
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

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity build<K>(string opname, K k, bool generic)
            where K : unmanaged, INumericKind
                => build(opname, TypeWidth.None, k.Class, generic);
    }
}