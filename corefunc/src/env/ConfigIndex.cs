//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Configuration.Json;

    using static zfunc;

    public interface IAppSettings
    {
        Option<string> Read(string name);
        
        Option<T> Read<T>(string name);

        string this[string name] {get;}

        IEnumerable<Pair<string>> Pairs {get;}

    }


    public class AppSettings : IAppSettings
    {
        public static IAppSettings Load(string name)
        {
            var path = Paths.ConfigPath(name);
            path.FolderPath.CreateIfMissing();
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(path.Name,true);
            return new AppSettings(builder.Build());            
        }

        AppSettings(IConfigurationRoot root)
        {
            this.Root = root;
            this.Values = new Dictionary<string, string>();
            this.Load();
        }
        
        void Load(bool reload = false)
        {
            if(reload)
                Root.Reload();

            Values.Clear();
            iter(Root.AsEnumerable(), kvp => Values[kvp.Key] = kvp.Value);
            Loaded = now();
        }
        
        DateTime Loaded;

        IConfigurationRoot Root;
        
        Dictionary<string,string> Values;                

        int Age
            => (int)(now() - Loaded).TotalSeconds;


        public Option<string> Read(string name)
        {
            try            
            {
               if(Age > 5)
                  Load(true);

                if(Values.TryGetValue(name, out var value))
                    return  value.IsBlank() ? none<string>() : some(value);
            }
            catch(Exception e)
            {
                errout(e);
            }
            return default;
        }

        public Option<T> Read<T>(string name)
        {
            try
            {
                return Read(name).TryMap(v => (T) Convert.ChangeType(v,typeof(T)));
            }
            catch(Exception e)
            {
                errout(e);
            }
            return default;
        }

        public string this[string name]
        {
            get => Read(name).ValueOrElse(() => string.Empty);
        }

        public IEnumerable<Pair<string>> Pairs => Values.Select(kvp => pair(kvp.Key, kvp.Value));

    }

}


