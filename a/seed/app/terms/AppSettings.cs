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

    using static Seed;

    public partial class AppSettings : IAppSettings
    {
        public static IAppSettings Empty => new AppSettings(new KeyValuePair<string,string>[]{});
        
        public static IAppSettings Load(FilePath src)
        {
            var settings = new Dictionary<string,string>();
            var ignore = new char[]{Chars.Quote, Chars.Comma};
            if(src.Exists())
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
    }    
}