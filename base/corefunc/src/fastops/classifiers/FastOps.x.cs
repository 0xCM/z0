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
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class FastOpX
    {
        /// <summary>
        /// Selects the public static members of a source type to which the Op attribute is applied
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<MethodInfo> FastOpMethods(this Type host)
            => host.Methods().Public().Static().Attributed<OpAttribute>();
               
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string FastOpName(this MethodInfo m)
            => Classified.opname(m);

        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastDirectInfo> FastOpDirect(this Type host)
            => host.FastOpMethods().NonGeneric().Select(m => FastDirectInfo.Define(m.FastOpName(),m));

        public static IEnumerable<FastDirectInfo> FastOpDirect(this IEnumerable<Type> hosts)
            => hosts.SelectMany(h => h.FastOpDirect());

        public static IEnumerable<PrimalKind> PrimalClosures(this MethodInfo m)
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.Closures.Distinct(), () => items<PrimalKind>());

        public static Option<FastGenericInfo> GenericOpInfo(this MethodInfo m) 
            => FastGenericInfo.Define(m.FastOpName(), m.GetGenericMethodDefinition(), m.PrimalClosures());
            // var provider = Moniker.Provider;
            // var monikers = (from closure in m.PrimalClosures() select provider.Define(def, closure)).ToArray();
            // if(monikers.Length != 0)
            //     return FastGenericInfo.Define(m.FastOpName(),def, monikers);
            // else
            //     return default;                 
                
        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastGenericInfo> FastOpGenerics(this Type host) 
            => from m in host.FastOpMethods().OpenGeneric()
                let g  = m.GenericOpInfo()
                where g.IsSome()
                select g.Value;
                        
        public static IEnumerable<FastGenericInfo> FastOpGenerics(this IEnumerable<Type> hosts)
            => from host in hosts
                from op in host.FastOpGenerics()
                select op;

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<Pair<Moniker,MethodInfo>> Closures(this FastGenericInfo op)
            => from k in op.Kinds
                let m = Moniker.Provider.Define(op.Method, k)
                select paired(m, op.Method.MakeGenericMethod(k.ToPrimalType()));
            // => from r in op.SayBye
            //    where r.PrimalKind.IsSome()
            //    let t = r.PrimalKind.ToPrimalType()
            //    let m = op.Method.MakeGenericMethod(t)
            //    select paired(r,m);
            
        /// <summary>
        /// Determines whether a method defines a formalized operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFastOp(this MethodInfo m)
            => Classified.fastop(m);
        
        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => Classified.spanned(m);

        /// <summary>
        /// Determines whether a method is classified as a nat op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNatOp(this MethodInfo m)
            => Classified.natural(m);
        
        /// <summary>
        /// Determines whether a method is classified as a blocked op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlockedOp(this MethodInfo m)
            => Classified.blocked(m);

        public static IEnumerable<MethodInfo> FastOps(this IEnumerable<MethodInfo> src)
            => src.Attributed<OpAttribute>();
    }
}
