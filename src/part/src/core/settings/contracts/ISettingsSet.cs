//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Settings;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISettingsSet : ITextual
    {
        Identifier Name {get;}

        Index<Setting> Settings {get;}

        string ITextual.Format()
            => api.format(Settings);
    }

    [Free]
    public interface ISettingsSet<S> : ISettingsSet
        where S : ISettingsSet<S>, new()
    {
        Identifier ISettingsSet.Name
            => typeof(S).Name;

        Index<Setting> ISettingsSet.Settings
            => api.set((S)this);
    }
}