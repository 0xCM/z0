//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.core;
    using static Z0.Root;

    namespace specs
    {
        using meta;
        public enum ScalarKind : byte
        {
            U = 0,

            I = 1,

            F = 2,
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Scalar
        {
            public ScalarKind Kind;

            public uint StorageSize;

            public uint DataWidth;

            [MethodImpl(Inline)]
            public Scalar(ScalarKind kind, uint s, uint w)
            {
                Kind = kind;
                StorageSize = s;
                DataWidth = w;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Block
        {
            public uint CellSize;

            public uint CellCount;

            [MethodImpl(Inline)]
            public Block(uint s, uint n)
            {
                CellSize = s;
                CellCount = n;
            }
        }

        /// <summary>
        /// Defines an indexed sequence of homogenous literal values
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Enum<V>
        {
            Index<literal<V>> Data;

            [MethodImpl(Inline)]
            public Enum(literal<V>[] src)
            {
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

            [MethodImpl(Inline)]
            public static implicit operator Enum<V>(literal<V>[] src)
                => new Enum<V>(src);

            [MethodImpl(Inline)]
            public static implicit operator literal<V>[](Enum<V> src)
                => new Enum<V>(src);
        }
    }
}