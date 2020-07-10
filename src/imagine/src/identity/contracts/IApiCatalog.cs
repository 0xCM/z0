//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Characterizes the api set exposed by a part
    /// </summary>
    public interface IPartCatalog
    {
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] FunFactories {get;}

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        ApiHost[] Hosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        ApiHost[] GenericHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        ApiHost[] DirectHosts {get;}

        /// <summary>
        /// Specifies whether the catalog contains content from an identifid assembly
        /// </summary>
        bool IsIdentified
            => PartId != 0;

        /// <summary>
        /// Specifies the number of api hosts described by the catalog
        /// </summary>
        int ApiHostCount 
            => Hosts.Length;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool HasApiHostContent 
            => ApiHostCount != 0;

        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => PartId.Format();        

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int HostCount 
            => FunFactories.Length;

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty 
            => HostCount != 0;
    }    
}