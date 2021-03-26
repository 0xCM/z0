//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class XApiId
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
                return ApiUri.opid(src.Identifier + IDI.AsmLocator);
        }
    }
}