//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    partial class XTend
    {
        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static OpIdentity WithAsm(this OpIdentity src)
        {
            if(src.IdentityText.Contains(IDI.AsmLocator))
                return src;
            else
                return Identify.Op(src.IdentityText + IDI.AsmLocator);
        }            
    }
}