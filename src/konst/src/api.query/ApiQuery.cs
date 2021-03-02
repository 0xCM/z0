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

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly partial struct ApiQuery
    {
        // public static ApiGroupNG[] ImmDirect(ApiHost host, RefinementClass kind)
        //     => from g in direct(host)
        //         let imm = ImmGroup(host, g, kind)
        //         where !imm.IsEmpty
        //         select g;

        public static ApiGroupNG[] ImmDirect(IApiHost host, RefinementClass kind)
            => from g in direct(host)
                let imm = ImmGroup(host, g, kind)
                where !imm.IsEmpty
                select g;

        // public static ApiMethodG[] ImmGeneric(ApiHost host, RefinementClass kind)
        //     => generic(host).Where(op => op.Method.AcceptsImmediate(kind));

        public static ApiMethodG[] ImmGeneric(IApiHost host, RefinementClass kind)
            => generic(host).Where(op => op.Method.AcceptsImmediate(kind));

        static MethodInfo[] TaggedOps(IApiHost src)
            => src.Methods.Storage.Tagged<OpAttribute>();

        // static ApiGroupNG[] direct(ApiHost src)
        //     => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
        //         select new ApiGroupNG(OpIdentityParser.parse(d.Key), src, d)).Array();

        static ApiGroupNG[] direct(IApiHost src)
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new ApiGroupNG(OpIdentityParser.parse(d.Key), src, d)).Array();

        static IEnumerable<ApiMethodNG> DirectOpSpecs(IApiHost src)
            => from m in TaggedOps(src).NonGeneric() select new ApiMethodNG(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static ApiMethodG[] generic(IApiHost src)
             => from m in TaggedOps(src).OpenGeneric()
                let closures = ApiJit.NumericClosureKinds(m)
                where closures.Length != 0
                select new ApiMethodG(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        // static ApiMethodG[] generic(ApiHost src)
        //      => from m in TaggedOps(src).OpenGeneric()
        //         let closures = ApiJit.NumericClosureKinds(m)
        //         where closures.Length != 0
        //         select new ApiMethodG(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static ApiGroupNG ImmGroup(IApiHost host, ApiGroupNG g, RefinementClass kind)
            => new ApiGroupNG(g.GroupId, host,
                g.Members.Storage.Where(m => m.Method.AcceptsImmediate(kind) && m.Method.ReturnsVector()));

       static IMultiDiviner Diviner
            => MultiDiviner.Service;
    }
}