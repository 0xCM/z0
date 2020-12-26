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

    using static Konst;

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
        public Assembly Owner {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public ApiDataTypes ApiDataTypes {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public ApiHost[] OperationHosts {get;}

        /// <summary>
        /// The api service types types defined by the assembly
        /// </summary>
        public Type[] ServiceHosts {get;}

        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        public ApiHosts ApiHosts {get;}

        /// <summary>
        /// The host-defined operations
        /// </summary>
        public MethodInfo[] Operations {get;}

        public Module ManifestModule
        {
            [MethodImpl(Inline)]
            get => Owner.ManifestModule;
        }

        public ApiPartCatalog(PartId part, Assembly component, ApiDataType[] dtHosts, ApiHost[] opHosts, Type[] svcHostTypes)
        {
            PartId = part;
            Owner = component;
            ApiDataTypes = new ApiDataTypes(PartId, dtHosts);
            OperationHosts = opHosts;
            ServiceHosts = svcHostTypes;
            ApiHosts = dtHosts.Cast<IApiHost>().Cast<IApiHost>().Concat(OperationHosts.Cast<IApiHost>()).Array();
            Operations = ApiHosts.Storage.SelectMany(x => x.Methods);
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
            => (OperationHosts.Length + ApiDataTypes.Count) != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        public bool IsEmpty
            => (OperationHosts.Length + ApiDataTypes.Count) == 0;
    }
}