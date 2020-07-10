//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> ExtractImm8(this OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return Option.none<byte>();
        }        
    }
}