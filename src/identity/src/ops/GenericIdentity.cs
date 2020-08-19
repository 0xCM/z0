//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    partial class Identity
    {
        /// <summary>
        /// Assigns host-independent api member identity to a generic method; if the
        /// source method is nongeneric, returns <see cref='GenericOpIdentity.Empty' />
        /// </summary>
        /// <param name="src">The source method</param>
        public static GenericOpIdentity GenericIdentity(MethodInfo src)
        {
            if(!src.IsGenericMethod)
                return GenericOpIdentity.Empty;

            var id = Identify.ApiMemberName(src);
            id += IDI.PartSep;
            id += IDI.Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true);
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += IDI.PartSep;

                last = EmptyString;

                if(args[i].IsParametric())
                    last = Identity.ParameterTypeIdentity(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = text.concat(IDI.Vector, BitWidth(argtype).FormatValue());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, BitWidth(argtype).FormatValue());
                    else if(SpanTypes.IsSystemSpan(argtype))
                        last = SpanTypes.kind(argtype).Format();
                }

                id += last;
            }

            return GenericOpIdentity.Define(id);
        }
    }
}