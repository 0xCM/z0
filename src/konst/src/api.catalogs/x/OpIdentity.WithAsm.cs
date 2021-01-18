//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XApi
    {
        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        [Op]
        public static OpIdentity WithAsm(this OpIdentity src)
        {
            if(src.Identifier.Contains(IDI.AsmLocator))
                return src;
            else
                return OpIdentityParser.parse(src.Identifier + IDI.AsmLocator);
        }
    }
}