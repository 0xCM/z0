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

    partial class Identity
    {
        static string name(MethodInfo m)
        {
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;              
            return attribVal.Name.IsNotBlank() ? attribVal.Name : m.Name;                
        }

        static OpIdentity constructed(MethodInfo src)
        {
            src.RequireConstructed();

            var id = string.Empty;
            
            id += name(src);
            id += IDI.PartSep;   

            id += IDI.Generic;                           
            id += src.FormatTypeArgIdentity();
            id += src.FormatParameterIdentity();
            return OpIdentity.Define(id);
        }        

        static IEnumerable<string> ParameterIdentities(this MethodInfo method)
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

        static OpIdentity nongeneric(MethodInfo src)
        {
            src.RequireNonGeneric();
            var id = string.Empty;
            
            id += name(src);
            id += IDI.PartSep;
            id += formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, src.ParameterIdentities());

            return OpIdentity.Define(id);
        }        

        static OpIdentity group(MethodInfo method)            
        {
            var id = name(method);
            var args = ParameterIdentities(method).ToArray();
            for(var i=0; i<args.Length; i++)            
            {
                id += IDI.PartSep;                    
                id += args[i];
            }
            return OpIdentity.Define(id);            
        }

        static string FormatParameterIdentity(this MethodInfo src)
            => formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, ParameterIdentities(src));

        static IEnumerable<string> TypeArgIdentities(this MethodInfo src)
            => src.GenericArguments().Select(targ => identify(targ).Identifier);

        static string FormatTypeArgIdentity(this MethodInfo src)
            => formatargs(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, TypeArgIdentities(src));

        static string formatargs(char open, char close, char sep, IEnumerable<string> args)
            => text.concat(open, string.Join(sep,args), close);
    }
}