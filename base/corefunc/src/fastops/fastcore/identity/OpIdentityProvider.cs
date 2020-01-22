//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    using static Moniker;

    readonly struct OpIdentityProvider : IOpIdentityProvider
    {
        public Moniker Define(MethodInfo method, PrimalKind k)
        {
            if(method.IsOpenGeneric() && k.IsSome())
                return Define(method.MakeGenericMethod(k.ToPrimalType()));
            else
                return Define(method);
        }

        /// <summary>
        /// Makes a best-guess at defining an appropriate moniker for a specified method
        /// </summary>
        /// <param name="method">The operation method</param>
        public Moniker Define(MethodInfo method)
        {
            if(method.IsOpenGeneric())
                return OpIdentity.define(method.Name, 0, PrimalKind.None, true, false);
            else if(method.IsNonGeneric() && method.FastOpName() != method.Name)
                return Moniker.Parse(method.FastOpName());
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
                return Moniker.Parse($"{method.Name}_{method.GetHashCode()}");
        }

        static Moniker FromPrimalFunc(MethodInfo method)
            => OpIdentity.define(method.FastOpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a primal operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPrimalOp(MethodInfo method)
            => OpIdentity.define(method.FastOpName(), method.ReturnType.Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a primal predicate
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPredicate(MethodInfo method)
            => OpIdentity.define(method.FastOpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for primal shift/rot operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromShift(MethodInfo method)
            => OpIdentity.define(method.FastOpName(), method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

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
            return OpIdentity.segmented(method,param.Width(), segkind);
        }

        static Moniker FromNatOp(MethodInfo method)
        {
            var natvals = from t in method.ParameterTypes()
                        where TypeNatType.test(t)
                        select concat(NatIndicator,TypeNatType.value(t).ToString());
            var natspec = string.Join(SegSep, natvals);
            var name = concat(method.FastOpName(), AsciSym.Tilde, natspec);
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

            var id = method.FastOpName() + PartSep;
            var paramtypes = method.ParameterTypes().ToArray();
                    
            if(method.IsConstructedGenericMethod)
                id += GenericIndicator;            

            if(method.IsBlocked())
                id += BlockIndicator;

            for(var i=0; i<paramtypes.Length; i++)
            {
                var arg = paramtypes[i];                

                var w = arg.IsVector() ? (int)VectorType.width(arg) : (arg.IsBlocked() ? (int)BlockedType.width(arg) : 0);
                if(w != 0)
                {
                    if(i != 0)
                        id += PartSep;

                    id += $"{w}{SegSep}";

                    var segtype = arg.GenericArguments().Single();
                    var segwidth = (int)segtype.Width();
                    id += $"{segwidth}{segtype.Kind().Indicator()}";
                }

            }
            return Moniker.Parse(id);
        }
    }
}