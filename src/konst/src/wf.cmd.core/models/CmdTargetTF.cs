//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdTarget<T,F>
        where T : struct, ITool<T>
        where F : unmanaged
    {
        public FS.FilePath Path {get;}

        public F Kind {get;}

        [MethodImpl(Inline)]
        public CmdTarget(F kind, FS.FilePath path)
        {
            Kind = kind;
            Path = Files.normalize(path);
        }
    }
}
