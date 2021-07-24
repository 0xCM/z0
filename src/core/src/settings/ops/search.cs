//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    partial struct Settings
    {
        [Op]
        public static bool search(in Settings src, string key, out Setting value)
        {
            var view = src.Data.View;
            var count = src.Data.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var setting = ref skip(view,i);
                if(string.Equals(setting.Name, key, NoCase))
                {
                    value = setting;
                    return true;
                }
            }
            value = Setting.Empty;
            return false;
        }
    }
}