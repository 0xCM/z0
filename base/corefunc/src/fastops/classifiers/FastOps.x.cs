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
        public static string FastOpName(this MethodInfo m )
            => m.CustomAttribute<OpAttribute>().MapValueOrElse(a => a.Name.IsBlank() ? m.Name : a.Name, () => m.Name);

        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastDirectInfo> FastOpDirect(this Type host)
            => host.FastOpMethods().NonGeneric().Select(m => FastDirectInfo.Define(m.FastOpName(),m));

        public static IEnumerable<FastDirectInfo> FastOpDirect(this IEnumerable<Type> hosts)
            => hosts.SelectMany(h => h.FastOpDirect());

        public static IEnumerable<PrimalKind> FastOpClosures(this MethodInfo m)
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.Closures.Distinct(), () => items<PrimalKind>());

        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastGenericInfo> FastOpGenerics(this Type host) 
            => from m in host.FastOpMethods().OpenGeneric()
                let closures = m.FastOpClosures().ToArray()
                where closures.Length != 0 
                let def = m.GetGenericMethodDefinition()                
                let provider = Moniker.Provider
                let monikers = closures.Map(closure => provider.Define(def, closure))
                select FastGenericInfo.Define(m.FastOpName(), def, monikers);
                        
        public static IEnumerable<FastGenericInfo> FastOpGenerics(this IEnumerable<Type> hosts)
            => from host in hosts
                from op in host.FastOpGenerics()
                select op;

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<Pair<Moniker,MethodInfo>> Closures(this FastGenericInfo op)
            => from r in op.Reifications
               where r.PrimalKind.IsSome()
               let t = r.PrimalKind.ToPrimalType()
               let m = op.Method.MakeGenericMethod(t)
               select paired(r,m);
            
        public static bool IsFastOp(this MethodInfo m)
            => m.Attributed<OpAttribute>();
        
        public static bool IsSpanOp(this MethodInfo m)
            => m.Attributed<SpanOpAttribute>();

        public static bool IsNatOp(this MethodInfo m)
            => m.Attributed<NatOpAttribute>();

    }
}
