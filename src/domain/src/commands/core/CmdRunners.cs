//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CmdRunners, true)]
    public readonly struct CmdRunners
    {
        [Op]
        public static ICmdRunner[] discover(Assembly src)
        {
            var types = src.Types().Tagged<CmdHostAttribute>();
            var runners = types.Select(t => (ICmdRunner)Activator.CreateInstance(t));
            return runners;
        }
    }
}