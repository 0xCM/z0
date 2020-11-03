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
    using static z;

    /// <summary>
    /// Captures workflow configuration data
    /// </summary>
    public struct WfInit : IWfInit
    {
        /// <summary>
        /// The entry assembly
        /// </summary>
        internal Assembly Control {get;}

        /// <summary>
        /// The entry assembly identifier
        /// </summary>
        internal PartId ControlId {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        internal PartId[] PartIdentities {get;}

        /// <summary>
        /// The context root
        /// </summary>
        internal IWfContext Context {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        internal WfLogConfig Logs {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        internal IApiParts ApiParts {get;}

        public ISystemApiCatalog Api {get;}

        [MethodImpl(Inline)]
        public WfInit(IWfContext ctx, WfLogConfig logs, PartId[] parts)
        {
            Context = ctx;
            ApiParts = ctx.ApiParts;
            Control = ctx.Controller;
            Api = ctx.ApiParts.Api;
            ControlId = ctx.Controller.Id;
            Logs = logs;
            PartIdentities = parts;
        }

        IWfContext IWfInit.Shell
            => Context;

        IApiParts IWfInit.ApiParts
            => ApiParts;

        Assembly IWfInit.Control
            => Control;

        PartId IWfInit.ControlId
            => ControlId;

        PartId[] IWfInit.PartIdentities
            => PartIdentities;

        WfLogConfig IWfInit.Logs
            => Logs;
    }
}