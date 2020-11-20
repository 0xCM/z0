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
        public static void render(in WfConfigInfo src, ITextBuffer dst)
        {
            dst.AppendSettingLine(nameof(src.AppConfigPath), src.AppConfigPath);
            dst.AppendSettingLine(nameof(src.Args),  Delimited.list(src.AppConfigPath).Format());
            dst.AppendSettingLine(nameof(src.Controller), src.Controller.Format());
            dst.AppendSettingLine(nameof(src.LogConfig), src.LogConfig.Format());
            dst.AppendSettingLine(nameof(src.Parts), Delimited.list(src.Parts).Format());
        }

        [MethodImpl(Inline), Op]
        public static Assembly controller()
            => WfEnv.entry();

        [MethodImpl(Inline)]
        public static Assembly controller<A>()
            => typeof(A).Assembly;

        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath logRoot()
            => WfEnv.dbRoot() + FS.folder("logs") + FS.folder("wf");

        [Op]
        public static string format(WfExecToken src)
            => string.Format("{0}:{1}", src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static WfExecToken token(ulong src, ulong dst)
            => new WfExecToken(src, dst);
    }
}