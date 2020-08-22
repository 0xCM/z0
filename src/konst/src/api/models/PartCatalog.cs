//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    public readonly struct PartCatalog : IPartCatalog
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
        public ApiDataType[] ApiDataTypes {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public ApiHost[] Operations {get;}

        /// <summary>
        /// The api service types types defined by the assembly
        /// </summary>
        public Type[] ServiceHosts {get;}

        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        public IApiHost[] ApiHosts {get;}

        public PartCatalog(IPart part, ApiDataType[] dtHosts, ApiHost[] opHosts, Type[] svcHostTypes)
        {
            PartId = part.Id;
            Owner = part.Owner;
            ApiDataTypes = dtHosts;
            Operations = opHosts;
            ServiceHosts = svcHostTypes;
            ApiHosts = ApiDataTypes.Cast<IApiHost>().Concat(Operations.Cast<IApiHost>()).Array();
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
            => (Operations.Length + ApiDataTypes.Length) != 0;
    }
}