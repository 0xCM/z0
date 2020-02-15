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
    public readonly struct CaptureState : IFormattable<CaptureState>
    {
        /// <summary>
        /// The empty state
        /// </summary>
        public static CaptureState Empty => new CaptureState(OpIdentity.Empty, 0,0,0);

        /// <summary>
        /// The subject identifier
        /// </summary>
        public readonly OpIdentity OpId;

        /// <summary>
        /// The zero-based and monotonically-increasing state index
        /// </summary>
        public readonly int Offset;

        /// <summary>
        /// The memory address from which the state payload was extracted
        /// </summary>
        public readonly MemoryAddress Location;

        /// <summary>
        /// The captured data
        /// </summary>
        public readonly byte Payload;

        /// <summary>
        /// Defines a capture state
        /// </summary>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="payload">The extracted data</param>
        [MethodImpl(Inline)]
        public static CaptureState Define(OpIdentity opid, int offset, long location, byte payload)
            => new CaptureState(opid,offset,location,payload);

        /// <summary>
        /// Defines a capture state
        /// </summary>
        /// <param name="offset">A zero-based and capture-relative index that identifes a state in the context of a capture workflow</param>
        /// <param name="location">The memory location from which data was extracted</param>
        /// <param name="payload">The extracted data</param>
        [MethodImpl(Inline)]
        public static CaptureState Define(OpIdentity opid, int offset, MemoryAddress location, byte payload)
            => new CaptureState(opid,offset,location,payload);

        [MethodImpl(Inline)]
        CaptureState(OpIdentity opid, int offset, long location, byte payload)
        {
            this.OpId = opid;
            this.Offset = offset - 1;
            this.Location = MemoryAddress.Define((ulong)location - 1ul);
            this.Payload = payload;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Offset == 0 && Location == 0 && Payload == 0;
        }

        public string Format()
            => concat(OpId.ToString(), space(), Offset.FormatAsmHex(4), space(), Location.Format(), space(), Payload.FormatHex());

        public override string ToString() 
            => Format();
    }
}