//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    partial class XApi
    {
       /// <summary>
        /// Enables the generic indicator
        /// </summary>
        [Op]
        public static OpIdentity WithGeneric(this OpIdentity src)
        {
            if(src.Components.Skip(1).First()[0] == IDI.Generic)
                return src;
            else
               return OpIdentityParser.parse(
                   text.concat(src.Identifier.LeftOfFirst(IDI.PartSep), IDI.PartSep, IDI.Generic,  src.Identifier.RightOfFirst(IDI.PartSep)));
        }
    }
}