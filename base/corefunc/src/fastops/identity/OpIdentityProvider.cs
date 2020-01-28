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

        public Moniker DefineIdentity(string opname, bool generic, params NumericKind[] kinds)
        {
            var id = opname;
            id += PartSep;
            
            if(generic)
                id += GenericIndicator;
            
            for(var i=0; i<  kinds.Length; i++)
            {
                if(i!=0)
                    id += PartSep;
                
                id += PrimalType.signature(kinds[i]);
            }
            return Moniker.Parse(id);
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
            if(method.GenericSlots().Length > 1)
                return Moniker.Empty;

            if(method.IsOpenGeneric())
                return OpIdentity.define(method.OpName(), 0, NumericKind.None, true, false);
            else if(method.IsNonGeneric() && method.OpName() != method.Name)
                return Moniker.Parse(method.OpName());
            else if(method.IsSpanOp())
                return FromSpanOp(method);
            else if(method.IsNatOp())
                return FromNatOp(method);
            else if(method.IsVectorFactory())
                return FromAny(method);
            else if(method.IsVectorized())
                return FromVectorized(method);
            else if(method.IsBlocked())
                return FromAny(method);
            else if(method.IsOperator())
                return FromPrimalOp(method);
            else if(method.IsPredicate())
                return FromPredicate(method);
            else if(method.IsPrimalShift())
                return FromShift(method);
            else if(method.IsPrimalOp())
                return FromPrimalFunc(method);
            else
                return FromAny(method);
        }

        static AppMsg TooManyTypeParmeters(MethodInfo m)
            => appMsg($"The method {m.Name} accepts parameters that require more than one generic argument and is currently unsupported", SeverityLevel.Warning);


        static string ConsructedParameter(Type arg)
        {
            var id = string.Empty;
            var typeargs = arg.SuppliedGenericArguments().ToArray();
            if(typeargs.Length > 1)
                NatSpanType.id(arg).OnSome(nsid => id += nsid);
            var typearg = typeargs[0];
            
            if(arg.IsSpan())
                id += $"span{PrimalType.signature(typearg)}";
            else
            {
                if(arg.IsSegmented())
                {
                    var w = (int)arg.Width();
                    if(w != 0)
                    {
                        id += $"{w}";
                        var segwidth = (int)typearg.Width();
                        if(segwidth != 0)
                            id += $"{SegSep}{segwidth}{typearg.Kind().Indicator()}";
                    }
                    else 
                        id += "~~err~~";
                }
                else
                {
                    var k  = typearg.Kind();
                    if(k.IsSome())
                        id += PrimalType.signature(k);
                    else
                        id += typearg.Name;
                }
            }
            return id;
        }
        static Moniker FromAny(MethodInfo method)
        {
            var id = method.OpName();
            var argtypes = method.ParameterTypes(true).ToList();
            var paramcount = argtypes.Count;

            for(var i=0; i<paramcount; i++)
            {
                var arg = argtypes[i];                
                id += PartSep;

                if(i == 0)
                {
                    if(method.IsConstructedGenericMethod)                 
                        id += GenericIndicator;       
                    
                    if(method.IsBlocked())
                        id += BlockIndicator;
                }

                if(NatType.test(arg))
                    id += NatType.name(arg);                    
                else if(arg.IsConstructedGenericType)              
                    id += ConsructedParameter(arg);
                else if(PrimalType.test(arg))
                    id += PrimalType.signature(arg);
                else if(arg.IsEnum)
                    id += $"enum{PrimalType.signature(arg.GetEnumUnderlyingType())}";
                else
                    id += arg.Name;                    
            }

            return Moniker.Parse(id);
        }
        
        static Moniker FromPrimalFunc(MethodInfo method)
            => OpIdentity.define(method.OpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a primal operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPrimalOp(MethodInfo method)
            => OpIdentity.define(method.OpName(), method.ReturnType.Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a primal predicate
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPredicate(MethodInfo method)
            => OpIdentity.define(method.OpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for primal shift/rot operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromShift(MethodInfo method)
            => OpIdentity.define(method.OpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for an operation over segmented domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromVectorOp(MethodInfo method)
        {
            var param = method.ParameterTypes().First();       
            var segkind = param.SuppliedGenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.segmented(method, param.Width(), segkind);
        }

        static Moniker FromSpanOp(MethodInfo method)
        {
            var param = method.ParameterTypes().First();       
            var segkind = param.SuppliedGenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.segmented(method, param.Width(), segkind);
        }

        static Moniker FromNatOp(MethodInfo method)
        {
            var natvals = from t in method.ParameterTypes()
                        where NatType.test(t)
                        select concat(NatIndicator,NatType.value(t).ToString());
            var natspec = string.Join(SegSep, natvals);
            var name = concat(method.OpName(), AsciSym.Tilde, natspec);
            var kind = method.TypeParameterKind(n1);
            var width = kind.BitWidth();                               
            return OpIdentity.define(name, width, kind, method.IsConstructedGenericMethod, false);
        }

        /// <summary>
        /// Derives a moniker for an operation over segmented types
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromVectorized(MethodInfo method)
        {
            if(method.IsVectorOp())
                return FromVectorOp(method);

            var id = method.OpName() + PartSep;
            var parameters = method.GetParameters().Where(p => !p.IsImmediate());
            var paramtypes = parameters.Select(p => p.ParameterType.EffectiveType()).ToArray();
            
            if(method.IsConstructedGenericMethod)
            {
                id += PartSep;
                id += Moniker.GenericIndicator;
            }
            
            for(var i=0; i<paramtypes.Length; i++)
            {
                if(i != 0)                    
                    id += PartSep;
             
                var arg = paramtypes[i];                
                if(arg.IsSegmented())
                {
                    var celltype = arg.SuppliedGenericArguments().Single();
                    var w = (int)arg.Width();
                    id += $"{w}{SegSep}{(int)celltype.Width()}{celltype.Kind().Indicator()}";
                }
                else if(NatType.test(arg))
                    id += NatType.name(arg);                
                else if(PrimalType.test(arg))
                    id += PrimalType.signature(arg);
                else if(arg.IsEnum)
                    id += $"enum{PrimalType.signature(arg.GetEnumUnderlyingType())}";
                else if(arg.IsSpan())
                {
                    var celltype = arg.SuppliedGenericArguments().Single();
                    id += $"span{PrimalType.signature(celltype)}";
                }
                else
                    id += arg.Name;                    
            }

            return Moniker.Parse(id);
        }
    }
}