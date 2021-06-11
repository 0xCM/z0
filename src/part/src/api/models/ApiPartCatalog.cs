//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a catalog over a <see cref='IPart'/>
    /// </summary>
    public class ApiPartCatalog : IApiPartCatalog
    {
        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ApiPartCatalog create(IPart src)
            => create(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static ApiPartCatalog create(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiRuntimeType.complete(src), ApiHost.hosts(src), svchosts(src));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        static Type[] svchosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        public PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        public Assembly Component {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public Index<ApiRuntimeType> ApiTypes {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public Index<IApiHost> OperationHosts {get;}

        /// <summary>
        /// The api service types types defined by the assembly
        /// </summary>
        public Index<Type> ServiceHosts {get;}

        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        public ApiHosts ApiHosts {get;}

        /// <summary>
        /// The host-defined operations
        /// </summary>
        public Index<MethodInfo> Methods {get;}

        public ApiPartCatalog(PartId part, Assembly component, Index<ApiRuntimeType> apitypes, IApiHost[] apihosts, Type[] svchosts)
        {
            PartId = part;
            Component = component;
            ApiTypes = apitypes;
            OperationHosts = apihosts.Map(h => (IApiHost)h);
            ServiceHosts = svchosts;
            ApiHosts = apihosts;
            Methods = apihosts.SelectMany(x => x.Methods);
        }

        public Module ManifestModule
        {
            [MethodImpl(Inline)]
            get => Component.ManifestModule;
        }

        /// <summary>
        /// Specifies whether the catalog contains content from an identified assembly
        /// </summary>
        public bool IsIdentified
            => PartId != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        public bool IsNonEmpty
            => (OperationHosts.Length + ApiTypes.Count) != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        public bool IsEmpty
            => (OperationHosts.Length + ApiTypes.Count) == 0;

        public FS.FilePath ComponentPath
            => FS.path(Component.Location);

        public bool Host(ApiHostUri uri, out IApiHost host)
            => ApiHosts.Host(uri, out host);
    }
}