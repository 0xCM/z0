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
    using static Seq;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        internal static IWfShell clone(IWfShell src, WfHost host, IPolyStream random, LogLevel verbosity)
            => new WfShell(src.Init, src.Ct, src.WfSink, src.Broker, host, random, verbosity, src.Router);

        public static void render(in WfInitStatus src, ITextBuffer dst)
        {
            dst.AppendSettingLine(nameof(src.AppConfigPath), src.AppConfigPath);
            dst.AppendSettingLine(nameof(src.Args),  delimit(src.AppConfigPath).Format());
            dst.AppendSettingLine(nameof(src.Controller), src.Controller.Format());
            dst.AppendSettingLine(nameof(src.LogConfig), WfLogs.format(src.LogConfig));
            dst.AppendSettingLine(nameof(src.Parts), delimit(src.Parts).Format());
            dst.AppendSettingLine(nameof(src.StartTS), src.StartTS.Format());
            dst.AppendSettingLine(nameof(src.PathConfigTime), src.PathConfigTime.Format());
            dst.AppendSettingLine(nameof(src.InitConfigTime), src.InitConfigTime.Format());
            dst.AppendSettingLine(nameof(src.ShellCreateTime), src.ShellCreateTime.Format());
            dst.AppendSettingLine(nameof(src.FinishTS), src.FinishTS.Format());
        }
    }
}