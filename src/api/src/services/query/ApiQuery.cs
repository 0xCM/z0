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

    using static memory;

    [ApiHost(ApiNames.ApiQuery, true)]
    public readonly partial struct ApiQuery
    {
        /// <summary>
        /// Creates a system-level api catalog over a specified component set
        /// </summary>
        /// <param name="src">The source components</param>
        [Op]
        public static IGlobalApiCatalog catalog(Index<Assembly> src)
        {
            var candidates = src.Where(x => x.IsPart());
            var parts = candidates.Select(TryGetPart).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id).Array();
            return new GlobalApiCatalog(parts);
        }

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        [Op]
        static Option<IPart> TryGetPart(Assembly src)
        {
            try
            {
                return root.some(src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).FirstOrDefault());
            }
            catch(Exception e)
            {
                term.error(text.format("Assembly {0} | {1}", src.GetSimpleName(), e));
                return root.none<IPart>();
            }
        }

        public static ApiGroupNG[] ImmDirect(IApiHost host, RefinementClass kind)
            => from g in direct(host)
                let imm = ImmGroup(host, g, kind)
                where !imm.IsEmpty
                select g;

        public static ApiMethodG[] ImmGeneric(IApiHost host, RefinementClass kind)
            => generic(host).Where(op => op.Method.AcceptsImmediate(kind));

        static MethodInfo[] TaggedOps(IApiHost src)
            => src.Methods.Storage.Tagged<OpAttribute>();

        static ApiGroupNG[] direct(IApiHost src)
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new ApiGroupNG(ApiUri.opid(d.Key), src, d)).Array();

        static IEnumerable<ApiMethodNG> DirectOpSpecs(IApiHost src)
            => from m in TaggedOps(src).NonGeneric() select new ApiMethodNG(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static ApiMethodG[] generic(IApiHost src)
             => from m in TaggedOps(src).OpenGeneric()
                let closures = ApiIdentityKinds.NumericClosureKinds(m)
                where closures.Length != 0
                select new ApiMethodG(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static ApiGroupNG ImmGroup(IApiHost host, ApiGroupNG g, RefinementClass kind)
            => new ApiGroupNG(g.GroupId, host,
                g.Members.Storage.Where(m => m.Method.AcceptsImmediate(kind) && m.Method.ReturnsVector()));

       static IMultiDiviner Diviner
            => MultiDiviner.Service;
    }
}