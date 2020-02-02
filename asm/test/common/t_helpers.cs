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
        public static Moniker WithGeneric(this Moniker src)
        {
            if(src.TextComponents.Skip(1).First()[0] == Moniker.Generic)
                return src;
            else
               return Moniker.Parse(
                   concat(src.Text.LeftOf(Moniker.PartSep), Moniker.PartSep, Moniker.Generic,  src.Text.RightOf(Moniker.PartSep)));
        }

        /// <summary>
        /// Disables the generic indicator
        /// </summary>
        public static Moniker WithoutGeneric(this Moniker src)
        {
            var parts = src.Parts.ToArray();
            if(parts.Length < 2)
                return src;
            
            if(parts[1].PartText[0] != Moniker.Generic)
                return src;

            parts[1] = parts[1].WithText(parts[1].PartText.Substring(1));
            return parts;
        }

        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static Moniker WithAsm(this Moniker src)
        {
            if(src.Text.Contains(Moniker.AsmLocator))
                return src;
            else
                return Moniker.Parse(src.Text + Moniker.AsmLocator);
        }            
    }
}
