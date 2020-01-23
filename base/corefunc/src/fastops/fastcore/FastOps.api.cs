//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static zfunc;

    public static class FastOps
    {            
        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpSpec> direct(Type host)
            => from m in methods(host).NonGeneric()
                let id = identity(m)
                where !id.IsEmpty
                select DirectOpSpec.Define(id, m.OpName(), m);                        

        public static IEnumerable<DirectOpSpec> direct(IEnumerable<Type> hosts)
            => hosts.SelectMany(direct);

        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpSpec> generics(Type host) 
            => from m in  methods(host).OpenGeneric()
                let id = identity(m)
                where !id.IsEmpty
                select GenericOpSpec.Define(id, m.OpName(), m.GetGenericMethodDefinition(), PrimalType.closures(m));

        public static IEnumerable<GenericOpSpec> generics(IEnumerable<Type> hosts)
            => hosts.SelectMany(generics);

        public static OpClosureSpec closure(Moniker id, PrimalKind k, MethodInfo m)
            => OpClosureSpec.Define(id, k, m);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureSpec> closures(GenericOpSpec op)
            => from k in op.Kinds
                let definition = op.Method
                let id = OpIdentity.Provider.DefineIdentity(definition, k)
                where !id.IsEmpty
                let closed = definition.MakeGenericMethod(k.ToPrimalType())
                select closure(id, k, closed);            

        /// <summary>
        /// Selects the public members of a type that are identified as formalized operations
        /// </summary>
        /// <param name="host">The source type</param>
        static IEnumerable<MethodInfo> methods(Type host)
            => host.Methods().Public().Attributed<OpAttribute>();

        static Moniker identity(MethodInfo m)
            => OpIdentity.Provider.DefineIdentity(m);

    }
}