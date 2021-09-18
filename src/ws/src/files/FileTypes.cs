//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public partial class FileTypes
    {
        public static FS.FileExt ext(FileKind src)
            => FS.ext(format(src));

        [Op]
        public static string format(FileKind src)
            => Symbols.index<FileKind>()[src].Expr.Format();

        public static ObjAsm objasm(FS.FilePath src)
            => src;

        public static AsmSyntaxLog asmsynlog(FS.FilePath src)
            => src;

        public static McAsm mcasm(FS.FilePath src)
            => src;

        public static YamlToken yamltok(FS.FilePath src)
            => src;
    }
}