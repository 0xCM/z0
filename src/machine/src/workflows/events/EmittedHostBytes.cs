//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedHostBytes : IAppEvent<EmittedHostBytes>
    {
        const string Pattern = "Emitted {0} x86 code accessors for {1} api";

        public readonly ApiHostUri Host;

        public readonly ushort AccessorCount;

        [MethodImpl(Inline)]
        public EmittedHostBytes(ApiHostUri host, ushort count)
        {
            Host= host;
            AccessorCount = count;
        }        
        public string Format()
            => text.format(Pattern, AccessorCount, Host.Format());

        public string Description
            => Format();
        
        public override string ToString()
            => Format();
    }
}