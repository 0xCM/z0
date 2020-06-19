//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

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

        internal ApiCatalog(PartId PartId, Assembly Owner, ApiHost[] Hosts, Type[] FunFactories, ApiHost[] GenericHosts, ApiHost[] DirectHosts)
        {
            this.PartId = PartId;
            this.Owner = Owner;
            this.Hosts = Hosts;
            this.FunFactories = FunFactories;
            this.GenericHosts = GenericHosts;
            this.DirectHosts = DirectHosts;
        }

        // ApiCatalog(Assembly source, PartId id)
        // {
        //     PartId = id;
        //     Owner = source;
        //     Hosts = ApiHost.HostTypes(Owner).Select(t => ApiHost.Define(id, t)).ToArray();
        //     DirectHosts = Hosts.Where(h => h.HostKind.DefinesDirectOps()).ToArray();
        //     GenericHosts = Hosts.Where(h => h.HostKind.DefinesGenericOps()).ToArray();
        //     FunFactories = FactoryTypes(Owner).ToArray();            
        // }
    }
}