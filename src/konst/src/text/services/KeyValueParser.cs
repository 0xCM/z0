//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct KeyValueParser
    {
        public static KeyValueParser<K,V> create<K,V>(ITextParser<K> kp, ITextParser<V> vp, string delimiter = CharText.Eq)
            => new KeyValueParser<K,V>(kp, vp, delimiter);
    }

    public readonly struct KeyValueParser<K,V>
    {
        public string Delimiter {get;}

        public ITextParser<K> KeyParser {get;}

        public ITextParser<V> ValueParser {get;}

        public KeyValueParser(ITextParser<K> kp, ITextParser<V> vp, string delimiter)
        {
            Delimiter = delimiter;
            KeyParser = kp;
            ValueParser = vp;
        }

        public bool Parse(in string src, out KeyedValue<K,V> dst)
        {
            dst = default;
            var parts = text.split(src,Delimiter);
            if(parts.Length == 2)
            {

                if(KeyParser.Parse(parts[0], out var key) && ValueParser.Parse(parts[1], out var value))
                {
                    dst = (key,value);
                    return true;
                }
            }

            return false;
        }
    }
}