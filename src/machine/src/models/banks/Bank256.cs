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

    using Storage = System.Runtime.Intrinsics.Vector256<byte>;    
    
    partial class CpuStorage
    {
        public readonly ref struct Bank256
        {
            readonly Span<Fixed256> State;

            [MethodImpl(Inline)]
            internal Bank256(Span<Fixed256> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 2 256-bit registers
        /// </summary>
        public readonly struct Bank256x2 : ICpuStorage<Bank256x2,W256,N2>
        {            
            readonly Storage SegA;

            readonly Storage SegB;

            [MethodImpl(Inline)]
            internal Bank256x2(Storage a, Storage b)
            {
                SegA = a;
                SegB = b;
            }
        }

        /// <summary>
        /// Defines storage for 4 256-bit registers
        /// </summary>
        public readonly struct Bank256x4 : ICpuStorage<Bank256x4,W256,N4>
        {            
            readonly Storage SegA;

            readonly Storage SegB;
            
            readonly Storage SegC;

            readonly Storage SegD;        

            [MethodImpl(Inline)]
            internal Bank256x4(Storage a, Storage b, Storage c, Storage d)
            {
                SegA = a;
                SegB = b;
                SegC = c;
                SegD = d;
            }
       }
    }
}