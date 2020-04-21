//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
        
    partial class XTend
    {
        /// <summary>
        /// Enables the assembly indicator
        /// </summary>
        public static OpIdentity WithAsm(this OpIdentity src)
        {
            if(src.Identifier.Contains(IDI.AsmLocator))
                return src;
            else
                return Identities.Op(src.Identifier + IDI.AsmLocator);
        }            
    }
}