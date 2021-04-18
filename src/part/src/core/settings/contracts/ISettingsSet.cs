//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Settings;

    public interface ISettingsSet : ITextual
    {
        Index<Setting> Settings {get;}

        string ITextual.Format()
            => api.format(Settings);
    }

    public interface ISettingsSet<S> : ISettingsSet
        where S : ISettingsSet<S>, new()
    {
        Index<Setting> ISettingsSet.Settings
            => api.set((S)this);
    }
}