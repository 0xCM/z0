//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = Settings;

    public readonly struct SettingsLookup : IIndex<Setting>, ILookup<string,Setting>, ISettingsSet<SettingsLookup>
    {
        readonly Index<Setting> Data;

        [MethodImpl(Inline)]
        public SettingsLookup(Setting[] src)
            => Data = src;

        public Setting[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public bool Lookup(string key, out Setting value)
        {
            var view = Data.View;
            var count = Data.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var setting = ref skip(view,i);
                if(text.equals(setting.Name, key))
                {
                    value = setting;
                    return true;
                }
            }
            value = Setting.Empty;
            return false;
        }

        public string Format()
            => api.format(Data);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SettingsLookup(Setting[] src)
            => new SettingsLookup(src);

        [MethodImpl(Inline)]
        public static implicit operator Setting[](SettingsLookup src)
            => src.Storage;
    }
}