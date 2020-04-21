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
        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        static void RequireNonGeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        static OpIdentity nongeneric(MethodInfo src)
        {
            RequireNonGeneric(src);
            var id = string.Empty;
            
            id += Identify.Name(src);
            id += IDI.PartSep;
            id += FormatArgs(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, args(src));

            return Identify.Op(id);
        }        

        static string FormatArgs(object open, object close, char sep, IEnumerable<string> args)
            => text.concat(open, string.Join(sep,args), close);
    }
}