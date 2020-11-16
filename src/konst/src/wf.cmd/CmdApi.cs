//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        internal const byte MaxVarCount = 16;

        internal const string Anonymous = "anonymous";

        internal const string CmdIdNotFound = "Command identifier not found";

        internal const string InvalidOption = "Option text invalid";

        internal const char DefaultSpecifier = Chars.Colon;

        const NumericKind Closure = UnsignedInts;


        [MethodImpl(Inline), Op]
        public static ICmdCatalog catalog(IWfShell wf)
            => new CmdCatalog(wf);

        [MethodImpl(Inline), Op]
        public static CmdBuilder builder(IWfShell wf)
            => new CmdBuilder(wf);

        [Op]
        public static CmdModel[] models(IWfShell wf)
            => typeof(Cmd).Assembly.Types().Tagged<CmdAttribute>().Select(model);
    }
}