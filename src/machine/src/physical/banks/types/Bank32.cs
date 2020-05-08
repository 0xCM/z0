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
    
    using Storage = System.Runtime.Intrinsics.Vector256<uint>;

    partial class Banks
    {
        public readonly ref struct Bank32
        {
            readonly Span<uint> State;

            [MethodImpl(Inline)]
            internal Bank32(Span<uint> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 16 32-bit registers
        /// </summary>
        public readonly struct Bank32x16 : IBank<Bank32x16,W32,N16>
        {                        
            readonly Storage SegA;

            readonly Storage SegB;

            [MethodImpl(Inline)]
            internal Bank32x16(Storage a, Storage b)
            {
                SegA = a;
                SegB = b;
            }
        }

        /// <summary>
        /// Defines storage for 32 32-bit registers
        /// </summary>
        public readonly struct Bank32x32 : IBank<Bank32x32,W32,N32>
        {            
            readonly Storage SegA;

            readonly Storage SegB;

            readonly Storage SegC;

            readonly Storage SegD;

            [MethodImpl(Inline)]
            internal Bank32x32(Storage a, Storage b, Storage c, Storage d)
            {
                SegA = a;
                SegB = b;
                SegC = c;
                SegD = d;
            }
        }
    }
}