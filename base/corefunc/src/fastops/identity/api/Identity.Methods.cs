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

    using static zfunc;
    using static OpIdentity;

    partial class Identity
    {
        public static string identify(ParameterInfo p)
        {
            var pt = p.ParameterType;
            if(!p.IsParametric())
            {
                var id = Identity.identify(pt.EffectiveType());
                if(!id.IsEmpty)
                    return concat(id.Identifier, p.Variance().Format());                
            }
            return string.Empty;                        
        }

        public static IEnumerable<string> parameters(MethodInfo method)
        {
            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = identify(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        public static string name(MethodInfo m)
        {
            var attrib = m.CustomAttribute<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;
        
            var sep = AsciSym.Tilde;
            var attribVal = attrib.Value;  
            var customName = attribVal.Name;
            var combine = attribVal.CombineCustomName;
            
            var name = string.Empty;

            if(customName.IsNotBlank())
            {
                name += customName;

                if(combine)
                {
                    name += sep;
                    name += m.Name;
                }
            }
            else
                name += m.Name;
                
            return name;            
        }

        public static OpIdentity constructed(MethodInfo src)
        {
            var id = src.OpName();
            var argtypes = src.ParameterTypes(true).ToArray();
            var args = src.GetParameters();

            id += IDI.PartSep;

            if(src.IsConstructedGenericMethod)
                id += IDI.Generic;                           

            id += string.Join(IDI.PartSep, Identity.parameters(src));

            return OpIdentity.Define(id);
        }        

        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity generic(MethodInfo src)            
        {
            if(!src.IsGenericMethod)
                return OpIdentity.Empty;
                        
            var id = src.OpName();
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
                        last = concat(IDI.Vector,argtype.Width().Format());
                    else if(argtype.IsBlocked())
                        last = concat(IDI.Block, argtype.Width().Format());
                    else if(argtype.IsSpan())
                        last = argtype.SpanKind().Format();
                }
                
                id += last;
            }

            return OpIdentity.Define(id);        
        }

        public static OpIdentity group(MethodInfo method)            
        {
            var id = method.OpName();
            var args = Identity.parameters(method).ToArray();
            for(var i=0; i<args.Length; i++)            
            {
                id += IDI.PartSep;                    
                id += args[i];
            }
            return OpIdentity.Define(id);
        }
    }
}