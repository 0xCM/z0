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

    public readonly struct KeyValueParser<K,V> : IParser2<string, KeyedValue<K,V>>
    {
        public string Delimiter {get;}

        public ITextParser2<K> KeyParser {get;}

        public ITextParser2<V> ValueParser {get;}

        public KeyValueParser(ITextParser2<K> kp, ITextParser2<V> vp, string delimiter)
        {
            Delimiter = delimiter;
            KeyParser = kp;
            ValueParser = vp;
        }

        public ParseResult2<string> Parse(in string src, out KeyedValue<K,V> dst)
        {
            dst = default;
            var parts = text.split(src,Delimiter);
            if(parts.Length == 2)
            {
                if(KeyParser.Parse(parts[0], out var key) && ValueParser.Parse(parts[1], out var value))
                {
                    dst = (key,value);
                    return src;
                }
            }

            return (src, false);
        }
    }
}