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
        /// Enables the generic indicator
        /// </summary>
        public static OpIdentity WithGeneric(this OpIdentity src)
        {
            if(src.TextComponents.Skip(1).First()[0] == IDI.Generic)
                return src;
            else
               return Identify.Op(
                   text.concat(src.IdentityText.LeftOf(IDI.PartSep), IDI.PartSep, IDI.Generic,  src.IdentityText.RightOf(IDI.PartSep)));
        }        
    }
}