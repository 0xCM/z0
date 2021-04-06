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
        [Op]
        public static IPart part(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).Single();

        [Op]
        public static ApiPartTypes types(IPart src)
            => new ApiPartTypes(src.Id, src.Owner.Types());

        [Op]
        public static ApiHostUri hosturi(Type t)
        {
            var attrib = t.Tag<ApiHostAttribute>();
            var name =  text.ifempty(attrib.MapValueOrDefault(a => a.HostName, t.Name), t.Name).ToLower();
            return new ApiHostUri(t.Assembly.Id(), name);
        }

        public static ApiGroupNG[] ImmDirect(IApiHost host, RefinementClass kind)
            => from g in direct(host)
                let imm = ImmGroup(host, g, kind)
                where !imm.IsEmpty
                select g;

        public static ApiMethodG[] ImmGeneric(IApiHost host, RefinementClass kind)
            => generic(host).Where(op => op.Method.AcceptsImmediate(kind));

        [Op]
        public static Index<ApiHostUri> NestedHosts(Type src)
        {
            var dst = root.list<ApiHostUri>();
            var nested = @readonly(src.GetNestedTypes());
            var count = nested.Length;
            for(var i=0; i<count; i++)
            {
                var candidate = skip(nested,i);
                var uri = candidate.HostUri();
                if(uri.IsNonEmpty)
                    dst.Add(uri);
            }
            return dst.ToArray();
        }

        static MethodInfo[] TaggedOps(IApiHost src)
            => src.Methods.Storage.Tagged<OpAttribute>();

        static ApiGroupNG[] direct(IApiHost src)
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new ApiGroupNG(ApiUri.opid(d.Key), src, d)).Array();

        static IEnumerable<ApiMethodNG> DirectOpSpecs(IApiHost src)
            => from m in TaggedOps(src).NonGeneric() select new ApiMethodNG(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static IMultiDiviner Diviner
            => MultiDiviner.Service;

        static ApiMethodG[] generic(IApiHost src)
             => from m in TaggedOps(src).OpenGeneric()
                let closures = ApiIdentityKinds.NumericClosureKinds(m)
                where closures.Length != 0
                select new ApiMethodG(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static ApiGroupNG ImmGroup(IApiHost host, ApiGroupNG g, RefinementClass kind)
            => new ApiGroupNG(g.GroupId, host,
                g.Members.Storage.Where(m => m.Method.AcceptsImmediate(kind) && m.Method.ReturnsVector()));
    }
}