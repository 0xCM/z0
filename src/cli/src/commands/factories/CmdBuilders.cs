namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static EmitImageHeadersCmd EmitImageHeaders(this CmdBuilder wf)
            => default;

        [MethodImpl(Inline), Op]
        public static EmitILTablesCmd EmitILTables(this CmdBuilder wf, FS.FilePath src)
        {
            var dst = new EmitILTablesCmd();
            dst.Source = src;
            dst.Target = wf.Db.Doc(src.FileName.WithoutExtension.Name, FileExtensions.Csv);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static EmitCliTableDocCmd EmitCilTableDoc(this CmdBuilder wf, FS.FilePath src)
        {
            var dst = new EmitCliTableDocCmd();
            dst.Source = src;
            dst.Target = wf.Db.Doc(src.FileName.WithoutExtension.Name, FileExtensions.Txt);
            return dst;
        }
    }
}