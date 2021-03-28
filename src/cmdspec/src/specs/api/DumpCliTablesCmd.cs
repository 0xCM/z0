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
    public struct DumpCliTablesCmd : ICmd<DumpCliTablesCmd>
    {
        public const string CmdName = "dump-cli-tables";

        public FS.FilePath Source;

        public FS.FilePath Target;
    }

    sealed class DumpCliTablesAug : CmdAugmenter<DumpCliTablesAug,DumpCliTablesCmd>
    {
        public override ref DumpCliTablesCmd Augment(ref DumpCliTablesCmd cmd)
        {
            cmd = Builder.DumpCliTables(cmd.Source);
            return ref cmd;
        }
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static DumpCliTablesCmd DumpCliTables(this WfCmdBuilder wf, FS.FilePath src)
        {
            var dst = new DumpCliTablesCmd();
            dst.Source = src;
            dst.Target = wf.Db.Doc(src.FileName.WithoutExtension.Name, FS.Extensions.Txt);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static DumpCliTablesCmd DumpCliTables(this WfCmdBuilder wf, Assembly src)
        {
            var dst = new DumpCliTablesCmd();
            dst.Source = FS.path(src.Location);
            dst.Target = wf.Db.Doc(dst.Source.FileName.WithoutExtension.Name, FS.Extensions.Txt);
            return dst;
        }
    }
}