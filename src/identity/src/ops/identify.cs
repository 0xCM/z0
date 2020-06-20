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

    using static Konst;
    
    partial class Identity
    {
        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return generic(src).Generialize();
            else if(src.IsConstructedGenericMethod)
                return constructed(src);
            else
                return nongeneric(src);
        }            
        
        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => TypeIdentityDiviner.IdentityProvider(t).Identify(t);

        public static string identify(ParameterInfo p)
        {
            if(!p.IsParametric())
            {
                var id = p.ParameterType.IsEnum 
                    ? identify(p.ParameterType) 
                    : identify(p.ParameterType.EffectiveType());
                if(!id.IsEmpty)
                    return text.concat(id.Identifier, p.ReferenceKind().Format());                
            }
            return string.Empty;                        
        }

        static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var t = k.SystemType();
            if(src.IsOpenGeneric() && t.IsNonEmpty())
                return identify(src.MakeGenericMethod(t));
            else
                return identify(src);
        }

        static IEnumerable<string> args(MethodInfo method)
        {
            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = Identity.identify(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }
    }
}
