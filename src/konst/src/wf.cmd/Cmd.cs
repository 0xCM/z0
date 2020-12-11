//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ICmdCatalog catalog(IWfShell wf)
            => new CmdCatalog(wf);

        [MethodImpl(Inline), Op]
        public static CmdBuilder builder(IWfShell wf)
            => new CmdBuilder(wf);

        [Op]
        public static ICmdSpec[] known()
        {
            var types = typeof(CmdSpecs).Assembly.Types().Tagged<CmdAttribute>();
            var specs = types.Select(t => (ICmdSpec)Activator.CreateInstance(t));
            return specs;
        }
    }
}