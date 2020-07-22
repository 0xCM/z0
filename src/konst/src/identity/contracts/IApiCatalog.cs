//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    /// <summary>
    /// Characterizes the api set exposed by a part
    /// </summary>
    public interface IPartCatalog
    {
        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] ServiceHostTypes {get;}

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        PartId PartId {get;}

        /// <summary>
        /// The assembly that defines and owns the catalog
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The data type hosts
        /// </summary>
        ApiDataType[] DataTypeHosts {get;}

        /// <summary>
        /// The operation hosts
        /// </summary>
        ApiHost[] OperationHosts {get;}
        
        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        IApiHost[] ApiHosts 
            => DataTypeHosts.Cast<IApiHost>().Concat(OperationHosts.Cast<IApiHost>()).Array();
        
        /// <summary>
        /// Specifies whether the catalog contains content from an identifid assembly
        /// </summary>
        bool IsIdentified
            => PartId != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool IsNonEmpty 
            => (OperationHosts.Length + DataTypeHosts.Length) != 0;
    }    
}