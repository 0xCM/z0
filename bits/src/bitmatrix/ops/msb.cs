//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {

        /// <summary>
        /// Computes the position of the MSB for each row. 
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <returns></returns>
        public static Vector<N64,byte> msb(BitMatrix64 A)
        {
            var x = Vector.alloc<N64,byte>();            
            for(var i = 0; i<A.RowCount; i++)
                x[i] = Bits.nlz(A[i]);
            return x;
        }

        public static Vector<N64,byte> lsb(BitMatrix64 A)
        {
            var x = Vector.alloc<N64,byte>();            
            for(var i = 0; i<A.RowCount; i++)
                x[i] = Bits.ntz(A[i]);
            return x;
        }

    }
}