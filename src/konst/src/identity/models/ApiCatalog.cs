//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct ApiCatalog : IPartCatalog
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

        public ApiCatalog(IPart part, ApiDataType[] DataTypeHosts, ApiHost[] OperationHosts, Type[] ServiceHostTypes)
        {
            this.PartId = part.Id;
            this.Owner = part.Owner;
            this.DataTypeHosts = DataTypeHosts;
            this.OperationHosts = OperationHosts;
            this.ServiceHostTypes = ServiceHostTypes;
        }
    }
}