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

    public class ConfigIndex
    {
        public static ConfigIndex Get(string name)
        {
            var path = Paths.ConfigPath(name);
            path.FolderPath.CreateIfMissing();
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(path.Name,true);
            return new ConfigIndex(builder.Build());            
        }

        ConfigIndex(IConfigurationRoot root)
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

        public string Read(string name)
        {
            try            
            {
               if(Age > 5)
                  Load(true);

                if(Values.TryGetValue(name, out var value))
                    return value;
            }
            catch(Exception e)
            {
                error(e);
            }
            return string.Empty;
        }

        public Option<T> Read<T>(string name)
        {
            try
            {
                var value = Read(name);
                if(!string.IsNullOrWhiteSpace(value))
                    return (T)Convert.ChangeType(value, typeof(T));
            }
            catch(Exception e)
            {
                error(e);
            }
            return default;
        }


        public string this[string name]
        {
            get => Read(name);
        }

    }

}


