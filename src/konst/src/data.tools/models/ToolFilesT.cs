//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolFiles<T>
        where T : struct, ITool<T>
    {
        public readonly TableSpan<ToolFile<T>> Table;

        [MethodImpl(Inline)]
        public static implicit operator ToolFiles<T>(ToolFile<T>[] src)
            => new ToolFiles<T>(src);
        
        [MethodImpl(Inline)]
        public ToolFiles(ToolFile<T>[] src)
            => Table = src;
    }
}