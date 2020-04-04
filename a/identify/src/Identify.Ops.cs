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
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        public static string imm8(byte immval)            
            => $"{IDI.SuffixSep}{IDI.Imm}{immval}";

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

        [MethodImpl(Inline)]
        public static OpIdentity Generialize(this GenericOpIdentity src)
            => Op(src.Identifier);
    }
}