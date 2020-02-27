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
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return Identity.generic(src);
            else if(src.IsConstructedGenericMethod)
                return Identity.constructed(src);
            else
                return Identity.nongeneric(src);
        }            

        public static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var pt = k.ToClrType();
            if(src.IsOpenGeneric() && pt.IsSome())
                return identify(src.MakeGenericMethod(pt.Value));
            else
                return identify(src);
        }
        
        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        public static string identify(ParameterInfo p)
        {
            if(!p.IsParametric())
            {
                var id = Identity.identify(p.ParameterType.EffectiveType());
                if(!id.IsEmpty)
                    return text.concat(id.Identifier, p.Variance().Format());                
            }
            return string.Empty;                        
        }

        public static IEnumerable<string> ParameterIdentities(this MethodInfo method)
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
            var attrib = m.Tag<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;

            var attribVal = attrib.Value;  
            
            var name = attribVal.Name.IsNotBlank() ? attribVal.Name : m.Name;
                
            return name;            
        }

        public static IEnumerable<string> TypeArgIdentities(this MethodInfo src)
            => src.GenericArguments().Select(targ => Identity.identify(targ).Identifier);

        public static string FormatParameterIdentity(this MethodInfo src)
            => formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, src.ParameterIdentities());

        public static string FormatTypeArgIdentity(this MethodInfo src)
            => formatargs(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, src.TypeArgIdentities());

        public static OpIdentity constructed(MethodInfo src)
        {
            src.RequireConstructed();

            var id = string.Empty;
            
            id += src.OpName();
            id += IDI.PartSep;   

            id += IDI.Generic;                           
            id += src.FormatTypeArgIdentity();
            id += src.FormatParameterIdentity();
            return OpIdentity.Define(id);
        }        

        public static OpIdentity nongeneric(MethodInfo src)
        {
            src.RequireNonGeneric();
            var id = string.Empty;
            
            id += src.OpName();            
            id += IDI.PartSep;
            id += formatargs(IDI.ValueArgsOpen, IDI.ValueArgsClose, IDI.ArgSep, src.ParameterIdentities());

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
                        last = text.concat(IDI.Vector,argtype.Width().Format());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, argtype.Width().Format());
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
            var args = Identity.ParameterIdentities(method).ToArray();
            for(var i=0; i<args.Length; i++)            
            {
                id += IDI.PartSep;                    
                id += args[i];
            }
            return OpIdentity.Define(id);            
        }

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        static string OpName(this MethodInfo m)
            => Identity.name(m);

        static string formatargs(char open, char close, char sep, IEnumerable<string> args)
            => text.concat(open, string.Join(sep,args), close);
    }
}