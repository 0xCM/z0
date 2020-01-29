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

    public static class OpSpecs
    {
        /// <summary>
        /// Selects the declared members of a type that are identified as formalized operations
        /// </summary>
        /// <param name="host">The source type</param>
        static IEnumerable<MethodInfo> declared(Type host)
            => host.DeclaredMethods().Attributed<OpAttribute>();

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> close(GenericOpSpec op)
            => from k in op.Kinds
                let definition = op.Method
                let id = OpIdentity.Provider.DefineIdentity(definition, k)
                where !id.IsEmpty
                let closed = definition.MakeGenericMethod(k.ToPrimalType())
                select OpClosureInfo.Define(id, k, closed);            

        /// <summary>
        /// Queries a specified type for formalized concrete/non-generic operation implementations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpSpec> direct(Type host)
            => from m in declared(host).NonGeneric()
                let id = identity(m)
                where !id.IsEmpty
                select DirectOpSpec.Define(id, m.OpName(), m);                        

        /// <summary>
        /// Queries a specified type for groups of related direct operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpGroup> directGroups(Type host)
            => direct(host).GroupBy(op => op.Id.Name).Select(g => DirectOpGroup.Define(Moniker.Parse(g.Key), g));

        /// <summary>
        /// Queries a type for formalized generic operation definitions
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpSpec> generic(Type host) 
            => from m in declared(host).OpenGeneric()
                let id = genericid(m)
                where id.IsSome()
                let closures = NumericType.closures(m).ToArray()
                where closures.Length != 0
                select GenericOpSpec.Define(id.Require(), m.OpName(), m.GetGenericMethodDefinition(), closures);

        /// <summary>
        /// Queries a sequence of types for formalized generic operation definitions
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpSpec> generic(IEnumerable<Type> hosts)
            => hosts.SelectMany(generic);

        static Moniker identity(MethodInfo m)
            => OpIdentity.Provider.DefineIdentity(m);
        
        static Option<Moniker> genericid(MethodInfo m)
            => OpIdentity.Provider.GenericIdentity(m);
    }
}