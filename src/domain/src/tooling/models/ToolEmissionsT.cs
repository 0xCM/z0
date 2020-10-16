//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolEmissions<T>
        where T : struct, ITool<T>
    {
        public readonly TableSpan<ToolEmission<T>> Table;

        [MethodImpl(Inline)]
        public static implicit operator ToolEmissions<T>(ToolEmission<T>[] src)
            => new ToolEmissions<T>(src);

        [MethodImpl(Inline)]
        public ToolEmissions(ToolEmission<T>[] src)
            => Table = src;
    }
}