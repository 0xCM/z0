//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.Root;
    using static Z0.LiteralKind;

    using generic;

    partial struct Blittable
    {
        [MethodImpl(Inline), Op]
        public static literal<bool> literal(in name name, bool value)
            => literal(name, value, U1);

        [MethodImpl(Inline), Op]
        public static literal<byte> literal(in name name, byte value)
            => literal(name, value, U8);

        [MethodImpl(Inline), Op]
        public static literal<ushort> literal(in name name, ushort value)
            => literal(name, value, U16);

        [MethodImpl(Inline), Op]
        public static literal<uint> literal(in name name, uint value)
            => literal(name, value, U32);

        [MethodImpl(Inline), Op]
        public static literal<ulong> literal(in name name, ulong value)
            => literal(name, value, U64);

        [MethodImpl(Inline), Op]
        public static literal<sbyte> literal(in name name, sbyte value)
            => literal(name, value, I8);

        [MethodImpl(Inline), Op]
        public static literal<short> literal(in name name, short value)
            => literal(name, value, I16);

        [MethodImpl(Inline), Op]
        public static literal<int> literal(in name name, int value)
            => literal(name, value, I32);

        [MethodImpl(Inline), Op]
        public static literal<long> literal(in name name, long value)
            => literal(name, value, I64);

        [MethodImpl(Inline), Op]
        public static literal<float> literal(in name name, float value)
            => literal(name, value, F32);

        [MethodImpl(Inline), Op]
        public static literal<double> literal(in name name, double value)
            => literal(name, value, F64);

        [MethodImpl(Inline), Op]
        public static literal<decimal> literal(in name name, decimal value)
            => literal(name, value, F128);

        [MethodImpl(Inline), Op]
        public static literal<char> literal(in name name, char value)
            => literal(name, value, C16);

        [MethodImpl(Inline), Op]
        public static literal<string> literal(in name name, string value)
            => literal(name, value, LiteralKind.String);

        [MethodImpl(Inline)]
        static literal<V> literal<V>(in name name, V value, LiteralKind kind)
            => new literal<V>(name, kind, value);
    }

}