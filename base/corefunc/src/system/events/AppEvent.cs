//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
        
    using static zfunc;

    /// <summary>
    /// Represents an application-level/logical event that contains
    /// only identifying/classifing information in the form
    /// of an event identifier
    /// </summary>
    public readonly struct AppEvent
    {
        public readonly EventIdentity EventId;

        [MethodImpl(Inline)]
        public static AppEvent Define(EventIdentity id)
            => new AppEvent(id);

        [MethodImpl(Inline)]
        public static AppEvent<T> Define<T>(EventIdentity id, T data)
            where T : unmanaged
            => new AppEvent<T>(id, data);

        [MethodImpl(Inline)]
        public AppEvent(EventIdentity id)
            => EventId = id;
    }

    /// <summary>
    /// Represents an application-level/logical event with which data
    /// specific to an event class is associated
    /// </summary>
    public readonly struct AppEvent<T>
        where T : unmanaged
    {
        public readonly EventIdentity EventId;

        /// <summary>
        /// Data specific to an event class
        /// </summary>
        public readonly T Payload;

        /// <summary>
        /// Reconstitutes an event from a sequence of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public static AppEvent<T> Materialize(Span<byte> src)
            => read<AppEvent<T>>(src);

        [MethodImpl(Inline)]
        public static implicit operator AppEvent(AppEvent<T> src)
            => new AppEvent(src.EventId);

        [MethodImpl(Inline)]
        public AppEvent(EventIdentity id, T data)
        {
            EventId = id;
            Payload = data;
        }            

        /// <summary>
        /// Renders the event as a sequence of bytes
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Serialize()
            => BitConvert.GetBytes(this);
        
    }
}