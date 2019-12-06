//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Extracts the diagonal from a generic bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static BitVector<T> diagonal<T>(in BitMatrix<T> A)
            where T : unmanaged
        {
            var n = bitsize<T>();            
            var dst = default(T);
            for(byte i=0; i < n; i++)
                gbits.set(ref dst, i,A[i,i]);
            return dst;                    
        }

        [MethodImpl(Inline)]
        public static BitVector4 diagonal(in BitMatrix4 A)                    
            => (byte)dinx.gather((uint)A, 0b1000_0100_0010_0001);
        
        [MethodImpl(Inline)]
        public static BitVector8 diagonal(in BitMatrix8 A)
        {
            const ulong mask = 0b10000000_01000000_00100000_00010000_00001000_00000100_00000010_00000001ul;
            return (byte)dinx.gather((ulong)A, mask);
        }

        /// <summary>
        /// Extracts the diagonal from a primal bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        public static BitVector16 diagonal(in BitMatrix16 A)
        {
            const uint N = 16;            
            var dst = (ushort)0;
            for(byte i=0; i < N; i++)
                gbits.set(ref dst, i,A[i,i]);
            return dst;                    
        }

        /// <summary>
        /// Extracts the diagonal from a primal bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        public static BitVector32 diagonal(in BitMatrix32 A)
        {
            const uint N = 32;            
            var dst = 0u;
            for(byte i=0; i < N; i++)
                gbits.set(ref dst, i,A[i,i]);
            return dst;                    
        }

        /// <summary>
        /// Extracts the diagonal from a primal bitmatrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        public static BitVector64 diagonal(in BitMatrix64 A)
        {
            const uint N = 64;            
            var dst = 0ul;
            for(byte i=0; i < N; i++)
                gbits.set(ref dst, i, A[i,i]);
            return dst;                    
        }
    }
}