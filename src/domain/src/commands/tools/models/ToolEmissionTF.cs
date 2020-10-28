//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolEmission<T,F> : IToolFile<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        public FS.FilePath Target {get;}

        public F Kind {get;}

        [MethodImpl(Inline)]
        public ToolEmission(F kind, FS.FilePath path)
        {
            Kind = kind;
            Target = Files.normalize(path);
        }
    }
}
