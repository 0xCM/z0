//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Captures workflow configuration data
    /// </summary>
    public struct WfInit : IWfInit
    {
        /// <summary>
        /// The entry assembly
        /// </summary>
        public Assembly Control {get;}

        /// <summary>
        /// The entry assembly identifier
        /// </summary>
        public PartId ControlId {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] PartIdentities {get;}

        /// <summary>
        /// The context root
        /// </summary>
        public IWfContext Context {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        public WfLogConfig LogConfig {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        public IApiParts ApiParts {get;}

        public ISystemApiCatalog Api {get;}

        public FS.FolderPath DbRoot {get;}

        [MethodImpl(Inline)]
        public WfInit(FS.FolderPath dbRoot, IWfContext ctx, WfLogConfig logConfig, PartId[] parts)
        {
            DbRoot = dbRoot;
            Context = ctx;
            ApiParts = ctx.ApiParts;
            Control = ctx.Controller;
            Api = ctx.ApiParts.Api;
            ControlId = ctx.Controller.Id;
            LogConfig = logConfig;
            PartIdentities = parts;
        }

        public FS.FolderPath ResDir
            => FS.dir(Context.Paths.ResourceRoot.Name);

        public FS.FolderPath IndexDir
            => ResDir + FS.folder("index");

        public IWfContext Shell
            => Context;
    }
}