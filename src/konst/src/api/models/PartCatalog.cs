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
        public ApiDataType[] DataTypeHosts {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public ApiHost[] OperationHosts {get;}

        /// <summary>
        /// The api service types types defined by the assembly
        /// </summary>
        public Type[] ServiceHostTypes {get;}

        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        public IApiHost[] ApiHosts {get;}

        public PartCatalog(IPart part, ApiDataType[] dtHosts, ApiHost[] opHosts, Type[] svcHostTypes)
        {
            PartId = part.Id;
            Owner = part.Owner;
            DataTypeHosts = dtHosts;
            OperationHosts = opHosts;
            ServiceHostTypes = svcHostTypes;
            ApiHosts = DataTypeHosts.Cast<IApiHost>().Concat(OperationHosts.Cast<IApiHost>()).Array();
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
            => (OperationHosts.Length + DataTypeHosts.Length) != 0;
    }
}