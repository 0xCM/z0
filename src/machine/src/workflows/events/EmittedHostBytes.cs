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
        const string Pattern = "{0}: Emitted {1} x86 code accessors for {2} api";

        public readonly ApiHostUri Host;

        public readonly ushort AccessorCount;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public EmittedHostBytes(ApiHostUri host, ushort count)
        {
            Host= host;
            AccessorCount = count;
            Timestamp = z.now();
        }        
        public string Format()
            => text.format(Pattern, Timestamp, AccessorCount, Host.Format());

        public string Description
            => Format();
        
        public override string ToString()
            => Format();
    }
}