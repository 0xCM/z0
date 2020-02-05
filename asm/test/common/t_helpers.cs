//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using static zfunc;

    public static class Helpers
    {

        /// <summary>
        /// Enables the generic indicator
        /// </summary>
        public static OpIdentity WithGeneric(this OpIdentity src)
        {
            if(src.TextComponents.Skip(1).First()[0] == IDI.Generic)
                return src;
            else
               return OpIdentity.Define(
                   concat(src.Identifier.LeftOf(IDI.PartSep), IDI.PartSep, IDI.Generic,  src.Identifier.RightOf(IDI.PartSep)));
        }

        /// <summary>
        /// Disables the generic indicator
        /// </summary>
        public static OpIdentity WithoutGeneric(this OpIdentity src)
        {
            var parts = src.Parts.ToArray();
            if(parts.Length < 2)
                return src;
            
            if(parts[1].Identifier[0] != IDI.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].Identifier.Substring(1));
            return parts;
        }

        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static OpIdentity WithAsm(this OpIdentity src)
        {
            if(src.Identifier.Contains(OpIdentity.AsmLocator))
                return src;
            else
                return OpIdentity.Define(src.Identifier + OpIdentity.AsmLocator);
        }            
    }
}
