//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct Adapter<H,S> : IAdapter<H,S>
        where H : IAdapter<H,S>, new()
    {
        public S Subject {get; private set;}

        [MethodImpl(Inline)]
        public Adapter(S subject)
            => Subject = subject;

        [MethodImpl(Inline)]
        public H Adapt(S subject)
        {
            Subject = subject;
            var host = new H();
            return host.Adapt(subject);
        }

        [MethodImpl(Inline)]
        public static implicit operator S(Adapter<H,S> src)
            => src.Subject;
    }
}