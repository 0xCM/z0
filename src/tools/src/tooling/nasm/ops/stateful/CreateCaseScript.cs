//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public NasmCaseScript CreateCaseScript(Identifier name)
        {
            var @case = new NasmCase();
            @case.CaseId = name;
            @case.SourcePath = Input(FS.file(name.Format(), FS.Asm));
            @case.BinPath = Output(FS.file(name.Format(), FS.Bin));
            @case.ListPath = FS.path(string.Format("{0}.list.asm",@case.BinPath));
            return CreateCaseScript(@case);
        }

        public NasmCaseScript CreateCaseScript(NasmCase src)
        {
            var dst = text.buffer();
            dst.AppendLine("@echo off");
            dst.AppendLine(string.Format("set SrcId={0}", src.CaseId));
            var srcPath = src.SourcePath.Format(PathSeparator.BS);
            var binPath = src.BinPath.Format(PathSeparator.BS);
            var listPath = src.ListPath.Format(PathSeparator.BS);
            var toolPath = ToolPath().Format(PathSeparator.BS);

            dst.AppendLine(string.Format("set SrcPath={0}", srcPath));
            dst.AppendLine(string.Format("set BinPath={0}", binPath));
            dst.AppendLine(string.Format("set ListPath={0}", listPath));
            dst.AppendLine(string.Format("set tool={0}", toolPath));
            dst.AppendLine("set CmdSpec=%tool% %SrcPath% -o %BinPath% -f bin -l %ListPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine("%CmdSpec%");

            var cmdpath = Script(FS.file(src.CaseId.Format(), FS.Cmd));
            cmdpath.Overwrite(dst.Emit());

            return new NasmCaseScript(src,cmdpath);
        }
    }
}