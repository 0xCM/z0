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

    public interface IOpSpecifier<S>    
        where S : OpSpec
    {
        IEnumerable<S> FromHost(Type host);
    }    


    public static class OpSpecs
    {
        static IEnumerable<DirectOpSpec> individuals(ApiHost host)
            => from m in host.DeclaredMethods.Attributed<OpAttribute>().NonGeneric()
                select DirectOpSpec.Define(host,Identity.identify(m), m);

        public static IEnumerable<DirectOpGroupSpec> direct(ApiHost host)
            => from d in individuals(host).GroupBy(op => op.Id)
                let id = OpIdentity.Define(d.Key)
                select DirectOpGroupSpec.Define(host, id, d);                    

        public static IEnumerable<GenericOpSpec> generic(ApiHost host)
            => from m in host.DeclaredMethods.Attributed<OpAttribute>().OpenGeneric()
                let def = m.GetGenericMethodDefinition()
                let closures = m.NumericClosures().ToArray()
                let id = Identity.generic(m)
                where closures.Length != 0
                select GenericOpSpec.Define(host,id, def, closures);

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
                select OpClosureInfo.Define(op.Host, id, k, op.Root.MakeGenericMethod(pt.Value)); 
    }
}