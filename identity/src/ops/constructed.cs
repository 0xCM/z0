//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    
    public static partial class Identity
    {
        static OpIdentity constructed(MethodInfo src)
        {
            Claim.RequireConstructed(src);

            static string ParamIdentity(MethodInfo src)
                => FormatArgs(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, args(src));

            static IEnumerable<string> TypeArgIdentities(MethodInfo src)
                => src.GenericArguments().Select(targ => Identity.identify(targ).Identifier);

            static string TypeArgIdentity(MethodInfo src)
                => FormatArgs(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, TypeArgIdentities(src));

            
            var id = string.Empty;
            
            id += OpIdentities.name(src);
            id += IDI.PartSep;   

            id += IDI.Generic;                           
            id += TypeArgIdentity(src);
            id += ParamIdentity(src);
            return Identify.Op(id);
        }                
    }
}