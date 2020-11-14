//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolOutput<T>
        where T : struct, ITool<T>
    {
        public readonly TableSpan<ToolTarget<T>> Table;

        [MethodImpl(Inline)]
        public static implicit operator ToolOutput<T>(ToolTarget<T>[] src)
            => new ToolOutput<T>(src);

        [MethodImpl(Inline)]
        public ToolOutput(ToolTarget<T>[] src)
            => Table = src;
    }
}