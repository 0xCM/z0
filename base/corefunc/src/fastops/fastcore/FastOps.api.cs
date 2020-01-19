//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static zfunc;


    public static class FastOps
    {
        /// <summary>
        /// Determines whether a method defines a formalized operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool test(MethodInfo m)
            => m.Attributed<OpAttribute>();

        /// <summary>
        /// Gets the name of a method to which an Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string opname(MethodInfo m )
            => m.CustomAttribute<OpAttribute>().MapValueOrElse(a => a.Name.IsBlank() ? m.Name : a.Name, () => m.Name);

        public static FastDirectInfo direct(string name, MethodInfo method)
            => new FastDirectInfo(name,method);        

        /// <summary>
        /// Selects the public members of a type that are identified as formalized operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<MethodInfo> methods(Type host)
            => host.Methods().Public().Attributed<OpAttribute>();

        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastDirectInfo> direct(Type host)
            => methods(host).NonGeneric().Select(m => direct(m.FastOpName(),m));

        public static IEnumerable<FastDirectInfo> direct(IEnumerable<Type> hosts)
            => hosts.SelectMany(direct);

        public static FastGenericInfo generics(string name, MethodInfo method, IEnumerable<PrimalKind> kinds)
            => new FastGenericInfo(name, method,kinds);

        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastGenericInfo> generics(Type host) 
            => from m in  methods(host).OpenGeneric()
                select generics(m.FastOpName(), m.GetGenericMethodDefinition(), kinds(m));

        public static IEnumerable<FastGenericInfo> generics(IEnumerable<Type> hosts)
            => hosts.SelectMany(h => h.FastOpGenericMethods());


        public static FastOpClosure closure(Moniker id, PrimalKind k, MethodInfo m)
            => new FastOpClosure(id, k, m);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<FastOpClosure> closures(FastGenericInfo op)
            => from k in op.Kinds
                let definition = op.Method
                let id = Moniker.Provider.Define(definition, k)
                let closed = definition.MakeGenericMethod(k.ToPrimalType())
                select closure(id, k, closed);            


        /// <summary>
        /// Determines whether a method is classified as a blocked op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool blocked(MethodInfo m)
            => m.Attributed<BlockedOpAttribute>();

        /// <summary>
        /// Determines whether a method is classified as a natural op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool natural(MethodInfo m)
            => m.Attributed<NatOpAttribute>();

        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool spanned(MethodInfo m)
            => m.Attributed<SpanOpAttribute>();

        static IEnumerable<PrimalKind> memberkinds(MemberInfo m)
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.Closures.DistinctKinds(), () => items<PrimalKind>());

        static IEnumerable<PrimalKind> kinds(MethodInfo m)
            => memberkinds(m);

        static IEnumerable<PrimalKind> kinds(Type t)
            => memberkinds(t);
    }
}