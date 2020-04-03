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
    using System.Reflection;

    using static Seed;
        
    partial class Identify
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

        public static OpIdentity Op(string src)
        {
            var id = src ?? 0.ToString();
            var name = id.TakeBefore(IDI.PartSep);
            var suffixed = id.Contains(IDI.SuffixSep);
            var suffix = suffixed ? id.TakeAfter(IDI.SuffixSep) : string.Empty;
            var generic = id.TakeAfter(IDI.PartSep)[0] == IDI.Generic;
            var imm = suffix.Contains(IDI.Imm);
            var components = id.Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            return Z0.OpIdentity.Define(id, name, suffix, generic, imm, components);
        }

        public static OpIdentity Op(params IdentityPart[] parts)
            => Op(string.Join(IDI.PartSep, parts.Select(x =>x.Identifier)));

        /// <summary>
        /// Defines an operation identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_suffix} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        static OpIdentity Op(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null)
        {
            var g = generic ? $"{IDI.Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{IDI.SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return Op(text.concat(opname, IDI.PartSep, IDI.Generic, suffixPart));            
            else if(w.IsSome())
                return Op(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}", suffixPart));
            else
                return Op(text.concat($"{opname}_{g}{k.Format()}{suffixPart}"));
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
        public static OpIdentity Op(string opname, TypeWidth w, NumericKind k,  bool generic, string suffix = null)
            => Op(opname,(FixedWidth)w, k, generic,suffix);                

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
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<W,T>(string opname, W w = default, T t = default, bool generic = true)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => Identify.Op(opname, (TypeWidth)TypeNats.value<W>(), NumericKinds.kind<T>(), generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity NumericOp(string opname, NumericKind k, bool generic)
            => Op(opname, TypeWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity NumericOp(string opname, NumericKind k)
            => Op(opname, TypeWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity NumericOp<T>(string opname, NK<T> hk = default, bool generic = true)
            where T : unmanaged
                => Op(opname, TypeWidth.None, typeof(T).NumericKind(), generic);       

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity SFunc<T>(string opname)
            => NumericOp(opname, typeof(T).NumericKind());

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity SFunc<T>(string opname, Vec128Kind<T> k)
            where T : unmanaged
                => Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity SFunc<T>(string opname, Vec256Kind<T> k)
            where T : unmanaged
                => Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwise, returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        public static OpIdentity[] Duplicates(IEnumerable<OpIdentity> src)
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
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        static string imm8(byte immval)            
            => $"{IDI.SuffixSep}{IDI.Imm}{immval}";

        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
              => Identify.Op(text.concat(src.WithoutImm8().Identifier, imm8(immval)));

       /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> Imm8(this OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return Option.none<byte>();
        }

        /// <summary>        
        /// Clears an attached immediate suffix, if any
        /// </summary>
        public static OpIdentity WithoutImm8(this OpIdentity src)
        {
            var perhaps = src.Imm8();
            if(!perhaps)   
                return src;
            return Identify.Op(src.Identifier.Remove(imm8(perhaps.Value)));
        }

        /// <summary>
        /// Enables the generic indicator
        /// </summary>
        public static OpIdentity WithGeneric(this OpIdentity src)
        {
            if(src.TextComponents.Skip(1).First()[0] == IDI.Generic)
                return src;
            else
               return Identify.Op(
                   text.concat(src.Identifier.LeftOf(IDI.PartSep), IDI.PartSep, IDI.Generic,  src.Identifier.RightOf(IDI.PartSep)));
        }

        /// <summary>
        /// Disables the generic indicator
        /// </summary>
        public static OpIdentity WithoutGeneric(this OpIdentity src)
        {
            var parts = Identify.Parts(src).ToArray();
            if(parts.Length < 2)
                return src;
            
            if(parts[1].Identifier[0] != IDI.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].Identifier.Substring(1));
            return Identify.Op(parts);
        }

        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static OpIdentity WithAsm(this OpIdentity src)
        {
            if(src.Identifier.Contains(OpIdentity.AsmLocator))
                return src;
            else
                return Identify.Op(src.Identifier + OpIdentity.AsmLocator);
        }            

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

        static IEnumerable<string> PartText(OpIdentity src)
        {
            var parts = (src.Identifier.Contains(IDI.SuffixSep) 
            ? src.Identifier.TakeBefore(IDI.SuffixSep) 
            : src.Identifier).Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            {
                foreach(var part in parts)
                    yield return part;                     
            }
        }

        public static Option<IdentityPart> Part(OpIdentity src, int partidx)
        {
            var parts = Identify.Parts(src).ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return Option.none<IdentityPart>();
        }

        [MethodImpl(Inline)]
        public static OpIdentity Generialize(this GenericOpIdentity src)
            => Op(src.Identifier);

        public static IEnumerable<IdentityPart> Parts(OpIdentity src)
        {
               var parts = PartText(src).ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {                   
                   var part = parts[i];
                   var partkind = IdentityPartKind.None;

                   if(i == 0)
                        partkind = IdentityPartKind.Name;
                    else
                    {
                        if(part.Contains(IDI.SegSep))
                            partkind = IdentityPartKind.Segment;
                        else
                        {
                            if(i == 1 && part[0] == IDI.Generic && Char.IsDigit(part.TakeAfter(IDI.Generic).First()))
                                partkind = IdentityPartKind.Numeric;
                            else if(Char.IsDigit(part.First()))
                                partkind = IdentityPartKind.Numeric;                                
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = SuffixText(src).ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, IdentityPartKind.Suffix, suffixes[j]);
        }
    }
}