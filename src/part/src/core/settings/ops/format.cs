//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static core;

    partial struct Settings
    {
        public static string format(Index<Setting> src)
        {
            var dst = text.buffer();
            iter(src, x => dst.AppendLine(x.Format()));
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string format<T>(Setting<T> src)
            => text.format(RP.Setting, src.Name, src.Value);

        public static string format(Setting src, bool json)
            => new SettingValue(src.Name, src.Value).Format(json);

        /// <summary>
        /// Renders a k/v pair as a setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        [MethodImpl(Inline), Op]
        public static string format<K,V>(K key, V value)
            => string.Format(RP.Setting, key, value);

        public static string format(SettingValue src, bool json)
        {
            if(json)
                return string.Concat(src.Name.Enquote(), Chars.Colon, Chars.Space, src.Value.Enquote());
            else
                return format(text.ifempty(src.Name, "<anonymous>"), src.Value);
        }
    }
}