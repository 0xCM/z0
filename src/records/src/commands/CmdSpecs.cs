//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.CmdSpecs, true)]
    public readonly partial struct CmdSpecs
    {
        [Op]
        public static ICmdSpec[] known()
        {
            var types = typeof(CmdSpecs).Assembly.Types().Tagged<CmdAttribute>();
            var specs = types.Select(t => (ICmdSpec)Activator.CreateInstance(t));
            return specs;
        }
    }
}