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

    using Storage = System.Runtime.Intrinsics.Vector256<byte>;    

    partial class Banks
    {
        public readonly ref struct Bank512
        {
            readonly Span<Fixed512> State;

            [MethodImpl(Inline)]
            internal Bank512(Span<Fixed512> state)
            {
                State = state;
            }
        }

        /// <summary>
        /// Defines storage for 2 512-bit registers
        /// </summary>
        public readonly struct Bank512x2 : IBank<Bank512x2,W512,N2>
        {            
            readonly Storage SegA;

            readonly Storage SegB;

            readonly Storage SegC;

            readonly Storage SegD;
 
            [MethodImpl(Inline)]
            internal Bank512x2(Storage a, Storage b, Storage c, Storage d)
            {
                SegA = a;
                SegB = b;
                SegC = c;
                SegD = d;
            }
        }

        /// <summary>
        /// Defines storage for 4 512-bit registers
        /// </summary>
        public readonly struct Bank512x4 : IBank<Bank512x4,W512,N4>
        {            
            readonly Storage SegA;

            readonly Storage SegB;

            readonly Storage SegC;

            readonly Storage SegD;

            readonly Storage SegE;

            readonly Storage SegF;

            readonly Storage SegG;

            readonly Storage SegH;

            [MethodImpl(Inline)]
            internal Bank512x4(Storage a, Storage b, Storage c, Storage d, Storage e, Storage f, Storage g, Storage h)
            {
                SegA = a;
                SegB = b;
                SegC = c;
                SegD = d;
                SegE = e;
                SegF = f;
                SegG = g;
                SegH = h;
            }
        }        
    }
}