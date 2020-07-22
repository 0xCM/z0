//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines logical event identity
    /// </summary>
    public readonly struct AppEventIdentity
    {        
        readonly Vector128<ulong> Data;

        /// <summary>
        /// Defines event identity predicated on the originating part/host, an event classifier and the time of occurrence
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="ts">The time of occurrence</param>
        /// <param name="kind">The kind of event that occurred</param>
        [MethodImpl(Inline)]
        public static AppEventIdentity define(ulong ts, uint origin, uint kind)
            => new AppEventIdentity(ts, origin, kind);

        [MethodImpl(Inline)]
        public AppEventIdentity(ulong ts, uint origin, uint kind)
            => Data = vparts(w128, ts, (ulong)origin | ((ulong)kind << 32));

        /// <summary>
        /// The event classifier/discriminator
        /// </summary>        
        public readonly uint Kind
        {
            [MethodImpl(Inline)]
            get => vcell32(Data,3);
        }

        /// <summary>
        /// The originating part/host
        /// </summary>
        public readonly uint Origin
        {
            [MethodImpl(Inline)]
            get => vcell32(Data,2);
        }

        /// <summary>
        /// Represents the time at which the event originated
        /// </summary>
        public ulong Timestamp
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }
 
        [MethodImpl(Inline)]
        public string Format() 
            => $"{Kind}/{Origin}/{Timestamp}";
    }
}