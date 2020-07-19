//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

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
        public ApiDataType[] DataTypes {get;}

        /// <summary>
        /// The data types defined by the assembly
        /// </summary>
        public ApiHost[] Hosts {get;}

        /// <summary>
        /// The api service types types defined by the assembly
        /// </summary>
        public Type[] ServiceTypes {get;}

        public ApiHost[] GenericHosts {get;}

        public ApiHost[] DirectHosts {get;}

        public ApiCatalog(PartId PartId, Assembly Owner, ApiDataType[] DataTypes, ApiHost[] Hosts, Type[] ServiceTypes, ApiHost[] GenericHosts, ApiHost[] DirectHosts)
        {
            this.PartId = PartId;
            this.Owner = Owner;
            this.Hosts = Hosts;
            this.DataTypes = DataTypes;
            this.ServiceTypes = ServiceTypes;
            this.GenericHosts = GenericHosts;
            this.DirectHosts = DirectHosts;
        }
    }
}