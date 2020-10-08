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
    public interface IApiPartCatalog
    {
        /// <summary>
        /// The defining assembly
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The operation hosts
        /// </summary>
        ApiHost[] OperationHosts {get;}

        /// <summary>
        /// The data type hosts
        /// </summary>
        ApiDataTypes ApiDataTypes {get;}

        /// <summary>
        /// The known types that reify contracted operation services, potentially generic
        /// </summary>
        Type[] ServiceHosts {get;}

        /// <summary>
        /// The identity of the assembly that defines and owns the catalog
        /// </summary>
        PartId PartId {get;}


        /// <summary>
        /// The api hosts known to the catalog, including both operation and data type hosts
        /// </summary>
        IApiHost[] ApiHosts {get;}

        /// <summary>
        /// The operations defined by <see cref='ApiHosts'/>
        /// </summary>
        MethodInfo[] Operations {get;}

        /// <summary>
        /// Specifies whether the catalog contains content from an identified assembly
        /// </summary>
        bool IsIdentified
            => PartId != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool IsNonEmpty
            => (OperationHosts.Length + ApiDataTypes.Count) != 0;

        /// <summary>
        /// Specifies whether the catalog describes any api hosts
        /// </summary>
        bool IsEmpty
            => (OperationHosts.Length + ApiDataTypes.Count) == 0;
    }
}