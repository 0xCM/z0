//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;

    using static Part;

    partial struct FS
    {
        [Op]
        public static FileNotFoundException missing(FS.FilePath src)
            => new FileNotFoundException(src.Name);
    }
}