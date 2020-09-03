//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    partial class XTend
    {
       /// <summary>
        /// Enables the generic indicator
        /// </summary>
        public static OpIdentity WithGeneric(this OpIdentity src)
        {
            if(src.TextComponents.Skip(1).First()[0] == IDI.Generic)
                return src;
            else
               return OpIdentityParser.parse(
                   text.concat(src.Identifier.LeftOf(IDI.PartSep), IDI.PartSep, IDI.Generic,  src.Identifier.RightOf(IDI.PartSep)));
        }        
    }
}