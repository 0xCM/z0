//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataFiles : IFileArchive
    {
        IEnumerable<FS.FilePath> XmlFiles()
            => Files(Xml);

        IEnumerable<FS.FilePath> CsvFiles()
            => Files(Csv);

        IEnumerable<FS.FilePath> IndexFiles()
            => Files(Idx);
    }
}