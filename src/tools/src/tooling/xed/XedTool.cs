//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public sealed partial class XedTool : ToolService<XedTool>
    {
        const string SummaryFlags = "-isa-set -64";

        const string DetailFlags = "-v 4 -isa-set -64";

        public XedCase DefineCase(Identifier name, FS.FolderPath? dst = null)
        {
            var @case = new XedCase();
            @case.CaseId = name;
            @case.ScriptPath = Script(dst ?? ScriptDir, FS.file(name.Format(), FS.Cmd));
            @case.SrcPath = Input(dst ?? InDir,  FS.file(name.Format(), FS.Bin));
            @case.SummaryPath = Output(dst ?? OutDir, FS.file(name.Format(), FS.Log));
            @case.DetailPath = Output(dst ?? OutDir, FS.file(string.Format("{0}.{1}", name, "detail"), FS.Log));
            return @case;
        }

        public CaseScript<XedCase> BuildScript(XedCase src)
        {
            var dst = text.buffer();
            dst.AppendLine("@echo off");
            dst.AppendLine(string.Format("set tool={0}", ToolPath().Format(PathSeparator.BS)));
            dst.AppendLine(string.Format("set case={0}", src.CaseId));
            dst.AppendLine(string.Format("set SummaryFlags={0}", SummaryFlags));
            dst.AppendLine(string.Format("set DetailFlags={0}", DetailFlags));
            dst.AppendLine(string.Format("set SrcPath={0}", src.SrcPath.Format(PathSeparator.BS)));
            dst.AppendLine(string.Format("set DetailPath={0}", src.DetailPath.Format(PathSeparator.BS)));
            dst.AppendLine(string.Format("set SummaryPath={0}", src.SummaryPath.Format(PathSeparator.BS)));

            dst.AppendLine("set CmdSpec=%tool% %SummaryFlags% -ir %SrcPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine(string.Format("%CmdSpec% > %SummaryPath%"));

            dst.AppendLine("set CmdSpec=%tool% %DetailFlags% -ir %SrcPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine(string.Format("%CmdSpec% > %DetailPath%"));

            src.ScriptPath.Overwrite(dst.Emit());
            return (src, src.ScriptPath);
        }
    }
}