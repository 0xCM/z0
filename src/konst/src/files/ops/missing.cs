//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Part;

    partial struct FS
    {
        [Op]
        public static FileNotFoundException missing(FS.FilePath src)
            => new FileNotFoundException(src.Name);
    }
}