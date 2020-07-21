//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    
    public static partial class Identity
    {        
        /// <summary>
        /// Assigns host-independent api identity to a constructed generic method
        /// </summary>
        /// <param name="src">The constructed method</param>
        static OpIdentity ConstructedIdentity(MethodInfo src)
        {
            RequireConstructed(src);
            
            var id = EmptyString;            
            id += Identify.ApiMemberName(src);
            id += IDI.PartSep;   
            id += IDI.Generic;                           
            id += TypeArgIdentity(src);
            id += ValueParamIdentity(src);
            return OpIdentityParser.parse(id);
        }                
    }
}