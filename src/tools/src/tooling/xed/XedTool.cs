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

    using Z0.Asm;

    public sealed partial class XedTool : ToolService<XedTool>
    {
        const string SummaryFlags = "-isa-set -64";

        const string DetailFlags = "-v 4 -isa-set -64";

        static string format(AsmOc id)
            => id.ToString();

        public XedTool()
            : base(Toolsets.xed)
        {

        }

        public XedCase DefineCase(AsmOc id, FS.FolderPath dst)
        {
            var @case = new XedCase();
            @case.CaseId = format(id);
            @case.InputPath = input(dst,  binfile(format(id)));
            @case.SummaryPath = output(dst, ToolFile(format(id), "summary", FS.Log));
            @case.DetailPath =  output(dst, ToolFile(format(id), "detail", FS.Log));
            return @case;
        }

        public void AppendScript(XedCase src, ITextBuffer dst)
        {
            dst.AppendLine("@echo off");
            dst.AppendLineFormat("set tool={0}", format(ToolPath()));
            dst.AppendLineFormat("set case={0}", src.CaseId);
            dst.AppendLineFormat("set SummaryFlags={0}", SummaryFlags);
            dst.AppendLineFormat("set DetailFlags={0}", DetailFlags);
            dst.AppendLineFormat("set SrcPath={0}", format(src.InputPath));
            dst.AppendLineFormat("set DetailPath={0}", format(src.DetailPath));
            dst.AppendLineFormat("set SummaryPath={0}", format(src.SummaryPath));

            dst.AppendLine("set CmdSpec=%tool% %SummaryFlags% -ir %SrcPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine("%CmdSpec% > %SummaryPath%");

            dst.AppendLine("set CmdSpec=%tool% %DetailFlags% -ir %SrcPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine("%CmdSpec% > %DetailPath%");
        }

        public ToolScript<XedCase> CreateScript(XedCase src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            AppendScript(src,buffer);
            dst.Overwrite(buffer.Emit());
            return (src, dst);
        }
    }
}