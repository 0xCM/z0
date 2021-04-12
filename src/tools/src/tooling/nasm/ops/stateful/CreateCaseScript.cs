//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    partial class Nasm
    {
        public NasmCaseScript CreateCaseScript(Identifier name, FS.FolderPath dst)
        {
            var @case = new NasmCase();
            @case.CaseId = name;
            @case.SourcePath = input(dst,  FS.file(name.Format(), FS.Asm));
            @case.BinPath = output(dst, FS.file(name.Format(), FS.Bin));
            @case.ListPath = FS.path(string.Format("{0}.list.asm", @case.BinPath));
            return CreateCaseScript(@case, Script(dst, FS.file(name.Format(), FS.Cmd)));
        }

        public NasmCaseScript CreateCaseScript(NasmCase src, FS.FilePath dst)
        {
            var buffer = text.buffer();
            buffer.AppendLine("@echo off");
            buffer.AppendLine(string.Format("set SrcId={0}", src.CaseId));
            buffer.AppendLine(string.Format("set SrcPath={0}", format(src.SourcePath)));
            buffer.AppendLine(string.Format("set BinPath={0}", format(src.BinPath)));
            buffer.AppendLine(string.Format("set ListPath={0}", format(src.ListPath)));
            buffer.AppendLine(string.Format("set tool={0}", format(ToolPath())));
            buffer.AppendLine("set CmdSpec=%tool% %SrcPath% -o %BinPath% -f bin -l %ListPath%");
            buffer.AppendLine("echo CmdSpec:%CmdSpec%");
            buffer.AppendLine("%CmdSpec%");
            dst.Overwrite(buffer.Emit());
            return new NasmCaseScript(src, dst);
        }
    }
}