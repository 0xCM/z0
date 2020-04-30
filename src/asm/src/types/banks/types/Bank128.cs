//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using Storage = System.Runtime.Intrinsics.Vector256<byte>; 

    partial class Banks
    {
        public readonly ref struct Bank128
        {
            readonly Span<Fixed128> State;

            [MethodImpl(Inline)]
            internal Bank128(Span<Fixed128> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 2 128-bit registers
        /// </summary>
        public readonly struct Bank128x2 : IBank<Bank128x2,W128,N2>
        {            
            readonly Storage SegA;
  
            [MethodImpl(Inline)]
            internal Bank128x2(Storage a)
            {
                SegA = a;
            }
        }

        /// <summary>
        /// Defines storage for 4 128-bit registers
        /// </summary>
        public readonly struct Bank128x4 : IBank<Bank128x4,W128,N4>
        {            
            readonly Storage SegA;

            readonly Storage SegB;
            

            [MethodImpl(Inline)]
            internal Bank128x4(Storage a, Storage b)
            {
                SegA = a;
                SegB = b;
            }
        }
    }
}