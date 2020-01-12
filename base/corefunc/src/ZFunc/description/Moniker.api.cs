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

    public readonly partial struct Moniker
    {
        [MethodImpl(Inline)]   
        public static Moniker define(string text)
            => new Moniker(text);

        /// <summary>
        /// Produces an identifier {bitsize(k)}{u | i | f} for a primal kind k
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]   
        public static string primalsig(PrimalKind k)
            => $"{Classified.width(k)}{Classified.indicator(k)}";

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind k, bool generic)
            => define(opname, 0, k, generic, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker define(string opname, PrimalKind k)
            => define(opname, 0, k, false, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static Moniker generic(string opname, PrimalKind k)
            => define(opname, 0, k, true, false);

        /// <summary>
        /// Defines an identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The bit width</param>
        /// <param name="k">The primal cell kind</param>
        [MethodImpl(Inline)]   
        public static Moniker define<W>(string opname, PrimalKind k, W w)
            where W : unmanaged, ITypeNat
                => new Moniker($"{opname}_{w}{SegSep}{Classified.primalsig(k)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_asm} to identify an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">For segmented types, the total bit-width; otherwise 0</param>
        /// <param name="k">The primal kind</param>
        public static Moniker define(string opname, int w, PrimalKind k, bool generic, bool asm)
        {
            var g = generic ? $"{GenericIndicator}" : string.Empty;
            var asmPart = asm ? $"{SuffixSep}{AsmIndicator}" : string.Empty;
            if(w != 0)
                return new Moniker($"{opname}{OpSep}{g}{w}{SegSep}{Classified.primalsig(k)}{asmPart}");
            else
                return new Moniker($"{opname}_{g}{Classified.primalsig(k)}{asmPart}");
        }

        /// <summary>
        /// Makes a best-guess at defining an appropriate moniker for a specified method
        /// </summary>
        /// <param name="method">The operation method</param>
        public static Moniker define(MethodInfo method)
        {
            if(method.IsVectorized())
                return FromVectorized(method);
            else if(method.IsBlocked())
                return FromBlocked(method);
            else if(method.IsOperator())
                return FromPrimalOp(method);
            else if(method.IsPredicate())
                return FromPredicate(method);
            else if(method.IsPrimalShift())
                return FromShift(method);
            else
                return new Moniker($"{method.Name}_{method.GetHashCode()}");
        }

        /// <summary>
        /// Derives a moniker for a primal operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPrimalOp(MethodInfo method)
            => Moniker.define(method.Name, method.ReturnType.Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for a primal predicate
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromPredicate(MethodInfo method)
            => Moniker.define(method.Name, method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for primal shift/rot operator
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromShift(MethodInfo method)
            => Moniker.define(method.Name, method.ParameterTypes().First().Kind(), method.IsConstructedGenericMethod);

        /// <summary>
        /// Derives a moniker for an operation over blocked domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromBlocked(MethodInfo method)
        {
            var type = method.ParameterTypes().First();       
            var segkind = type.GenericTypeArguments.FirstOrDefault().Kind();     
            var generic = method.IsConstructedGenericMethod;
            var w = type.BitWidth();
            var opname = method.Name;
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
            var segkind = v.GenericTypeArguments.FirstOrDefault().Kind();         
            return define(method.Name, v.BitWidth(), segkind, method.IsConstructedGenericMethod,false);                            
        }

        /// <summary>
        /// Derives a moniker for an operation over intrinsic vector domain(s)
        /// </summary>
        /// <param name="method">The operation method</param>
        static Moniker FromVectorized(MethodInfo method)
        {
            var input = method.ParameterTypes().ToArray();
            var name = method.Name + AsciSym.Underscore;
            
            if(method.IsOperator())
                return FromVectorOp(method);
            
            if(method.IsConstructedGenericMethod)
                name += GenericIndicator;

            for(var i=0; i<input.Length; i++)
            {
                var segment = input[i];
                var w = segment.BitWidth();
                if(w == 0)
                    continue;
                
                if(i != 0)
                    name += AsciSym.Underscore;

                if(segment.IsVector())
                {
                    var segtype = segment.GetGenericArguments().Single();
                    var segwidth = segtype.BitWidth();
                    name += ($"{w}x{segwidth}" + segtype.Kind().Sign());
                }
                else
                {
                    name += ($"{w}" + segment.Kind().Sign());
                }                
            }
            return new Moniker(name);            
        }


    }
}