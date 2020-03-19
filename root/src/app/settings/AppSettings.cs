//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    using static Root;

    /*
    {
        "0:on": "Root",
        "1:on": "DataCore",
        "10:on": "AsmCore",
        "11:on": "Intrinsics",
        "12:on": "GMath",
        "13:on": "CoreFunc",
        "14:on": "BitCore",
        "15:on": "Logix",
        "16:on": "BitGrids"
    }
    */
    public class AppSettings : IAppSettings
    {
        public static IAppSettings Empty => new AppSettings(new PairProvider<string>(new Pair<string>[]{}));
        
        public static IAppSettings Load(FilePath src)
        {
            var settings = new Dictionary<string,string>();
            var ignore = new char[]{AsciSym.Quote, AsciSym.Comma};
            if(src.Exists())
            {
                var lines = src.ReadLines().Select(l => l.Trim().RemoveAny(ignore));
                foreach(var line in lines)
                {   
                    var parts = line.SplitClean(AsciSym.Colon);
                    if(parts.Length == 2)                        
                    {
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        settings.TryAdd(key,value);
                    }
                }
            }

            return new AppSettings(new PairProvider<string>(settings.Select(kvp => Tuples.pair(kvp.Key, kvp.Value))));            
        }

        AppSettings(IPairProvider<string> provider)
        {

            this.Pairs = provider.Pairs;
            
        }

        public IEnumerable<Pair<string>> Pairs {get;}
                
        
        void IndexPairs()
        {
            Index = Pairs.Select(x => (x.Left, x.Right)).ToDictionary();
        }

        Dictionary<string,string> Index;                

        public Option<string> Setting(string name)
            => Index.TryGetValue(name, out var value) ? some(value) : none<string>();

        public Option<T> Setting<T>(string name)        
        {
            try
            {
                return Setting(name).TryMap(v => (T) Convert.ChangeType(v,typeof(T)));
            }
            catch(Exception e)
            {
                term.error(e);
            }
            return none<T>();
        }

        public string this[string name]
            => Index.TryGetValue(name, out var value) ? value : string.Empty;
    }    
}