//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;

    [Free]
    public interface IWfInit
    {
        /// <summary>
        /// The context root
        /// </summary>
        IWfContext Shell {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        WfLogConfig Logs {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        IApiParts ApiParts {get;}

        /// <summary>
        /// The entry assembly
        /// </summary>
        Assembly Control {get;}

        /// <summary>
        /// The configured api set
        /// </summary>
        ISystemApiCatalog Api {get;}

        /// <summary>
        /// The controlling part
        /// </summary>
        PartId ControlId {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        PartId[] PartIdentities {get;}

        FS.FolderPath ResDir
            => FS.dir(Shell.Paths.ResourceRoot.Name);

        FS.FolderPath IndexDir
            => ResDir + FS.folder("index");
    }
}