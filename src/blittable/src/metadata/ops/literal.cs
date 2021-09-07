//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static LiteralKind;

    partial struct Blit
    {
        partial struct Meta
        {
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
        }
    }
}