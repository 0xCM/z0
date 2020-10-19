//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Settings;

    public readonly struct SettingKey<K> : ISettingKey<SettingKey<K>>
    {
        public K Key {get;}

        readonly RenderFunction<K,string> Formatter;

        readonly ParseFunction<string,K> Parser;

        public SettingKey(K key, RenderFunction<K,string> fRx, ParseFunction<string,K> pFx)
        {
            Key = key;
            Formatter = fRx;
            Parser = pFx;
        }

        public string Format()
        {
            if(Formatter != null && Formatter(Key, out var k))
                return k;
            else
                return "FAIL";
        }

        public bool Parse(string src, out SettingKey<K> dst)
        {
            if( Parser != null && Parser(src, out var key))
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