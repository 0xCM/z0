//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdTarget<T> : ICmdTarget<T>
        where T : struct, ITool<T>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public CmdTarget(FS.FilePath path)
        {
            Path = Files.normalize(path);
        }
    }
}