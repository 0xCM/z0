//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Ref : IRef
    {
        readonly StrongBox<dynamic> Box;

        [MethodImpl(Inline)]
        internal Ref(dynamic src)
        {
            Box = new StrongBox<dynamic>(src);
        }

        [MethodImpl(Inline)]
        public dynamic Target()
            => Box.Value;

        [MethodImpl(Inline)]
        public T Target<T>()
            => (T)Box.Value;
    }
}