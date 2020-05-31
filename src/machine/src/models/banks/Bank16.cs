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
    
    using Storage = System.Runtime.Intrinsics.Vector256<ushort>;

    partial class CpuStorage
    {
        public readonly ref struct Bank16
        {
            readonly Span<ushort> State;

            [MethodImpl(Inline)]
            internal Bank16(Span<ushort> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 16 16-bit registers
        /// </summary>
        public readonly struct Bank16x16 : ICpuStorage<Bank16x16,W16,N16>
        {
            readonly Storage SegA;

            [MethodImpl(Inline)]
            internal Bank16x16(Storage a)
            {
                SegA = a;
            }
        }

        /// <summary>
        /// Defines storage for 32 16-bit registers
        /// </summary>
        public readonly struct Bank16x32 : ICpuStorage<Bank16x32,W16,N32>
        {
            readonly Storage SegA;

            readonly Storage SegB;

            [MethodImpl(Inline)]
            internal Bank16x32(Storage a, Storage b)
            {
                SegA = a;
                SegB = b;
            }             
        }
    }
}