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
    using static Scripts;

    using api = Scripts;

    public readonly struct ScriptEnv : IScriptVars<ScriptEnv>
    {
        public Dir ZDev => (nameof(ZDev), Environment.GetEnvironmentVariable(nameof(ZDev)));

        public Dir ZDb => (nameof(ZDb), Environment.GetEnvironmentVariable(nameof(ZDb)));

        public Dir ZControl => (nameof(ZControl), Environment.GetEnvironmentVariable(nameof(ZControl)));

        [MethodImpl(Inline)]
        public Indexed<IScriptVar> Members()
            => api.members(this);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}