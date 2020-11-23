//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Parsers
    {
        [MethodImpl(Inline)]
        public static KeyValueParser<K,V> kvp<K,V>(ITextParser2<K> kp, ITextParser2<V> vp, string delimiter = CharText.Eq)
            => new KeyValueParser<K,V>(kp, vp, delimiter);

        [Op]
        public static bool Parse(string s, out GridDim dst)
        {
            var parts = s.Split('x');
            var parser = numeric<uint>();
            dst = default;
            var succeeded = false;
            if(parts.Length == 2)
            {
                var m = parser.Parse(parts[0]);
                var n = parser.Parse(parts[1]);
                succeeded = m.Succeeded && n.Succeeded;
                if(succeeded)
                    dst = new GridDim(m.Value, n.Value);
            }
            return succeeded;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T apply<T>(IParser2<string,T> parser, string src)
            where T : struct
                => parser.Parse(src).ValueOrDefault(default(T));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NumericParser<T> numeric<T>()
            where T : unmanaged
                => default(NumericParser<T>);

        [MethodImpl(Inline)]
        public static InfallibleNumericParser<T> numeric<T>(bool succeed)
            where T : unmanaged
                => NumericParser.infallible<T>();

        [MethodImpl(Inline)]
        public static ITextParser<MemoryRange> address(bool range)
            => MemoryRangeParser.Service;

        [MethodImpl(Inline)]
        public static HexScalarParser hex()
            => HexScalarParser.Service;

        [MethodImpl(Inline)]
        public static IHexParser<byte> hex(bool bytes)
            => HexByteParser.Service;
    }
}