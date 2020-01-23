//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    using static Moniker;

    readonly struct OpIdentityProvider : IOpIdentityProvider
    {
        public Moniker DefineIdentity(MethodInfo method, PrimalKind k)
        {
            var provider = this as IOpIdentityProvider;
            if(method.IsOpenGeneric() && k.IsSome())
                return  provider.DefineIdentity(method.MakeGenericMethod(k.ToPrimalType()));
            else
                return provider.DefineIdentity(method);
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
                return OpIdentity.define(method.Name, 0, PrimalKind.None, true, false);
            else if(method.IsNonGeneric() && method.OpName() != method.Name)
                return Moniker.Parse(method.OpName());
            else if(method.IsSpanOp())
                return FromSpanOp(method);
            else if(method.IsNatOp())
                return FromNatOp(method);
            else if(method.IsVectorized() || method.IsBlocked())
                return FromSegmented(method);
            else if(method.IsOperator())
                return FromPrimalOp(method);
            else if(method.IsPredicate())
                return FromPredicate(method);
            else if(method.IsPrimalShift())
                return FromShift(method);
            else if(method.IsPrimal())
                return FromPrimalFunc(method);
            else
                return FromAny(method);
        }

        static AppMsg TooManyTypeParmeters(MethodInfo m)
            => appMsg($"The method {m.Name} accepts parameters that require more than one generic argument and is currently unsupported", SeverityLevel.Error);

        static Moniker FromAny(MethodInfo method)
        {
            var id = method.OpName() + PartSep;            
            var needsGenericIndicator = method.IsConstructedGenericMethod;  
            var needsBlockedIndicator = method.IsBlocked();
            var needsPrimalPartSep = false;
            var needsUncategorizedSep = false;
            var argtypes = method.ParameterTypes(true).ToArray();

            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];                
                var isNatArg = TypeNatType.test(argtype);
                var isSegmentedArg = argtype.IsSegmented();
                var isGenericArg = argtype.IsConstructedGenericType;
                
                if(isNatArg)
                {
                    id += PartSep;
                    id += TypeNatType.id(argtype);
                }
                else if(isGenericArg)              
                {
                    if(needsGenericIndicator)
                    {
                        id += PartSep;
                        id += GenericIndicator;        
                        needsGenericIndicator = false;
                    }

                    var typeargs = argtype.GetGenericArguments().ToArray();
                    if(typeargs.Length > 1)
                        NatSpanType.id(argtype).OnSome(nsid => id += $"{PartSep}{nsid}").OnNone(() => throw AppException.Define(TooManyTypeParmeters(method)));                        
                    else
                    {
                        var typearg = typeargs[0];
                        if(isSegmentedArg)
                        {
                            var w = (int)argtype.Width();
                            if(w != 0)
                            {
                                id += $"{PartSep}{w}";

                                var segwidth = (int)typearg.Width();
                                if(segwidth != 0)
                                    id += $"{SegSep}{segwidth}{typearg.Kind().Indicator()}";
                            }
                            else 
                                id += "~err1";
                        }
                        else
                        {
                            var k  = typearg.Kind();
                            if(k.IsSome())
                            {
                                if(needsPrimalPartSep)
                                    id += PartSep;                                

                                id += PrimalType.primalsig(k);

                                needsPrimalPartSep = true;                                
                            }
                            else
                                id += typearg.Name;
                        }
                    }
                }
                else if(PrimalType.test(argtype))
                {
                    id += PartSep;
                    id += PrimalType.primalsig(argtype);
                }
                else if(argtype.IsEnum)
                {
                    id += PartSep;
                    id += $"enum{PrimalType.primalsig(argtype.GetEnumUnderlyingType())}";
                }
                else
                {
                    if(needsUncategorizedSep)
                        id += AsciSym.Tilde;

                    id += argtype.Name;
                    
                    needsUncategorizedSep = true;
                }
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
            var segkind = param.GenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.segmented(method, param.Width(), segkind);
        }

        static Moniker FromSpanOp(MethodInfo method)
        {
            var param = method.ParameterTypes().First();       
            var segkind = param.GenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.segmented(method, param.Width(), segkind);
        }

        static Moniker FromNatOp(MethodInfo method)
        {
            var natvals = from t in method.ParameterTypes()
                        where TypeNatType.test(t)
                        select concat(NatIndicator,TypeNatType.value(t).ToString());
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
        static Moniker FromSegmented(MethodInfo method)
        {
            if(method.IsVectorOp())
                return FromVectorOp(method);

            var id = method.OpName() + PartSep;
            var paramtypes = method.ParameterTypes(true).Union(items(method.ReturnType.EffectiveType())).ToArray();                    
            var needsGenericIndicator = method.IsConstructedGenericMethod;
            var needsBlockedIndicator = method.IsBlocked();
            var segcount = 0;
            var paramcount = paramtypes.Length;


            for(var i=0; i<paramcount; i++)
            {
                var arg = paramtypes[i];                
                var isNat = TypeNatType.test(arg);
                var isSegmented = arg.IsSegmented();
                if(isSegmented)
                {
                    if(segcount == 0)
                    {
                        segcount++;
                        paramcount--;
                    }

                    var w = arg.IsVector() ? (int)VectorType.width(arg) : (arg.IsBlocked() ? (int)BlockedType.width(arg) : 0);
                    if(needsBlockedIndicator || needsGenericIndicator)
                    {
                        id += PartSep;
                        if(needsGenericIndicator)
                        {
                            needsGenericIndicator = false;
                        }

                        if(needsBlockedIndicator)
                        {
                            id += BlockIndicator;        
                            needsBlockedIndicator= false;
                        }
                    }
                    else 
                        id += PartSep;                

                    id += $"{w}{SegSep}";

                    var segtype = arg.GenericArguments().Single();
                    var segwidth = (int)segtype.Width();
                    id += $"{segwidth}{segtype.Kind().Indicator()}";
                }
                else if(isNat)
                {
                    id += PartSep;
                    id += TypeNatType.id(arg);
                }
            }

            return Moniker.Parse(id);
        }
    }
}