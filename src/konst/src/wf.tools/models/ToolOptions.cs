//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [DataType]
    public readonly struct ToolOptions : IIndexedView<ToolOptions,ushort,ToolOption>
    {
        readonly IndexedView<ToolOption> Data;

        [MethodImpl(Inline)]
        public ToolOptions(ToolOption[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly ToolOption this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ToolOption[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ToolOption> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolOptions(ToolOption[] src)
            => new ToolOptions(src);
    }
}