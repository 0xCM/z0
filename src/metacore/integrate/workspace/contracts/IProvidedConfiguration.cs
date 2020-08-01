//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;

    public interface IProvidedConfiguration
    {
        IEnumerable<ConfigurationSetting> GetNamedSettings();
    }
}