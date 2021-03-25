//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableArchive : IFileArchive
    {
        ParseResult<TextDoc> Document(FS.FilePath src)
            => TextDocs.parse(src);

        FS.FilePath TablePath(FS.FileName file)
            => Root + file;

        void Clear()
            => Root.Clear();
    }
}