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

    using static Konst;
    using static Chars;

    /// <summary>
    /// Reifies an application settings service
    /// </summary>
    public class AppSettings : IAppSettings
    {
        public static IAppSettings Empty => new AppSettings(new KeyValuePair<string,string>[]{});
        
        public static IAppSettings Load(FilePath src)
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
                        settings.TryAdd(key,value);
                    }
                }
            }

            return new AppSettings(settings.Select(kvp => (kvp.Key, kvp.Value)));            
        }

        AppSettings(IEnumerable<(string,string)> pairs)
        {
            this.Pairs = pairs.Select(pair => new KeyValuePair<string, string>(pair.Item1, pair.Item2)).ToArray();
        }

        AppSettings(IEnumerable<KeyValuePair<string,string>> pairs)
        {
            this.Pairs = pairs.ToArray();
        }

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

        public IEnumerable<IAppSetting> All
            => from p in Pairs select new AppSetting(p.Key, p.Value) as IAppSetting;        

        public string this[string name]
            => Setting(name).ValueOrDefault(string.Empty);


        public static S From<S>(IAppSettings src)
            where S : IAppSettingsProvider<S>, new()
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

        public static IEnumerable<AppSetting> Get<S>(IAppSettingsProvider<S> src)
            where S : IAppSettingsProvider<S>, new()
                => from p in typeof(S).DeclaredProperties()
                    where p.HasPublicGetter() && p.HasPublicSetter()
                    let value = p.GetValue(src)?.ToString()
                    select new AppSetting(p.Name, value);

        public static void Save<S>(IAppSettingsProvider<S> src, FilePath dst)
            where S : IAppSettingsProvider<S>, new()
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
                        line += Comma;
                    writer.WriteLine(line);   
                }
                writer.WriteLine(RBrace);
            }
        }

        public static string Format(IEnumerable<IAppSetting> settings)
        {            
            var dst = new StringBuilder();
            var src = settings.ToArray();
            for(var i=0; i<src.Length; i++)
            {
                var line = src[i].Format();

                if(i != src.Length - 1)
                    line += Comma;
                
                dst.AppendLine(line);
            }
            return dst.ToString();
        } 
    }    
}