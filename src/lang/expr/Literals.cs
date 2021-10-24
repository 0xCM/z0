//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Literals
    {
        [MethodImpl(Inline), Op]
        public static Literal<bool> literal(in Label name, bool value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<byte> literal(in Label name, byte value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<ushort> literal(in Label name, ushort value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<uint> literal(in Label name, uint value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<ulong> literal(in Label name, ulong value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<sbyte> literal(in Label name, sbyte value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<short> literal(in Label name, short value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<int> literal(in Label name, int value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<long> literal(in Label name, long value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<float> literal(in Label name, float value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<double> literal(in Label name, double value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<decimal> literal(in Label name, decimal value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<char> literal(in Label name, char value)
            => literal(name, value);

        [MethodImpl(Inline), Op]
        public static Literal<string> literal(in Label name, string value)
            => literal(name, value);

        [MethodImpl(Inline)]
        static Literal<V> literal<V>(in Label name, V value)
            => new Literal<V>(name, value);
    }
}