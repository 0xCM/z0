
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    /// <summary>
    /// The ACCESS_MASK type is a bitmask that specifies a set of access rights in the access mask of an access control entry.
    /// </summary>
    /// <remarks>
    /// Quite well described here: http://blogs.msdn.com/b/openspecification/archive/2010/04/01/about-the-access-mask-structure.aspx.
    /// </remarks>
    public struct ACCESS_MASK : IComparable, IComparable<ACCESS_MASK>, IEquatable<ACCESS_MASK>, IFormattable
    {
        /// <summary>
        /// Bits 28-31.
        /// </summary>
        private const uint GenericRightsMask = 0xf0000000;

        /// <summary>
        /// Bits 24-27.
        /// </summary>
        private const uint SpecialRightsMask = 0x0f000000;

        /// <summary>
        /// Bits 16-23.
        /// </summary>
        private const uint StandardRightsMask = 0x00ff0000;

        /// <summary>
        /// Bits 0-15.
        /// </summary>
        private const uint SpecificRightsMask = 0x0000ffff;

        /// <summary>
        /// Initializes a new instance of the <see cref="ACCESS_MASK"/> struct.
        /// </summary>
        /// <param name="value">The value for the <see cref="ACCESS_MASK"/>.</param>
        public ACCESS_MASK(uint value)
        {
            this.Value = value;
        }


        /// <summary>
        /// Gets the ACCESS_MASK as a 32-bit unsigned integer.
        /// </summary>
        public uint Value { get; }

        /// <summary>
        /// Gets the ACCESS_MASK as a 32-bit signed integer.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AsInt32 => (int)this.Value;

        /// <summary>
        /// Gets the generic rights of this value.
        /// </summary>
        public GenericRight GenericRights 
            => (GenericRight)(this.Value & GenericRightsMask);

        /// <summary>
        /// Gets the special rights of this value.
        /// </summary>
        public SpecialRight SpecialRights 
            => (SpecialRight)(this.Value & SpecialRightsMask);

        /// <summary>
        /// Gets the standard rights of this value.
        /// </summary>
        public StandardRight StandardRights 
            => (StandardRight)(this.Value & StandardRightsMask);

        /// <summary>
        /// Gets the specific rights of this value.
        /// </summary>
        public SpecificRight SpecificRights => (SpecificRight)(this.Value & SpecificRightsMask);

        /// <summary>
        /// Gets the specific rights of this value for desktops.
        /// </summary>
        public DesktopSpecificRight DesktopSpecificRights => (DesktopSpecificRight)this.SpecificRights;

        /// <summary>
        /// Gets the generic rights of this value for interactive window stations.
        /// </summary>
        public InteractiveWindowStationGenericRight InteractiveWindowStationGenericRights => (InteractiveWindowStationGenericRight)this.GenericRights;

        /// <summary>
        /// Gets the generic rights of this value for noninteractive window stations.
        /// </summary>
        public NonInteractiveWindowStationGenericRight NonInteractiveWindowStationGenericRights => (NonInteractiveWindowStationGenericRight)this.GenericRights;

        /// <summary>
        /// Gets the specific rights of this value for window stations.
        /// </summary>
        public WindowStationSpecificRight WindowStationSpecificRights => (WindowStationSpecificRight)this.SpecificRights;

        /// <summary>
        /// Converts an <see cref="int"/> into an <see cref="ACCESS_MASK"/>.
        /// </summary>
        /// <param name="value">The value of the ACCESS_MASK.</param>
        public static implicit operator ACCESS_MASK(int value) => new ACCESS_MASK((uint)value);

        /// <summary>
        /// Converts an <see cref="ACCESS_MASK"/> into an <see cref="int"/>.
        /// </summary>
        /// <param name="value">The value of the ACCESS_MASK.</param>
        public static explicit operator int(ACCESS_MASK value) => value.AsInt32;

        /// <summary>
        /// Converts an <see cref="uint"/> into an <see cref="ACCESS_MASK"/>.
        /// </summary>
        /// <param name="value">The value of the ACCESS_MASK.</param>
        public static implicit operator ACCESS_MASK(uint value) => new ACCESS_MASK(value);

        /// <summary>
        /// Converts an <see cref="ACCESS_MASK"/> into an <see cref="uint"/>.
        /// </summary>
        /// <param name="value">The value of the ACCESS_MASK.</param>
        public static implicit operator uint(ACCESS_MASK value) => value.Value;

        /// <summary>
        /// Converts a <see cref="StandardRight"/> to an <see cref="ACCESS_MASK"/>.
        /// </summary>
        /// <param name="value">The value for the <see cref="ACCESS_MASK"/>.</param>
        public static implicit operator ACCESS_MASK(StandardRight value) => new ACCESS_MASK((uint)value);

        /// <summary>
        /// Converts a <see cref="GenericRight"/> to an <see cref="ACCESS_MASK"/>.
        /// </summary>
        /// <param name="value">The value for the <see cref="ACCESS_MASK"/>.</param>
        public static implicit operator ACCESS_MASK(GenericRight value) => new ACCESS_MASK((uint)value);

        /// <summary>
        /// Converts a <see cref="SpecificRight"/> to an <see cref="ACCESS_MASK"/>.
        /// </summary>
        /// <param name="value">The value for the <see cref="ACCESS_MASK"/>.</param>
        public static implicit operator ACCESS_MASK(SpecificRight value) => new ACCESS_MASK((uint)value);

        /// <inheritdoc />
        public override int GetHashCode() => this.AsInt32;

        /// <inheritdoc />
        public bool Equals(ACCESS_MASK other) => this.Value == other.Value;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is ACCESS_MASK && this.Equals((ACCESS_MASK)obj);

        /// <inheritdoc />
        public int CompareTo(object obj) => ((IComparable)this.Value).CompareTo(obj);

        /// <inheritdoc />
        public int CompareTo(ACCESS_MASK other) => this.Value.CompareTo(other.Value);

        /// <inheritdoc />
        public override string ToString() => this.Value.ToString();

        /// <inheritdoc />
        public string ToString(string format, IFormatProvider formatProvider) => this.Value.ToString(format, formatProvider);
    }
}