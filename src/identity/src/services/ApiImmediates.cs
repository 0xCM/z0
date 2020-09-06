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
    using System.Runtime.CompilerServices;

    public readonly struct ApiImmediates
    {
        public static DirectApiGroup[] direct(ApiHost host, ImmRefinementKind refinment)
            => from g in direct(host)
                let immg = ImmGroup(host, g, refinment)
                where !immg.IsEmpty
                select g;

        public static GenericApiMethod[] generic(ApiHost host, ImmRefinementKind refinment)
            => generic(host).Where(op => op.Method.AcceptsImmediate(refinment));

        static MethodInfo[] TaggedOps(IApiHost src)
            => src.Methods.Tagged<OpAttribute>();

        static DirectApiGroup[] direct(ApiHost src)
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new DirectApiGroup(OpIdentityParser.parse(d.Key), src, d)).Array();

        static IEnumerable<DirectApiMethod> DirectOpSpecs(IApiHost src)
            => from m in TaggedOps(src).NonGeneric() select new DirectApiMethod(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static GenericApiMethod[] generic(ApiHost src)
             => from m in TaggedOps(src).OpenGeneric()
                let closures = ClosureKinds.numeric(m)
                where closures.Length != 0
                select new GenericApiMethod(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g, ImmRefinementKind refinment)
            => new DirectApiGroup(g.GroupId, host,
                g.Members.Where(m => m.Method.AcceptsImmediate(refinment) && m.Method.ReturnsVector()));

       static IMultiDiviner Diviner
            => MultiDiviner.Service;
    }
}