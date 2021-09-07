//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class FileTypes
    {
        public static FS.FileExt ext(FileKind kind)
            => FS.ext(Symbols.index<FileKind>()[kind].Expr.Format());
    }
}