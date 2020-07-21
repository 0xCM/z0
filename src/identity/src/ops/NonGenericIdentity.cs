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
        /// Assigns host-independent api member identity to a nongeneric method
        /// </summary>
        /// <param name="src">The source method</param>
        static OpIdentity NonGenericIdentity(MethodInfo src)
        {
            RequireNonGeneric(src);
            
            var id = EmptyString; 
            id += Identify.ApiMemberName(src);
            id += IDI.PartSep;
            id += SequenceIdentity(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, VaueParamIdentities(src));

            return OpIdentityParser.parse(id);
        }        
    }
}