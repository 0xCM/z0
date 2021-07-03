//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    using Z0.Tools;

    using Svc = Tools;

    [ApiHost]
    public static partial class XTools
    {
        [Op]
        public static ScriptRunner ScriptRunner(this IWfRuntime wf)
            => Z0.ScriptRunner.create(wf.Db());

        [Op]
        public static ScriptRunner ScriptRunner(this IEnvPaths paths)
            => Z0.ScriptRunner.create(paths);

        [Op]
        public static MsDocPipe MsDocs(this IWfRuntime wf)
            => Svc.MsDocPipe.create(wf);

        [Op]
        public static DotNet DotNet(this IWfRuntime wf)
            => Svc.DotNet.create(wf);

        [Op]
        public static LlvmAssetCatalog LlvmAssets(this IWfRuntime wf)
            => Svc.LlvmAssetCatalog.create(wf);
    }
}