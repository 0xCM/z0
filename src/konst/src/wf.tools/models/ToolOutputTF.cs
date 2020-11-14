//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolOutput<T,F>
        where T : struct, ITool<T>
        where F : unmanaged
    {
        readonly ToolTarget<T,F>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ToolOutput<T,F>(ToolTarget<T,F>[] src)
            => new ToolOutput<T,F>(src);

        [MethodImpl(Inline)]
        public ToolOutput(ToolTarget<T,F>[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
        public ref ToolTarget<T,F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<ToolTarget<T,F>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<ToolTarget<T,F>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}