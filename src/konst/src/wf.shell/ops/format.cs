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
            dst.AppendSettingLine(nameof(src.Args),  Seq.delimited(src.AppConfigPath).Format());
            dst.AppendSettingLine(nameof(src.Controller), src.Controller.Format());
            dst.AppendSettingLine(nameof(src.LogConfig), WfLogs.format(src.LogConfig));
            dst.AppendSettingLine(nameof(src.Parts), Seq.delimited(src.Parts).Format());
            dst.AppendSettingLine(nameof(src.StartTS), src.StartTS.Format());
            dst.AppendSettingLine(nameof(src.PathConfigTime), src.PathConfigTime.Format());
            dst.AppendSettingLine(nameof(src.InitConfigTime), src.InitConfigTime.Format());
            dst.AppendSettingLine(nameof(src.ShellCreateTime), src.ShellCreateTime.Format());
            dst.AppendSettingLine(nameof(src.FinishTS), src.FinishTS.Format());
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
        public static WfExecToken token(ulong seq)
            => new WfExecToken(seq, timestamp());
    }
}