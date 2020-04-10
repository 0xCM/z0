//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
 
    using static Seed;
    
    public static partial class Identity
    {
        static OpIdentity nongeneric(MethodInfo src)
        {
            Claim.RequireNonGeneric(src);
            var id = string.Empty;
            
            id += OpIdentities.name(src);
            id += IDI.PartSep;
            id += FormatArgs(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, args(src));

            return Identify.Op(id);
        }        

        static string FormatArgs(object open, object close, char sep, IEnumerable<string> args)
            => text.concat(open, string.Join(sep,args), close);
    }
}