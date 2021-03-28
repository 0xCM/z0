//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Diagnostics;

    [Cmd(CmdName)]
    public struct EmitProcessDumpCmd : ICmd<EmitProcessDumpCmd>
    {
        public const string CmdName = "emit-process-dump";

        public Process Source;

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [Op]
        public static EmitProcessDumpCmd EmitProcessDump(this WfCmdBuilder builder)
        {
            var dst = new EmitProcessDumpCmd();
            dst.Source = Runtime.CurrentProcess;
            dst.Target = builder.Db.DumpFilePath(dst.Source.ProcessName);
            return dst;
        }

        [Op]
        public static EmitProcessDumpCmd EmitProcessDump(this WfCmdBuilder builder, Process src)
        {
            var dst = new EmitProcessDumpCmd();
            dst.Source = src;
            dst.Target = builder.Db.DumpFilePath(dst.Source.ProcessName);
            return dst;
        }
    }
}