//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Seed;

    partial class Identity
    {
        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static GenericOpIdentity generic(MethodInfo src)            
        {
            if(!src.IsGenericMethod)
                return GenericOpIdentity.Empty;
                        
            var id = name(src);
            id += IDI.PartSep; 
            id += IDI.Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true).ToArray();
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += IDI.PartSep;

                last = string.Empty;                    

                if(args[i].IsParametric())
                    last = Identity.identify(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = text.concat(IDI.Vector, divine(argtype).FormatValue());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, divine(argtype).FormatValue());
                    else if(SpanTypes.IsSystemSpan(argtype))
                        last = SpanTypes.kind(argtype).Format();
                }
                
                id += last;
            }

            return GenericOpIdentity.Define(id);
        }
    }
}