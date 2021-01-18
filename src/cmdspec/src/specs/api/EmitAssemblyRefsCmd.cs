//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitAssemblyRefsCmd : ICmd<EmitAssemblyRefsCmd>
    {
        public const string CmdName = "emit-assembly-refs";

        public FS.Files Sources;

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        public static EmitAssemblyRefsCmd EmitAssemblyRefs(this CmdBuilder builder, FS.Files sources, FS.FilePath target)
        {
            var cmd = new EmitAssemblyRefsCmd();
            cmd.Sources = sources;
            cmd.Target = target;
            return cmd;
        }

        public static EmitAssemblyRefsCmd EmitAssemblyRefs(this CmdBuilder builder)
        {
            var cmd = new EmitAssemblyRefsCmd();
            cmd.Sources = FS.dir(@"J:\tools\netsdk\sdk\3.1.403").Files(FileExtensions.Dll);
            cmd.Target = builder.Db.IndexFile("assembly-refs");
            return cmd;
        }
    }
}