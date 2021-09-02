//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.metadata
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.Root;

    using generic;

    /// <summary>
    /// Defines an indexed sequence of homogenous literal values
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Enum<V>
    {
        public name Name {get;}

        Index<literal<V>> Data;

        [MethodImpl(Inline)]
        public Enum(name name, literal<V>[] src)
        {
            Name = name;
            Data = src;
        }

        public ref literal<V> this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref literal<V> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public uint LiteralCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<literal<V>> LiteralView
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<literal<V>> LiteralEdit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }
    }

}