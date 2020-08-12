//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;
    
    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline)]
        public static ToolFile<T,F> file<T,F>(F kind, FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged, Enum   
                => new ToolFile<T,F>(kind, path);
    }
}