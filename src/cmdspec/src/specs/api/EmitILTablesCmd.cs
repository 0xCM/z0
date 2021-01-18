//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct EmitILTablesCmd : ICmd<EmitILTablesCmd>
    {
        public const string CmdName = "emit-il-tables";

        public FS.FilePath Source;

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitILTablesCmd EmitILTables(this CmdBuilder wf, FS.FilePath src)
        {
            var dst = new EmitILTablesCmd();
            dst.Source = src;
            dst.Target = wf.Db.Doc(src.FileName.WithoutExtension.Name, FileExtensions.Csv);
            return dst;
        }
    }
}