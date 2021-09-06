//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static LiteralKind;

    [ApiHost]
    public readonly partial struct Blit
    {
        const NumericKind Closure = UnsignedInts;

        [ApiHost("blit.factory")]
        public readonly partial struct Factory
        {

        }

        [ApiHost("blit.operate")]
        public readonly partial struct Operate
        {

        }

        [ApiHost("blit.meta")]
        public readonly partial struct Meta
        {
            [MethodImpl(Inline), Op]
            public static Name name(string src)
                => new Name(src);

            [MethodImpl(Inline), Op]
            public static Scalar scalar(ScalarKind kind, ByteSize storage, BitWidth data)
                => new Scalar(kind,storage,data);

            [MethodImpl(Inline), Op]
            public static Block block(ByteSize size, uint count)
                => new Block(size,count);

            [MethodImpl(Inline)]
            public static Enum<V> @enum<V>(string name, Literal<V>[] src)
                => new Enum<V>(name, src);

            [MethodImpl(Inline), Op]
            public static Literal<bool> literal(in Name name, bool value)
                => literal(name, value, U1);

            [MethodImpl(Inline), Op]
            public static Literal<byte> literal(in Name name, byte value)
                => literal(name, value, U8);

            [MethodImpl(Inline), Op]
            public static Literal<ushort> literal(in Name name, ushort value)
                => literal(name, value, U16);

            [MethodImpl(Inline), Op]
            public static Literal<uint> literal(in Name name, uint value)
                => literal(name, value, U32);

            [MethodImpl(Inline), Op]
            public static Literal<ulong> literal(in Name name, ulong value)
                => literal(name, value, U64);

            [MethodImpl(Inline), Op]
            public static Literal<sbyte> literal(in Name name, sbyte value)
                => literal(name, value, I8);

            [MethodImpl(Inline), Op]
            public static Literal<short> literal(in Name name, short value)
                => literal(name, value, I16);

            [MethodImpl(Inline), Op]
            public static Literal<int> literal(in Name name, int value)
                => literal(name, value, I32);

            [MethodImpl(Inline), Op]
            public static Literal<long> literal(in Name name, long value)
                => literal(name, value, I64);

            [MethodImpl(Inline), Op]
            public static Literal<float> literal(in Name name, float value)
                => literal(name, value, F32);

            [MethodImpl(Inline), Op]
            public static Literal<double> literal(in Name name, double value)
                => literal(name, value, F64);

            [MethodImpl(Inline), Op]
            public static Literal<decimal> literal(in Name name, decimal value)
                => literal(name, value, F128);

            [MethodImpl(Inline), Op]
            public static Literal<char> literal(in Name name, char value)
                => literal(name, value, C16);

            [MethodImpl(Inline), Op]
            public static Literal<string> literal(in Name name, string value)
                => literal(name, value, LiteralKind.String);

            [MethodImpl(Inline)]
            static Literal<V> literal<V>(in Name name, V value, LiteralKind kind)
                => new Literal<V>(name, kind, value);

            public struct Name
            {
                public StringAddress<N64> Value;

                [MethodImpl(Inline)]
                public Name(StringAddress<N64> src)
                {
                    Value = src;
                }

                [MethodImpl(Inline)]
                public static implicit operator Name(StringAddress<N64> src)
                    => new Name(src);

                public string Format()
                    => Value.Format();

                public override string ToString()
                    => Format();

                [MethodImpl(Inline)]
                public static implicit operator Name(string src)
                    => new Name(src);
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
            [StructLayout(LayoutKind.Sequential, Pack=1)]
            public struct Literal<V>
            {
                public Name Name;

                public LiteralKind Kind;

                public V Value;

                [MethodImpl(Inline)]
                public Literal(Name n, LiteralKind kind, V value)
                {
                    Name = n;
                    Kind = kind;
                    Value = value;
                }
            }

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

            /// <summary>
            /// Defines an indexed sequence of homogenous literal values
            /// </summary>
            [StructLayout(LayoutKind.Sequential, Pack=1)]
            public struct Enum<V>
            {
                public Name Name {get;}

                Index<Literal<V>> Data;

                [MethodImpl(Inline)]
                public Enum(Name name, Literal<V>[] src)
                {
                    Name = name;
                    Data = src;
                }

                public ref Literal<V> this[uint i]
                {
                    [MethodImpl(Inline)]
                    get => ref Data[i];
                }

                public ref Literal<V> this[int i]
                {
                    [MethodImpl(Inline)]
                    get => ref Data[i];
                }

                public uint LiteralCount
                {
                    [MethodImpl(Inline)]
                    get => Data.Count;
                }

                public ReadOnlySpan<Literal<V>> LiteralView
                {
                    [MethodImpl(Inline)]
                    get => Data.View;
                }

                public Span<Literal<V>> LiteralEdit
                {
                    [MethodImpl(Inline)]
                    get => Data.Edit;
                }
            }
        }
    }
}