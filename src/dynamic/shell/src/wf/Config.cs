//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    struct Config : ISettingsAdapter<Config>
    {
        IJsonSettings Source;

        public Config Adapt(IJsonSettings source)
        {
            var config = new Config();
            config.Source = source;
            return config;
        }

        // public Type Dispatcher()
        // {
        //     var parts =
        // }
    }
}