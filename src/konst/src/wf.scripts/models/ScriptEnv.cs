//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        public readonly struct Env : IScriptVars<Env>
        {
            public Dir ZDev => (nameof(ZDev), Environment.GetEnvironmentVariable(nameof(ZDev)));

            public Dir ZDb => (nameof(ZDb), Environment.GetEnvironmentVariable(nameof(ZDb)));

            public Dir ZControl => (nameof(ZControl), Environment.GetEnvironmentVariable(nameof(ZControl)));

            [MethodImpl(Inline)]
            public Indexed<IScriptVar> Members()
                => members(this);

            [MethodImpl(Inline)]
            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }
    }
}