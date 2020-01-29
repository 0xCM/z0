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

    readonly struct OpIdentityProvider : IOpIdentityProvider
    {
        public Moniker DefineIdentity(MethodInfo method, NumericKind k)
        {
            var provider = this as IOpIdentityProvider;
            if(method.IsOpenGeneric() && k.IsSome())
                return  provider.DefineIdentity(method.MakeGenericMethod(k.ToPrimalType()));
            else
                return provider.DefineIdentity(method);
        }
            
        public Option<Moniker> GenericIdentity(MethodInfo method)            
        {
            if(!method.IsGenericMethod)
                return default;
                
            var id = method.OpName();
            id += Moniker.PartSep; 
            id += Moniker.GenericIndicator;

            var parameters = new List<Type>();
            if(method.IsVectorized())  
            {
                parameters.AddRange(method.ParameterTypes(true).Where(t => t.IsVector()));                
                if(parameters.Count == 0 && method.ReturnType.IsVector())
                    parameters.Add(method.ReturnType);   
            }
            else if(method.IsBlocked())
            {
                id += Moniker.BlockIndicator;
                parameters.AddRange(method.ParameterTypes(true).Where(t => t.IsBlocked()));                
                if(parameters.Count == 0 && method.ReturnType.IsBlocked())
                    parameters.Add(method.ReturnType);
            }
            else if(method.IsSpanOp())
            {
                id += "span";
                id += Moniker.SegSep;
                id += method.ParameterTypes(true).Where(t => t.EffectiveType().IsSpan()).Count().ToString();
                return Moniker.Parse(id);
            }
            
            var widths = parameters.Select(p => p.Width()).Where(w => w != FixedWidth.None).ToList();
            for(var i=0; i<widths.Count; i++)
            {
                if(i != 0)
                    id += Moniker.SegSep;
                
                id += ((int)widths[i]).ToString();
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
                return GenericIdentity(method).Require();
            else
                return FromAny(method);
        }
        
        static string Variance(ParameterInfo src)
        {
            if(src.IsIn)
                return parenthetical("in");
            else if(src.IsOut)
                return  parenthetical("out");
            else if(src.ParameterType.IsRef())
                return parenthetical("ref");
            else
                return string.Empty;
        }

        static Moniker FromAny(MethodInfo method)
        {
            var id = method.OpName();
            var argtypes = method.ParameterTypes(true).ToArray();
            var args = method.GetParameters();

            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtype = argtypes[i];                
                id += PartSep;

                if(i == 0 && method.IsConstructedGenericMethod)
                    id += GenericIndicator;                           

                id += TypeIdentity.Provider(argtype).DefineIdentity(argtype);
                id += Variance(args[i]);
            }

            return Moniker.Parse(id);
        }        
    }
}