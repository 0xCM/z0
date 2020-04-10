//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Characterizes a type that supports operation discovery
    /// </summary>
    public interface IApiCatalog
    {
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] HostTypes {get;}

        /// <summary>
        /// Specifies the number of service hosts described by the catalog
        /// </summary>
        int HostCount => HostTypes.Length;

        /// <summary>
        /// Specifies whether the catalog describes any service hosts
        /// </summary>
        bool IsNonEmpty => HostCount != 0;

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        Assembly Part {get;}

        /// <summary>
        /// The api hosts known to the catalog
        /// </summary>
        ApiHost[] ApiHosts {get;}
        
        /// <summary>
        /// The known generic api hosts
        /// </summary>
        ApiHost[] GenericApiHosts {get;}

        /// <summary>
        /// The known direct api hosts
        /// </summary>
        ApiHost[] DirectApiHosts {get;}

        /// <summary>
        /// The global data resource index
        /// </summary>
        BinaryResources Resources {get;}

        /// <summary>
        /// Specifies whether the catalog contains content from an identifid assembly
        /// </summary>
        bool IsIdentified
            => PartId != 0;

        /// <summary>
        /// Specifies the number of api hosts described by the catalog
        /// </summary>
        int ApiHostCount => ApiHosts.Length;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool HasApiHostContent => ApiHostCount != 0;

        /// <summary>
        /// The name of the catalog, which should be unique with respect to known catalogs
        /// </summary>
        string CatalogName
            => PartId.Format();        
    }
    
    /// <summary>
    /// Characterizes a type that provides access to an operation catalog
    /// </summary>
    public interface IApiCatalogProvider : IApiCatalog
    {
        /// <summary>
        /// The provided catalog
        /// </summary>
        IApiCatalog Operations {get;}
    }

    public sealed class EmptyCatalog : IApiCatalog
    {    
        public PartId PartId => PartId.None;

        public Assembly Part => Assembly.GetEntryAssembly();

        public ApiHost[] ApiHosts => new ApiHost[]{};

        public ApiHost[] GenericApiHosts => new ApiHost[]{};

        public ApiHost[] DirectApiHosts => new ApiHost[]{};

        public BinaryResources Resources => BinaryResources.Empty;

        public Type[] HostTypes => new Type[]{};

    }
}