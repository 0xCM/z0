//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    [ApiHost]
    public readonly struct JsonData
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonDataPacket<T> packet<T>(T src)
            => src;

        [Op]
        public static string unescape(FS.FilePath src)
            => JsonSerializer.Deserialize<string>(src.Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonSetting<T> setting<T>(string name, T value)
            => new JsonSetting<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonSetting setting(string name, string value)
            => new JsonSetting(name, value);

        public static string format(JsonSetting src)
            => JsonSerializer.Serialize(src);

        public static string format<T>(JsonSetting<T> src)
            => JsonSerializer.Serialize(src);

        [Op, Closures(Closure)]
        public static JsonText serialize<T>(T src, bool indented = true)
            => JsonSerializer.Serialize(src, new JsonSerializerOptions{WriteIndented = indented});

        public static void absorb(FS.FilePath src, Dictionary<string,string> dst)
        {
            var settings = new Dictionary<string,string>();
            var ignore = new char[]{Chars.Quote, Chars.Comma};
            if(src.Exists)
            {
                var lines = src.ReadLines().Select(l => l.Trim().RemoveAny(ignore));
                foreach(var line in lines)
                {
                    var parts = line.SplitClean(Chars.Colon);
                    if(parts.Length == 2)
                    {
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        dst.TryAdd(key,value);
                    }
                }
            }
        }

        public static T materialize2<T>(FS.FilePath src)
            where T : struct
        {
            var kvp = new Dictionary<string,string>();
            var dst = new T();
            var fields = typeof(T).GetFields(BindingFlags.Instance).Select(x => (x.Name, x)).ToDictionary();
            JsonData.absorb(src, kvp);
            foreach(var key in kvp.Keys)
            {
                if(fields.TryGetValue(key, out FieldInfo f))
                {
                    var dstType = f.FieldType;
                    Option.Try(() => Convert.ChangeType(kvp[key], dstType)).OnSome(value => f.SetValue(dst,value));
                }
            }
            return dst;
        }

        [Op, Closures(Closure)]
        public static JsonText serialize<T>(T src, FS.FilePath dst, bool indented = true)
        {
            var data = serialize(src, indented);
            using var writer = dst.Writer();
            writer.Write(data);
            return data;
        }

        [Op, Closures(Closure)]
        public static T materialize<T>(JsonText src)
        {
            var packet = JsonSerializer.Deserialize<JsonDataPacket<T>>(src);
            return packet.Content;
        }

        [Op, Closures(Closure)]
        public static T materialize<T>(FS.FilePath src)
        {
            using var reader = src.Utf8Reader();
            var data = reader.ReadToEnd();
            return materialize<T>(data);
        }

        [MethodImpl(Inline), Op]
        public static JsonText json(string src)
            => new JsonText(src);

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static Json<T> json<T>(T[] src)
            => new Json<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonText text<T>(in Json<T> src)
            => json(format(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in Json<T> src)
            => src.Content?.ToString() ?? EmptyString;
    }
}