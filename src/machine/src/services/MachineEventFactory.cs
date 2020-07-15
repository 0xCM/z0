//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MachineEventFactory : IMachineEvents
    {


        public static MachineEventFactory Service => default(MachineEventFactory);

        [MethodImpl(Inline)]
        public E Create<E>(ReadOnlySpan<byte> content, E model = default)
            where E : struct, IProcessedEvent<E>
                => model.Define(content);
    }
}