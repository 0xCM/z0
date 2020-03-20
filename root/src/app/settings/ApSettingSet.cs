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

    public interface AppSettingSet<S> : IFormattable<S>
        where S : AppSettingSet<S>, new()
    {
        IEnumerable<AppSetting> Settings 
            => AppSettingsSetOps.Get<S>(this);

        string ICustomFormattable.Format()
            => AppSettingsSetOps.Format(Settings);
    }

    static class AppSettingsSetOps
    {
        public static IEnumerable<AppSetting> Get<S>(AppSettingSet<S> src)
            where S : AppSettingSet<S>, new()
            => from p in typeof(S).DeclaredProperties()
                where p.HasGetter()
                let value = p.GetValue(src)?.ToString()
                select new AppSetting(p.Name, value);

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