//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolEmissions<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        readonly ToolEmission<T,F>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ToolEmissions<T,F>(ToolEmission<T,F>[] src)
            => new ToolEmissions<T,F>(src);

        [MethodImpl(Inline)]
        public ToolEmissions(ToolEmission<T,F>[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
        public ref ToolEmission<T,F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<ToolEmission<T,F>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<ToolEmission<T,F>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}
