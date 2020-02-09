//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines the state of the routine capture workflow at a given step
    /// </summary>
    public readonly struct CaptureState
    {
        /// <summary>
        /// The empty state
        /// </summary>
        public static CaptureState Empty => new CaptureState(0,0,0);

        /// <summary>
        /// The zero-based, and strictly monotonically-increasing, state index
        /// </summary>
        public readonly int Offset;

        /// <summary>
        /// The memory address from which the state payload was extracted
        /// </summary>
        public readonly long Location;

        /// <summary>
        /// The captured data
        /// </summary>
        public readonly byte Payload;

        [MethodImpl(Inline)]
        public static implicit operator CaptureState((int offset, long location, byte payload) src)
            => Define(src.offset, src.location, src.payload);

        /// <summary>
        /// Defines a capture state
        /// </summary>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in 
        /// the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="payload">The extracted data</param>
        [MethodImpl(Inline)]
        public static CaptureState Define(int offset, long location, byte payload)
            => new CaptureState(offset,location,payload);
        
        [MethodImpl(Inline)]
        CaptureState(int offset, long location, byte payload)
        {
            this.Offset = offset - 1;
            this.Location = location - 1;
            this.Payload = payload;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out int offset, out long location, out byte value)        
        {
            offset = Offset;
            location = Location;
            value = Payload;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Offset == 0 && Location == 0 && Payload == 0;
        }

        public override string ToString() 
            => concat(Offset.FormatAsmHex(4), space(), Location.FormatAsmHex(14), space(), Payload.FormatHex());
    }
}