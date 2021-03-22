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
        FS.FilePath TablePath(FS.FileName file)
            => Root + file;

        void Clear()
            => Root.Clear();
    }
}