//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct ApiCatalog : IApiCatalog
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
        /// The api hosts known to the catalog
        /// </summary>
        public ApiHost[] Hosts {get;}

        public Type[] FunFactories {get;}

        public ApiHost[] GenericHosts {get;}

        public ApiHost[] DirectHosts {get;}

        public ApiCatalog(PartId PartId, Assembly Owner, ApiHost[] Hosts, Type[] FunFactories, ApiHost[] GenericHosts, ApiHost[] DirectHosts)
        {
            this.PartId = PartId;
            this.Owner = Owner;
            this.Hosts = Hosts;
            this.FunFactories = FunFactories;
            this.GenericHosts = GenericHosts;
            this.DirectHosts = DirectHosts;
        }
    }
}