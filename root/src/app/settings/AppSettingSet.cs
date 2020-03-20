//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Runtime.CompilerServices;    
    using System.Linq;
    using System.Reflection;

    public interface AppSettingSet : ICustomFormattable
    {
        IEnumerable<AppSetting> Settings{get;}
        
        void Save(FilePath dst);        
    }

    public interface AppSettingSet<S> : AppSettingSet, IFormattable<S>
        where S : AppSettingSet<S>, new()
    {
        static S From(IAppSettings src)
            => AppSettingsSetOps.From<S>(src);
        
        IEnumerable<AppSetting> AppSettingSet.Settings 
            => AppSettingsSetOps.Get<S>(this);

        string ICustomFormattable.Format()
            => AppSettingsSetOps.Format(Settings);
        
        void AppSettingSet.Save(FilePath dst)
            => AppSettingsSetOps.Save(this,dst);
    }

    static class AppSettingsSetOps
    {
        public static S From<S>(IAppSettings src)
            where S : AppSettingSet<S>, new()
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
                term.error(e);
                return Option.none<S>();
            }
        }

        static IEnumerable<string> SettingNames<S>()
            => from p in typeof(S).DeclaredProperties()
                where p.HasGetter() && p.HasSetter()
                select p.Name;

        public static IEnumerable<AppSetting> Get<S>(AppSettingSet<S> src)
            where S : AppSettingSet<S>, new()
                => from p in typeof(S).DeclaredProperties()
                    where p.HasGetter() && p.HasSetter()
                    let value = p.GetValue(src)?.ToString()
                    select new AppSetting(p.Name, value);

        public static void Save<S>(AppSettingSet<S> src, FilePath dst)
            where S : AppSettingSet<S>, new()
        {
            const string indent = "    ";

            var settings = src.Settings.ToArray();
            if(settings.Length != 0)
            {
                using var writer = dst.Writer();
                writer.WriteLine(text.lbrace());
                for(var i = 0; i< settings.Length; i++)    
                {
                    var line = indent + settings[i].Format();
                    if(i != settings.Length - 1)
                        line += text.comma();
                    writer.WriteLine(line);   
                }
                writer.WriteLine(text.rbrace());
            }
        }

        public static string Format(IEnumerable<AppSetting> settings)
        {            
            var dst = text.factory.Builder();
            var src = settings.ToArray();
            for(var i=0; i<src.Length; i++)
            {
                var line = src[i].Format();

                if(i != src.Length - 1)
                    line += text.comma();
                
                dst.AppendLine(line);
            }
            return dst.ToString();
        }
    }
}