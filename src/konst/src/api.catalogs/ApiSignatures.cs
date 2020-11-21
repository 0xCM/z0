//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;
    using static z;
    using static IDI;

    using I = ApiIdentify;

    [ApiHost(ApiNames.Signatures, true)]
    public readonly partial struct ApiSignatures
    {
        static W256 W => default;

        /// <summary>
        /// Defines an identity part
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline), Op]
        public static ApiIdentityPart part(byte index, ApiIdentityPartKind kind, string text)
            => new ApiIdentityPart(index, kind, text);

        [Op]
        public static OpIdentity parse(string src)
        {
            if(text.empty(src))
                return OpIdentity.Empty;

            var name = src.TakeBefore(PartSep);
            var suffixed = src.Contains(SuffixSep);
            var suffix = suffixed ? src.TakeAfter(IDI.SuffixSep) : EmptyString;
            var generic = src.TakeAfter(PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = src.SplitClean(PartSep);
            var id = OpIdentity.define(src, name, suffix, generic, imm, components);
            return id;
        }

        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwise, returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        [Op]
        public static OpIdentity[] duplicates(OpIdentity[] src)
        {
            var index = new Dictionary<OpIdentity,int>();
            var distinct = src.ToHashSet();
            if(distinct.Count != src.Count())
            {
                foreach(var id in src)
                {
                    if(index.TryGetValue(id, out var count ))
                        index[id] = ++count;
                    else
                        index[id] = 1;
                }
            }

            return (from kvp in index where kvp.Value > 1 select kvp.Key).ToArray();
        }

        /// <summary>
        /// Defines an identity, bypassing validation
        /// </summary>
        /// <param name="src">The identity text</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity define(string src)
            => OpIdentity.define(src);

        /// <summary>
        /// Defines an operation identifier with all aspects explicitly specified
        /// </summary>
        /// <param name="text">The identity text</param>
        /// <param name="name">The operation name</param>
        /// <param name="suffix">The operaion suffix</param>
        /// <param name="generic">The operation's generic status</param>
        /// <param name="imm">Specifies whether the operation requires one or more immediate values</param>
        /// <param name="components">The identity components</param>
        [Op]
        public static OpIdentity define(string text, string name, string suffix, bool generic, bool imm, string[] components)
            => new OpIdentity(text, name, suffix, generic, imm, components);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        [Op]
        public static OpIdentity vsfunc(ApiClass k, TypeWidth w, NumericKind nk, bool generic = true)
            => I.build(I.vname(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector width</param>
        /// <param name="nk">The cell numeric kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vsfunc<T>(ApiClass k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => I.build(I.vname(k), w, nk<T>(), generic);

        /// <summary>
        /// Produces an identifier for a kinded vectorized structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A vector width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="W">The vector width type</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vsfunc<W,T>(ApiClass k, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => I.build(I.vname(k), w.TypeWidth, nk<T>(), generic);

        [MethodImpl(Inline), Op]
        public static ApiIdentityToken token(OpIdentity src)
            => ApiIdentityTokens.dispense(src);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc<T>(ApiClass k, TypeWidth w, T t = default, bool generic = true)
            where T : unmanaged
                => I.build(I.name(k), w, nk<T>(), generic);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="W">The width type</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<W,T>(ApiClass k, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => I.build(I.name(k), w.TypeWidth, nk<T>(), generic);

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static OpIdentity sfunc<T>(ApiClass k, T t = default)
            where T : unmanaged
                => NumericOp(name(k), nk<T>());

        /// <summary>
        /// Produces an identifier for a kinded numeric structural function
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="nk">The operation numeric kind</param>
        public static OpIdentity sfunc(ApiClass k, NumericKind nk)
            => NumericOp(name(k), nk);

        /// <summary>
        /// Produces an identifier for a kinded structural function of segmented type
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">A segment width representative</param>
        /// <param name="t">A cell type representative</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        public static OpIdentity sfunc(ApiClass k, TypeWidth w, NumericKind nk, bool generic = true)
            => I.build(I.name(k), w, nk, generic);

        /// <summary>
        /// Defines kinded identifiers for nongeneric numeric functions
        /// </summary>
        /// <param name="id">The operation kind id</param>
        /// <param name="kinds">The numeric argument kinds</param>
        [Op]
        public static OpIdentity NumericOp(ApiClass id, params NumericKind[] kinds)
            => I.NumericOp(id,false,kinds);

        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline), Op]
        public static NumericIdentity numeric(NumericKind nk)
            => TypeIdentity.numeric(nk);

        /// <summary>
        /// Produces an identifer for a kinded numeric operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        /// <typeparam name="T">The operation numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static OpIdentity numeric<T>(ApiClass k, T t = default, bool generic = false)
            where T : unmanaged
                => I.NumericOp<T>(I.name(k),  generic);

        [Op]
        public static Option<ApiIdentityPart> component(OpIdentity src, int index)
        {
            var parts = components(src).ToArray();
            if(index <= parts.Length - 1)
                return parts[index];
            else
                return none<ApiIdentityPart>();
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="index">The 0-based part index</param>
        public static Option<SegmentedIdentity> segmented(OpIdentity src, int index)
            => from p in component(src, index)
                from s in identify(p)
                select s;
        [Op]
        public static Option<SegmentedIdentity> identify(ApiIdentityPart part)
        {
            if(part.IsSegment && parse(part.Identifier, out var seg))
                return seg;
            else
                return none<SegmentedIdentity>();
        }

        [Op]
        public static bool parse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = TypeIndicator.Define(src[0]);
            var start = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(char.IsDigit(src[i]))
                {
                    start = i;
                    break;
                }
            }

            var parts = text.split(text.slice(src,start), IDI.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];

                var sText = part0[0]
                    == IDI.Generic
                    ? text.slice(part0, 1, part0.Length - 1)
                    : part0;

                if(uint.TryParse(sText, out var n))
                {
                    if(Enum.IsDefined(typeof(CellWidth),n))
                    {
                        var bText = text.slice(part1,0, part1.Length - 1);
                        if(uint.TryParse(bText, out var by))
                        {
                            if(Enum.IsDefined(typeof(CellWidth), by))
                            {
                                dst = SegmentedIdentity.define(indicator, (CellWidth)n, ((NumericWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Defines a segmented type identity predicated on type width numeric kind specifications
        /// </summary>
        /// <param name="name">The type name</param>
        /// <param name="wk">The width kind</param>
        /// <param name="nk">The numeric kind</param>
        [Op]
        public static TypeIdentity segmented(string name, TypeWidth wk, NumericKind nk)
            => new TypeIdentity($"{name}{wk.FormatValue()}x{nk.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [Op]
        public static TypeIdentity resource(string basename, ITypeWidth w, NumericKind kind)
            => new TypeIdentity($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [Op]
        public static TypeIdentity resource(string basename, ITypeWidth w1, ITypeWidth w2, NumericKind kind)
            => new TypeIdentity($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [Op]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => new TypeIdentity($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a type resource identity
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [Op]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => new TypeIdentity($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Produces an identifier for a kinded generic vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vgeneric<W,T>(ApiClass k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                => I.build(I.vname(k), w.TypeWidth, nk<T>(), true);

        /// <summary>
        /// Produces an identifier for a kinded vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <param name="nk">The vector cell kind</param>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        [Op]
        public static OpIdentity vectorized(ApiClass k, TypeWidth w, NumericKind nk, bool generic)
            => I.build(I.vname(k), w, nk, generic);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static OpIdentity vdirect<T>(ApiClass k, TypeWidth w, T t = default)
            where T : unmanaged
                => I.build(I.vname(k), w, I.nk(t), false);

        /// <summary>
        /// Produces an identifier for a kinded nongeneric vectorized operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="w">The vector operand width</param>
        /// <typeparam name="W">The vector operand width</typeparam>
        /// <typeparam name="T">The vector cell type</typeparam>
        public static OpIdentity vdirect<W,T>(ApiClass k, W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeWidth
                =>  I.build(I.vname(k), w.TypeWidth, I.nk(t), false);

        /// <summary>
        /// Produces an identifer for a kinded numeric operation
        /// </summary>
        /// <param name="k">The operation kind id</param>
        /// <param name="nk">The operation numeric kind</typeparam>
        /// <param name="generic">Whether the produced identity has a generic marker</param>
        [Op]
        public static OpIdentity numeric(ApiClass k,  NumericKind nk, bool generic = false)
            => I.NumericOp(I.name(k), nk, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static OpIdentity NumericOp<T>(string opname, NK<T> k, bool generic)
            where T : unmanaged
                => I.build(opname, TypeWidth.None, k, generic);

        [Op]
        public static IEnumerable<ApiIdentityPart> components(OpIdentity src)
        {
               var parts = ComponentText(src).ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {
                   var part = parts[i];
                   var partkind = ApiIdentityPartKind.None;

                   if(i == 0)
                        partkind = ApiIdentityPartKind.Name;
                    else
                    {
                        if(part.Contains(IDI.SegSep))
                            partkind = ApiIdentityPartKind.Segment;
                        else
                        {
                            if(i == 1 && part[0] == IDI.Generic && Char.IsDigit(part.TakeAfter(IDI.Generic).First()))
                                partkind = ApiIdentityPartKind.Numeric;
                            else if(Char.IsDigit(part.First()))
                                partkind = ApiIdentityPartKind.Numeric;
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = SuffixText(src).ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return part(i, ApiIdentityPartKind.Suffix, suffixes[j]);
        }

        [Op]
        public static OpIdentity build(params ApiIdentityPart[] parts)
            => OpIdentityParser.parse(string.Join(IDI.PartSep, parts.Select(x =>x.Identifier)));

        /// <summary>
        /// Disables the generic indicator
        /// </summary>
        [Op]
        static OpIdentity WithoutGeneric(OpIdentity src)
        {
            var parts = components(src).ToArray();
            if(parts.Length < 2)
                return src;

            if(parts[1].Identifier[0] != IDI.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].Identifier.Substring(1));
            return build(parts);
        }

        [Op]
        static IEnumerable<string> SuffixText(OpIdentity src)
        {
            if(src.Identifier.Contains(IDI.SuffixSep))
            {
                var suffixes = src.Identifier.TakeAfter(IDI.SuffixSep);
                if(!string.IsNullOrWhiteSpace(suffixes))
                {
                    var seperated = suffixes.Split(IDI.SuffixSep, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var suffix in seperated)
                        yield return suffix;
                }
            }
        }

       [Op]
       static IEnumerable<string> ComponentText(OpIdentity src)
        {
            var parts = (src.Identifier.Contains(IDI.SuffixSep)
            ? src.Identifier.TakeBefore(IDI.SuffixSep)
            : src.Identifier).Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            {
                foreach(var part in parts)
                    yield return part;
            }
        }
    }
}