//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolFiles<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        readonly ToolFile<T,F>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ToolFiles<T,F>(ToolFile<T,F>[] src)
            => new ToolFiles<T,F>(src);
        
        [MethodImpl(Inline)]
        public ToolFiles(ToolFile<T,F>[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
        public ref ToolFile<T,F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<ToolFile<T,F>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<ToolFile<T,F>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }        
    }
}
