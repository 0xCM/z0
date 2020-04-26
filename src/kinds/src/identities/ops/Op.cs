//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    partial class Identify
    {
        public static string vName(OpKindId kind)
            => $"v{kind.Format()}";

        public static string name(OpKindId kind)
            => kind.Format();

        public static IdentifiedMethod vIdentify<T>(MethodInfo src, OpKindId kind, W128 w)
            where T : unmanaged
                =>  (Identify.Op(vName(kind), TypeWidth.W128, typeof(T).NumericKind(), true), src);

        public static IdentifiedMethod vIdentify<T>(MethodInfo src, OpKindId kind, W256 w)
            where T : unmanaged
                =>  (Identify.Op(vName(kind), TypeWidth.W256, typeof(T).NumericKind(), true), src);

        public static OpIdentity Op(string src)
        {
            var id = src ?? 0.ToString();
            var name = id.TakeBefore(IDI.PartSep);
            var suffixed = id.Contains(IDI.SuffixSep);
            var suffix = suffixed ? id.TakeAfter(IDI.SuffixSep) : string.Empty;
            var generic = id.TakeAfter(IDI.PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = id.Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            return OpIdentity.Define(id, name, suffix, generic, imm, components);
        }

        public static OpIdentity Op(params IdentityPart[] parts)
            => Op(string.Join(IDI.PartSep, parts.Select(x =>x.Identifier)));

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity Op(string opname, TypeWidth tw, NumericKind k,  bool generic)
        {
            var w = (FixedWidth)tw;
            var g = generic ? $"{IDI.Generic}" : string.Empty;
            if(generic && k == NumericKind.None)
                return Op(text.concat(opname, IDI.PartSep, IDI.Generic));
            else if(w.IsSome())
                return Op(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}"));
            else
                return Op(text.concat($"{opname}_{g}{k.Format()}"));
        }

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity Op<W,T>(string opname, W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => Op(opname, w.TypeWidth, NumericKinds.kind<T>(), true);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity Op<K>(string opname, K k, bool generic)
            where K : unmanaged, INumericKind
                => Op(opname, TypeWidth.None, k.Class, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity Op(string opname, NumericKind k, bool generic)
            => Op(opname, TypeWidth.None, k, generic);
    }
}