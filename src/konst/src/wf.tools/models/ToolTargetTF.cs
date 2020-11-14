//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolTarget<T,F> : IToolTarget<T,F>
        where T : struct, ITool<T>
        where F : unmanaged
    {
        public F Kind {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public ToolTarget(F kind, FS.FilePath path)
        {
            Kind = kind;
            Path = Files.normalize(path);
        }
    }
}
