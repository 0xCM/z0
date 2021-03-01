//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Settings
    {
        const NumericKind Closure = UnsignedInts;

        public static string format(Index<Setting> src)
        {
            var dst = text.buffer();
            root.iter(src, x => dst.AppendLine(x.Format()));
            return dst.Emit();
        }

        public static Index<Setting> set<T>(T src)
            where T : ISettingsSet<T>, new()
        {
            var _fields = typeof(T).PublicInstanceFields().Reify<ISetting>();
            var _props = typeof(T).PublicInstanceProperties().Reify<ISetting>();

            var _fieldValues = from f in _fields
                                let value = f.GetValue(src) as ISetting
                                where f != null
                                let name = text.ifempty(value.Name, f.Name)
                                select new Setting(name, value);

            var _propValues = from f in _props
                                let value = f.GetValue(src) as ISetting
                                where f != null
                                let name = text.ifempty(value.Name, f.Name)
                                select new Setting(name, value);

            return _fieldValues.Union(_propValues).Array();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> empty<T>()
            => Setting<T>.Empty;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> define<T>(string name, T value)
            => new Setting<T>(name,value);

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
    }
}