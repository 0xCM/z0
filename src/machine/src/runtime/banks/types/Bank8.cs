//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Store128 = System.Runtime.Intrinsics.Vector128<byte>;
    using Store = System.Runtime.Intrinsics.Vector256<byte>;

    partial class Banks
    {
        public readonly ref struct Bank8
        {
            readonly Span<byte> State;

            [MethodImpl(Inline)]
            internal Bank8(Span<byte> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 16 8-bit registers
        /// </summary>
        public readonly struct Bank8x16 : IBank<Bank8x16,W8,N16>
        {
            readonly Store128 SegA;
            
            [MethodImpl(Inline)]
            internal Bank8x16(Store a)
            {
                SegA = Vector256.GetLower(a);
            }
        }

        /// <summary>
        /// Defines storage for 32 8-bit registers
        /// </summary>
        public readonly struct Bank8x32 : IBank<Bank8x32,W8,N32>
        {
            readonly Store SegA;

            [MethodImpl(Inline)]
            internal Bank8x32(Store a)
            {
                SegA = a;
            }
        }
    }
}