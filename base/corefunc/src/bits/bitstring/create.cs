//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial struct BitString
    {
        /// <summary>
        /// Allocates a bitstring with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString alloc(int len)
            => new BitString(new byte[len]);

        /// <summary>
        /// Loads a bitstring from a bitseq
        /// </summary>
        /// <param name="bitseq">An array containing only 0's and 1's </param>
        [MethodImpl(Inline)]
        public static BitString load(byte[] bitseq)
            => new BitString(bitseq);

        /// <summary>
        /// Constructs a bitstring from bitseq
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString load(ReadOnlySpan<byte> src)                
            => new BitString(src);

        /// <summary>
        /// Populates a bitstring from a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString load<T>(Vector128<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.scalars(src.ToSpan(), maxbits);

        /// <summary>
        /// Populates a bitstring from a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString load<T>(Vector256<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.scalars(src.ToSpan(), maxbits);

        /// <summary>
        /// Constructs a bitstring from bitspan
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString load(ReadOnlySpan<bit> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from primal value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalar<T>(T src, int? maxbits = null)
            where T : unmanaged
                => new BitString(BitStore.bitseq(src, maxbits ?? bitsize<T>()));                

        /// <summary>
        /// Constructs a bitstring from primal value, using caller-supplied storage instead of allocation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="storage">The caller-supplied storage</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalar<T>(T src, byte[] storage, int? maxbits = null)
            where T : unmanaged
        {
            var bitseq = BitStore.bitseq(src, maxbits ?? bitsize<T>());
            bitseq.CopyTo(storage);
            return new BitString(storage);
        }

        /// <summary>
        /// Converts an enumeration value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static BitString @enum<T>(T src, int? maxbits = null)
            where T : unmanaged, Enum
                => BitString.scalar((ulong)Convert.ChangeType(src, typeof(ulong)), maxbits ?? bitsize<T>());        

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        [MethodImpl(Inline)]
        public static BitString scalars<T>(ReadOnlySpan<T> src, int? maxbits = null)
            where T : unmanaged
        {
            var segbits = bitsize<T>();
            var bitcount = maxbits ?? segbits*src.Length;
            var k = 0;
            var bitseq = new byte[bitcount];
            for(int i=0; i<src.Length; i++)
            {
                var bits = BitStore.bitseq(src[i]);
                for(var j = 0; j<segbits && k<bitcount; j++, k++)
                    bitseq[k] = bits[j];                        
            }
            return new BitString(bitseq);
        }

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalars<T>(Span<T> src, int? maxbits = null)
            where T : unmanaged
                => scalars(src.ReadOnly(), maxbits);

        /// <summary>
        /// Constructs a bitstring from a power of 2
        /// </summary>
        /// <param name="exp">The value of the expoonent</param>
        [MethodImpl(Inline)]
        public static BitString pow2(int exp)
        {
            var dst =  new byte[exp + 1];
            dst[exp] = 1;
            return load(dst);
        }

    }

}