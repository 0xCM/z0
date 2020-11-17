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

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static string[] args()
            => Environment.GetCommandLineArgs();

        [MethodImpl(Inline), Op]
        public static Assembly controller()
            => Assembly.GetEntryAssembly();

        [MethodImpl(Inline)]
        public static Assembly controller<A>()
            => typeof(A).Assembly;

        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath dbRoot()
            => EnvVars.Common.DbRoot;

        [MethodImpl(Inline), Op]
        public static FS.FolderPath logRoot()
            => dbRoot() + FS.folder("logs") + FS.folder("wf");

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath root)
            => logConfig(part, root, dbRoot());

        [MethodImpl(Inline)]
        public static WfSelfHost host(Type self)
            => new WfSelfHost(self);

        [MethodImpl(Inline), Op]
        public static IWfEventLog log(WfLogConfig config)
            => new WfEventLog(config);

        [Op]
        public static string format(WfExecToken src)
            => string.Format("{0}:{1}", src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static WfExecToken token(ulong src, ulong dst)
            => new WfExecToken(src, dst);
    }
}