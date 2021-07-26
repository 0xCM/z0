//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed partial class XedTool : ToolService<XedTool>
    {
        public XedTool()
            : base(Toolspace.xed)
        {

        }

        public XedCase DefineCase(string id, FS.FolderPath dst)
        {
            var @case = new XedCase();
            @case.CaseId = id;
            @case.InputPath = input(dst,  binfile(id));
            @case.SummaryPath = output(dst, ToolFile(id, "summary", FS.Log));
            @case.DetailPath =  output(dst, ToolFile(id, "detail", FS.Log));
            return @case;
        }

        public void AppendScript(XedCase src, ITextBuffer dst)
        {
            const string SummaryFlags = "-isa-set -64";
            const string DetailFlags = "-v 4 -isa-set -64";

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

        public ToolScript CreateScript(XedCase src)
        {
            var buffer = text.buffer();
            AppendScript(src, buffer);
            return new ToolScript(Toolspace.xed, buffer.Emit());
        }
    }
}