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
        public CmdScript CreateCaseScript(NasmCase src)
        {
            var dst = text.buffer();
            dst.AppendLine("@echo off");
            dst.AppendLine(string.Format("set SrcId={0}", src.CaseId));
            var srcPath = src.SourcePath.Format(PathSeparator.BS);
            var binPath = src.BinPath.Format(PathSeparator.BS);
            var listPath = string.Format("{0}.list.asm",binPath);
            var toolPath = ToolPath().Format(PathSeparator.BS);

            dst.AppendLine(string.Format("set SrcPath={0}", srcPath));
            dst.AppendLine(string.Format("set BinPath={0}", binPath));
            dst.AppendLine(string.Format("set ListPath={0}", listPath));
            dst.AppendLine(string.Format("set tool={0}", toolPath));
            dst.AppendLine("set CmdSpec=%tool% %SrcPath% -o %BinPath% -f bin -l %ListPath%");
            dst.AppendLine("echo CmdSpec:%CmdSpec%");
            dst.AppendLine("%CmdSpec%");
            var expr = ToolCmd.expr(dst.Emit());
            return ToolCmd.script(src.CaseId,expr);
        }
    }
}