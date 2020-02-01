//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    using static Moniker;

    readonly struct OpIdentity : IOpIdentityProvider
    {
        public Moniker DefineIdentity(MethodInfo method, NumericKind k)
        {
            var provider = this as IOpIdentityProvider;
            var pt = k.ToClrType();
            if(method.IsOpenGeneric() && pt.IsSome())
                return  provider.DefineIdentity(method.MakeGenericMethod(pt.Value));
            else
                return provider.DefineIdentity(method);
        }

        public Moniker GroupIdentity(MethodInfo method)            
        {
            var id = method.OpName();
            var args = Args(method).ToArray();
            for(var i=0; i<args.Length; i++)            
            {
                id += Moniker.PartSep;                    
                id += args[i];
            }
            return Moniker.Parse(id);
        }

        public Moniker GenericIdentity(MethodInfo method)            
        {
            if(!method.IsGenericMethod)
                return Moniker.Empty;
                        
            var id = method.OpName();
            id += Moniker.PartSep; 
            id += Moniker.Generic;

            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += Moniker.PartSep;

                last = string.Empty;                    

                if(args[i].IsParametric())
                    last = Arg(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = concat(Moniker.Vector,argtype.Width().Format());
                    else if(argtype.IsBlocked())
                        last = concat(Moniker.Block, argtype.Width().Format());
                    else if(argtype.IsSpan())
                        last = Moniker.Span;
                }
                else
                    last = Arg(args[i]);
                
                id += last;

            }

            return Moniker.Parse(id);        
        }

        /// <summary>
        /// Makes a best-guess at defining an appropriate moniker for a specified method
        /// </summary>
        /// <param name="method">The operation method</param>
        Moniker IOpIdentityProvider.DefineIdentity(MethodInfo method)
        {            
            if(method.IsOpenGeneric())
                return GenericIdentity(method);
            else
                return FromAny(method);
        }
        
        static string Arg(ParameterInfo p)
        {
            var pt = p.ParameterType;
            return !p.IsParametric()
                ? pt.EffectiveType().ProvidedIdentity().MapValueOrDefault(m => concat(m.Text,p.Variance().Format()), string.Empty)
                : string.Empty;                                                
        }

        static IEnumerable<string> Args(MethodInfo method)
        {
            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = Arg(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        static Moniker FromAny(MethodInfo method)
        {
            var id = method.OpName();
            var argtypes = method.ParameterTypes(true).ToArray();
            var args = method.GetParameters();

            id += PartSep;

            if(method.IsConstructedGenericMethod)
                id += Generic;                           

            id += string.Join(Moniker.PartSep, Args(method));

            return Moniker.Parse(id);
        }        
    }
}