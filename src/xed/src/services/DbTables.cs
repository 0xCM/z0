//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    struct DbTables<S> : ITableArchive
    {
        public IEnvPaths Paths {get;}

        public S Subject {get;}

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public DbTables(IEnvPaths paths, S subject)
        {
            Paths = paths;
            Subject = subject;
            Root = paths.TableDir(subject.ToString());
        }

        public IEnumerable<FS.FilePath> Files()
            => Root.Files(FS.Csv, true);
    }
}