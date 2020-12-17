//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SettingKey<K> : ISettingKey<SettingKey<K>>
    {
        public K Key {get;}

        readonly TextFormatFunction<K> Formatter;

        readonly ITextParser<K> Parser;

        [MethodImpl(Inline)]
        public SettingKey(K key, TextFormatFunction<K> render, ITextParser<K> parse)
        {
            Key = key;
            Formatter = render;
            Parser = parse;
        }

        public string Format()
        {
            if(Formatter != null)
                return Formatter(Key);
            else
                return "FAIL";
        }

        public bool Parse(string src, out SettingKey<K> dst)
        {
            if( Parser != null && Parser.Parse(src, out var key))
            {
                dst = new SettingKey<K>(key, Formatter,Parser);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }
    }
}