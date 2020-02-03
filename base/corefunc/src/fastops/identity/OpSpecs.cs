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
        public static IOpSpecifier<GenericOpSpec> Generic
            => default(GenericSvc);

        public static IOpSpecifier<DirectOpGroupSpec> DirectGroups
            => default(DirectGroupSvc);

        public static IOpSpecifier<DirectOpSpec> Direct
            => default(DirectSvc);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> close(GenericOpSpec op)
            => from k in op.Kinds
                let pt = k.ToClrType()
                where pt.IsSome()
                let id = OpIdentities.Provider.DefineIdentity(op.Root, k)
                where !id.IsEmpty
                select OpClosureInfo.Define(id, k, op.Root.MakeGenericMethod(pt.Value)); 

        readonly struct DirectSvc : IOpSpecifier<DirectOpSpec>
        {
            public IEnumerable<DirectOpSpec> FromHost(Type host)
                => from m in host.DeclaredMethods().Attributed<OpAttribute>().NonGeneric()
                    select DirectOpSpec.Define(OpIdentities.Provider.DefineIdentity(m), m);
        }

        readonly struct DirectGroupSvc : IOpSpecifier<DirectOpGroupSpec>
        {
            public IEnumerable<DirectOpGroupSpec> FromHost(Type host)
                => from d in default(DirectSvc).FromHost(host).GroupBy(op => op.Id.Name)
                    let id = OpIdentity.Define(d.Key)
                    select DirectOpGroupSpec.Define(id, d);                    
        }

        readonly struct GenericSvc : IOpSpecifier<GenericOpSpec>
        {
            public IEnumerable<GenericOpSpec> FromHost(Type host)
                => from m in host.DeclaredMethods().Attributed<OpAttribute>().OpenGeneric()
                    let def = m.GetGenericMethodDefinition()
                    let closures = m.NumericClosures().ToArray()
                    let id = OpIdentities.Provider.GenericIdentity(m)
                    where closures.Length != 0
                    select GenericOpSpec.Define(id, def, closures);
        }
    }
}