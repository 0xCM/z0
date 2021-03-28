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
    }
}