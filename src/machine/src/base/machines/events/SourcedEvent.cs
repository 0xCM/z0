//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;

    /// <summary>
    /// Identifies an application-level/logical event
    /// </summary>
    public readonly struct SourcedEvent
    {
        public readonly EventIdentity EventId;

        [MethodImpl(Inline)]
        public static SourcedEvent define(EventIdentity id)
            => new SourcedEvent(id);

        [MethodImpl(Inline)]
        public static SourcedEvent<T> define<T>(EventIdentity id, T data)
            where T : unmanaged
            => new SourcedEvent<T>(id, data);

        [MethodImpl(Inline)]
        public SourcedEvent(EventIdentity id)
            => EventId = id;
    }
}