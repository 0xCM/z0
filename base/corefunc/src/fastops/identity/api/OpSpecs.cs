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
        public static IEnumerable<DirectOpSpec> direct(Type host)
            => from m in host.DeclaredMethods().Attributed<OpAttribute>().NonGeneric()
                select DirectOpSpec.Define(Identity.identify(m), m);

        public static IEnumerable<DirectOpGroupSpec> groups(Type host)
            => from d in direct(host).GroupBy(op => op.Id.Name)
                let id = OpIdentity.Define(d.Key)
                select DirectOpGroupSpec.Define(id, d);                    

        public static IEnumerable<GenericOpSpec> generic(Type host)
            => from m in host.DeclaredMethods().Attributed<OpAttribute>().OpenGeneric()
                let def = m.GetGenericMethodDefinition()
                let closures = m.NumericClosures().ToArray()
                let id = Identity.generic(m)
                where closures.Length != 0
                select GenericOpSpec.Define(id, def, closures);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> close(GenericOpSpec op)
            => from k in op.Kinds
                let pt = k.ToClrType()
                where pt.IsSome()
                let id = Identity.identify(op.Root, k)
                where !id.IsEmpty
                select OpClosureInfo.Define(id, k, op.Root.MakeGenericMethod(pt.Value)); 

        readonly struct DirectSvc : IOpSpecifier<DirectOpSpec>
        {
            public IEnumerable<DirectOpSpec> FromHost(Type host)
                => direct(host);
        }

        readonly struct DirectGroupSvc : IOpSpecifier<DirectOpGroupSpec>
        {
            public IEnumerable<DirectOpGroupSpec> FromHost(Type host)
                => groups(host);
        }

        readonly struct GenericSvc : IOpSpecifier<GenericOpSpec>
        {
            public IEnumerable<GenericOpSpec> FromHost(Type host)
                => generic(host);
        }
    }
}