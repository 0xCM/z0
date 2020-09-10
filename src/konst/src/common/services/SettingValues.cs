//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Defines the canonical <see cref='ISettings'/> reification
    /// </summary>
    public class SettingValues : ISettings
    {
        public static ISettings Load(FilePath src)
        {
            var dst = new Dictionary<string,string>();
            absorb(src, dst);
            return new SettingValues(dst.Select(kvp => (kvp.Key, kvp.Value)));
        }

        public static void absorb(FilePath src, Dictionary<string,string> dst)
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

        public static T load<T>(FilePath src)
            where T : struct
        {
            var kvp = new Dictionary<string,string>();
            var dst = new T();
            var fields = typeof(T).GetFields(BindingFlags.Instance).Select(x => (x.Name, x)).ToDictionary();
            SettingValues.absorb(src, kvp);
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

        internal SettingValues(IEnumerable<(string,string)> pairs)
            => Pairs = pairs.Select(pair => new KeyValuePair<string, string>(pair.Item1, pair.Item2)).ToArray();

        internal SettingValues(IEnumerable<KeyValuePair<string,string>> pairs)
            => Pairs = pairs.ToArray();

        IEnumerable<KeyValuePair<string,string>> Pairs {get;}

        public Option<string> Setting(string name)
        {
            var matches = Pairs.Where(p => p.Key == name).ToArray();
            if(matches.Length == 0)
                return Option.none<string>();
            else
                return matches[0].Value;
        }

        public Option<T> Setting<T>(string name)
        {
            try
            {
                return Setting(name).TryMap(v => (T) Convert.ChangeType(v,typeof(T)));
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e);
            }
            return Option.none<T>();
        }

        public IEnumerable<ISetting> All
            => from p in Pairs select new SettingValue(p.Key, p.Value) as ISetting;

        public string this[string name]
            => Setting(name).ValueOrDefault(string.Empty);

        public static S From<S>(ISettings src)
            where S : ISettingSource<S>, new()
        {
            var dst = new S();
            foreach(var name in SettingNames<S>())
                src.Setting(name).OnSome(value => WriteSetting(name, value, dst));
            return dst;
        }

        static Option<S> WriteSetting<S>(string name, string value, S dst)
        {
            try
            {
                var wf = from p in typeof(S).Property(name)
                         let v = Convert.ChangeType(value, p.PropertyType)
                         from r in p.Write(v,dst)
                         select (S)r;
                return wf;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e);
                return Option.none<S>();
            }
        }

        static IEnumerable<string> SettingNames<S>()
            => from p in typeof(S).DeclaredProperties()
                where p.HasPublicGetter() && p.HasPublicSetter()
                select p.Name;

        public static IEnumerable<SettingValue> Get<S>(ISettingSource<S> src)
            where S : ISettingSource<S>, new()
                => from p in typeof(S).DeclaredProperties()
                    where p.HasPublicGetter() && p.HasPublicSetter()
                    let value = p.GetValue(src)?.ToString()
                    select new SettingValue(p.Name, value);

        public static void Save<S>(ISettingSource<S> src, FilePath dst)
            where S : ISettingSource<S>, new()
        {
            const string indent = "    ";

            var settings = src.Settings.ToArray();
            if(settings.Length != 0)
            {
                using var writer = dst.Writer();
                writer.WriteLine(LBrace);
                for(var i = 0; i< settings.Length; i++)
                {
                    var line = indent + settings[i].Format();
                    if(i != settings.Length - 1)
                        line += Chars.Comma;
                    writer.WriteLine(line);
                }
                writer.WriteLine(RBrace);
            }
        }

        public static string Format(IEnumerable<ISetting> settings)
        {
            var dst = new StringBuilder();
            var src = settings.ToArray();
            for(var i=0; i<src.Length; i++)
            {
                var line = src[i].Format();

                if(i != src.Length - 1)
                    line += Chars.Comma;

                dst.AppendLine(line);
            }
            return dst.ToString();
        }

        public static ISettings Empty
            => new SettingValues(new KeyValuePair<string,string>[]{});
    }
}