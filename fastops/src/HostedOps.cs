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

    public static class HostedOps
    {
        /// <summary>
        /// Determines the direct operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<DirectOpGroup> groups(ApiHost src)
            => from d in direct(src).GroupBy(op => op.ConcreteMethod.Name)
                let id = OpIdentity.Define(d.Key)
                select DirectOpGroup.Define(src, id, d);                    

        /// <summary>
        /// Determines the generic operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<GenericOpSpec> generic(ApiHost src)
            => from m in src.DeclaredMethods.Attributed<OpAttribute>().OpenGeneric()
                let def = m.GetGenericMethodDefinition()
                let closures = m.NumericClosures().ToArray()
                let id = Identity.generic(m)
                where closures.Length != 0
                select GenericOpSpec.Define(src,id, def, closures);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedOpSpec> close(GenericOpSpec op)
            => from k in op.Kinds
                let pt = k.ToClrType()
                where pt.IsSome()
                let id = Identity.identify(op.MethodDefinition, k)
                where !id.IsEmpty
                select ClosedOpSpec.Define(op.Host, id, k, op.MethodDefinition.MakeGenericMethod(pt.Value)); 

       static IEnumerable<DirectOpSpec> direct(ApiHost host)
            => from m in host.DeclaredMethods.Attributed<OpAttribute>().NonGeneric()
                select DirectOpSpec.Define(host, Identity.identify(m), m);

 
        static IEnumerable<NumericKind> NumericClosures(this MemberInfo m)
            => m.CustomAttribute<NumericClosuresAttribute>()
                .MapValueOrElse(
                    a => a.NumericPrimitive.DistinctKinds(), 
                    () => items<NumericKind>());
    }
}