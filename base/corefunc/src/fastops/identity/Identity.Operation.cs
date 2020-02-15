//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class Identity
    {
        /// <summary>
        /// Defines an operation identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_suffix} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null)
        {
            var g = generic ? $"{IDI.Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{IDI.SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return OpIdentity.Define(concat(opname, IDI.PartSep, IDI.Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}", suffixPart));
            else
                return OpIdentity.Define(concat($"{opname}_{g}{k.Format()}{suffixPart}"));
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k)
            => operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k, bool generic)
            => operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
        /// operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, NumericType<T> hk)
            where T : unmanaged
                => operation(opname,typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind nk)
            => operation(opname,w,nk,false);

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<IdentityPart>();
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segment(p)
                select s;

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        public static string imm8(byte immval)            
            => $"{IDI.SuffixSep}{IDI.Imm}{immval}";

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> imm8(OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return none<byte>();
        }

        /// <summary>        
        /// Clears an attached immediate suffix, if any
        /// </summary>
        public static OpIdentity imm8Remove(OpIdentity src)
            => imm8(src).MapValueOrDefault(immval => OpIdentity.Define(src.Identifier.Remove(imm8(immval))), src);

        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity imm8Add(OpIdentity src, byte immval)
              => OpIdentity.Define(concat(imm8Remove(src).Identifier, imm8(immval)));
    }
}