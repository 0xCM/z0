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

    public interface IOpIdentityProvider
    {
        Moniker Define(MethodInfo method);

        Moniker Define(MethodInfo method, PrimalKind k);
    }

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
                return OpIdentity.define(method.FastOpName());
            else if(method.IsSpanOp())
                return FromSpanOp(method);
            else if(method.IsNatOp())
                return FromNatOp(method);
            else if(method.IsVectorized())
                return FromVectorized(method);
            else if(method.IsBlocked())
                return FromBlocked(method);
            else if(method.IsOperator())
                return FromPrimalOp(method);
            else if(method.IsPredicate())
                return FromPredicate(method);
            else if(method.IsPrimalShift())
                return FromShift(method);
            else if(method.HasPrimalOperands())
                return FromPrimalFunc(method);
            else
                return new Moniker($"{method.Name}_{method.GetHashCode()}");
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
        /// Derives a moniker for an operation over blocked domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromBlocked(MethodInfo method)
        {
            var type = method.ParameterTypes().Where(t => t.IsBlocked()).First();
            var segkind = type.GenericArguments().First();
            var generic = method.IsConstructedGenericMethod;
            var w = type.BitWidth();
            var opname = method.FastOpName();
            if(generic)
                return new Moniker($"{opname}_gb{w}{SegSep}{Classified.primalsig(segkind)}") ;
            else 
                return  new Moniker($"{opname}_b{w}{SegSep}{Classified.primalsig(segkind)}");                            
        }

        /// <summary>
        /// Derives a moniker for an operation over segmented domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromVectorOp(MethodInfo method)
        {
            var v = method.ParameterTypes().First();       
            var segkind = v.GenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.define(method.FastOpName(), v.BitWidth(), segkind, method.IsConstructedGenericMethod,false);                            
        }

        static Moniker FromSpanOp(MethodInfo method)
        {
            var v = method.ParameterTypes().First();       
            var segkind = v.GenericArguments().FirstOrDefault().Kind();         
            return OpIdentity.define(method.FastOpName(), v.BitWidth(), segkind, method.IsConstructedGenericMethod, false);
        }

        static Moniker FromNatOp(MethodInfo method)
        {
            var natvals = from t in method.ParameterTypes()
                        where TypeNatType.test(t)
                        select concat(NatIndicator,TypeNatType.value(t).ToString());
            var natspec = string.Join(SegSep, natvals);
            var name = concat(method.FastOpName(), AsciSym.Tilde, natspec);
            var kind = method.TypeParamKind(n1);
            var width = kind.BitWidth();                               
            return OpIdentity.define(name, width, kind, method.IsConstructedGenericMethod, false);
        }

        /// <summary>
        /// Derives a moniker for an operation over intrinsic vector domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromVectorized(MethodInfo method)
        {
            var args = method.ParameterTypes().ToArray();
            var id = method.FastOpName() + AsciSym.Underscore;
            
            if(method.IsOperator())
                return FromVectorOp(method);
            
            if(method.IsConstructedGenericMethod)
                id += GenericIndicator;

            for(var i=0; i<args.Length; i++)
            {
                var arg = args[i];
                
                if(i != 0)
                    id += AsciSym.Underscore;

                if(arg.IsVector())
                {
                    var w = (int)VectorType.width(arg);
                    var segtype = arg.GenericArguments().Single();
                    var segwidth = segtype.BitWidth();
                    id += ($"{w}x{segwidth}" + segtype.Kind().Indicator());
                }
            }
            return OpIdentity.define(id);
        }
    }

}