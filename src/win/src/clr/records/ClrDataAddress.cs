//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// A representation of CLR's CLRDATA_ADDRESS, which is a signed 64bit integer.
    /// Unfortuantely this can cause issues when inspecting 32bit processes, since
    /// if the highest bit is set the value will be sign-extended.  This struct is
    /// meant to
    /// </summary>
    [DebuggerDisplay("{AsUInt64()}")]
    public struct ClrDataAddress
    {
        /// <summary>
        /// Gets raw value of this address.  May be sign-extended if inspecting a 32bit process.
        /// </summary>
        public long Value { get; }

        /// <summary>
        /// Creates an instance of ClrDataAddress.
        /// </summary>
        /// <param name="value"></param>
        public ClrDataAddress(long value) 
            => Value = value;

        /// <summary>
        /// Returns the value of this address and un-sign extends the value if appropriate.
        /// </summary>
        /// <param name="cda">The address to convert.</param>
        public static implicit operator ulong(ClrDataAddress cda) 
            => cda.AsUInt64();

        /// <summary>
        /// Returns the value of this address and un-sign extends the value if appropriate.
        /// </summary>
        /// <returns>The value of this address and un-sign extends the value if appropriate.</returns>
        private ulong AsUInt64() 
            => IntPtr.Size == 4 
            ? unchecked((uint)Value) 
            : unchecked((ulong)Value);
    }        

}