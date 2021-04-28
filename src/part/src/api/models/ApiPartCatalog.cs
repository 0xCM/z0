//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a catalog over a <see cref='IPart'/>
    /// </summary>
    public readonly struct ApiPartCatalog : IApiPartCatalog
    {
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
        public Index<MethodInfo> Operations {get;}

        public ApiPartCatalog(PartId part, Assembly component, ApiRuntimeType[] apitypes, IApiHost[] apihosts, Type[] svchosts)
        {
            PartId = part;
            Component = component;
            ApiTypes = apitypes;
            OperationHosts = apihosts.Map(h => (IApiHost)h);
            ServiceHosts = svchosts;
            ApiHosts = apihosts;
            Operations = apihosts.SelectMany(x => x.Methods);
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
    }
}