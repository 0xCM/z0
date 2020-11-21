//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SettingParsers
    {
        [MethodImpl(Inline)]
        public static bool parse<K,V>(string src, out Setting<K,V> dst)
            where K : struct, ISettingKey<K>
            where V : struct, ISettingValue<V>
        {
            var key = default(K);
            var value = default(V);
            if(key.Parse(src.LeftOfFirst(Chars.Colon), out key) && (value.Parse(src.LeftOfFirst(Chars.Colon), out value)))
            {
                dst = new Setting<K,V>(key,value);
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