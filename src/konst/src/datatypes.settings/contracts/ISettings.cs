//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISettings
    {
        Func<ISettings> Factory {get;}
    }

    public interface ISettings<S> : ISettings
        where S : ISettings<S>, new()
    {
        new Func<S> Factory
            => () => new S();

        Func<ISettings> ISettings.Factory
            => () => new S();
    }
}