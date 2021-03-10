//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Represents a VSIB address
    /// </summary>
    /// <remarks>
    /// Documentation teken from vol 4 of ADM reference manuals, p. 6
    /// </remarks>
    public struct Vsib
    {
        ulong Data;

        ref byte VsibBits
        {
            [MethodImpl(Inline)]
            get => ref seek(bytes(Data),7);
        }

        /// <summary>
        /// VSIB.base, Bits [3:0]
        /// </summary>
        /// <remarks>
        /// This field is concatenated with the complement of the VEX.B bit ({B, base})
        /// to specify the general-purpose register (base GPR) that contains the base address base
        /// to be used in the computation of each of the effective addresses
        /// </remarks>
        public uint3 Base
        {
            [MethodImpl(Inline)]
            get => (uint3)VsibBits;
            [MethodImpl(Inline)]
            set => VsibBits |= (byte)value;
        }

        /// <summary>
        /// VSIB.index, Bits [5:3]
        /// </summary>
        /// <remarks>
        /// This field is concatenated with the complement of the VEX.X bit ({X, index}) to specify the YMM/XMM
        /// register that contains the packed array of index values index[i] to be used in the computation of
        /// the array of effective addresses effective address[i].
        /// </remarks>
        public uint3 Index
        {
            [MethodImpl(Inline)]
            get => (uint3)(VsibBits >> 3);

            [MethodImpl(Inline)]
            set => VsibBits |= (byte)((byte)value << 3);
        }

        /// <summary>
        /// VSIB.SS, Bits [7:6]
        /// </summary>
        /// <remarks>
        /// The SS field is used to specify the scale factor to be used in the computation of each of the
        /// effective addresses. The scale factor scale is equal to 2^SS. Therefore,
        /// SS = 00b => scale = 1
        /// SS = 01b => scale = 2
        /// SS = 10b => scale = 4
        /// SS = 11b => scale = 8
        /// </remarks>
        public uint2 SS
        {
            [MethodImpl(Inline)]
            get => (uint2)(VsibBits >> 6);

            [MethodImpl(Inline)]
            set => VsibBits |= (byte)((byte)value << 6);
        }

        [MethodImpl(Inline)]
        public byte Scale()
            => (byte)Pow2.pow(SS);


        /// <summary>
        /// Computes the effective address for an index-identified register
        /// </summary>
        /// <param name="index"></param>
        /// <remarks>
        /// Each element i of the effective address array is computed using the formula:
        /// effective address[i] = scale * index[i] + base + displacement, where index[i]
        /// is the ith element of the XMM/YMM register specified by {X, VSIB.index}.
        /// An index element is either 32 or 64 bits wide and is treated as a signed integer
        /// </remarks>
        public MemoryAddress Effective(byte index)
        {

            return default;
        }

    }
}