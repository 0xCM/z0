//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> ExtractImm8(this OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.IdentityText.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return Option.none<byte>();
        }        
    }
}
