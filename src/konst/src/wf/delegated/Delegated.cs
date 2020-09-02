//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using D = WfDelegates;

    [ApiHost]
    public readonly partial struct Delegated
    {
        [MethodImpl(Inline)]
        public static TableProjector<S,T> from<S,T>(D.TableProjector<S,T> fx)
            where S : struct
                => new TableProjector<S,T>(fx);

        [MethodImpl(Inline)]
        public static EventHandler<E> from<E>(D.EventHandler<E> fx)
            where E : struct, IWfEvent<E>
                => new EventHandler<E>(fx);

        [MethodImpl(Inline), Op]
        public static EventHandler from(D.EventHandler fx)
            => new EventHandler(fx);
    }
}