//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    public class DotNet : AppService<DotNet>
    {
        public void DumpImages(byte major = 3, byte minor = 1, byte revision = 12)
        {
            var emitter = MemoryEmitter.create(Wf);
            var src = Db.SymbolPaths().DotNetSymbolDir(major, minor, revision);
            if(!src.Exists)
            {
                Wf.Error(FS.Msg.DirDoesNotExist.Format(src));
                return;
            }
            var dst = Db.DotNetImageDumps().DumpDir(major, minor, revision);
            dst.Clear();
            emitter.DumpImages(src, dst);
        }
    }
}