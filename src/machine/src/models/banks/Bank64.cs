//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;
    
    using Storage = System.Runtime.Intrinsics.Vector256<ulong>;

    partial class CpuStorage
    {
        public readonly ref struct Bank64
        {
            readonly Span<ulong> State;

            [MethodImpl(Inline)]
            internal Bank64(Span<ulong> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 16 64-bit registers
        /// </summary>
        public readonly struct Bank64x16 : ICpuStorage<Bank64x16,W64,N16>
        {                        
            readonly Storage SegA;

            readonly Storage SegB;

            readonly Storage SegC;

            readonly Storage SegD;

            [MethodImpl(Inline)]
            internal Bank64x16(Storage a, Storage b, Storage c, Storage d)
            {
                SegA = a;
                SegB = b;
                SegC = c;
                SegD = d;                
            }
        }
    }
}