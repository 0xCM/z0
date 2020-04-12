//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
        
    using static Seed;

    /// <summary>
    /// Identifies an application-level/logical event
    /// </summary>
    public readonly struct MachineEvent
    {
        public readonly EventIdentity EventId;

        [MethodImpl(Inline)]
        public static MachineEvent Define(EventIdentity id)
            => new MachineEvent(id);

        [MethodImpl(Inline)]
        public static MachineEvent<T> Define<T>(EventIdentity id, T data)
            where T : unmanaged
            => new MachineEvent<T>(id, data);

        [MethodImpl(Inline)]
        public MachineEvent(EventIdentity id)
            => EventId = id;
    }

    /// <summary>
    /// Represents an application-level/logical event with which data specific to an event class is associated
    /// </summary>
    public readonly struct MachineEvent<T>
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
        public static MachineEvent<T> Materialize(Span<byte> src)
            => MemoryMarshal.Read<MachineEvent<T>>(src);

        [MethodImpl(Inline)]
        public static implicit operator MachineEvent(MachineEvent<T> src)
            => new MachineEvent(src.EventId);

        [MethodImpl(Inline)]
        public MachineEvent(EventIdentity id, T data)
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