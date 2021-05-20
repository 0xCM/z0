//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Describes a bitfield segment
    /// </summary>
    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct BitfieldSpecEntry : IRecord<BitfieldSpecEntry>
    {
        public const string TableId = "bitfields.spec";

        public const byte FieldCount = 5;

        /// <summary>
        /// The bitfield name
        /// </summary>
        public utf8 Bitfield;

        /// <summary>
        /// The segment index
        /// </summary>
        public byte Index;

        /// <summary>
        /// The field name
        /// </summary>
        public utf8 Name;

        /// <summary>
        /// The 0-based bit index at which the field begins
        /// </summary>
        public byte Offset;

        /// <summary>
        /// The segment width
        /// </summary>
        public byte Width;
    }
}