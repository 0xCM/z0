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

    using static Root;

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
                return OpIdentity.Define(text.concat(opname, IDI.PartSep, IDI.Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}", suffixPart));
            else
                return OpIdentity.Define(text.concat($"{opname}_{g}{k.Format()}{suffixPart}"));
        }

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

    }
}