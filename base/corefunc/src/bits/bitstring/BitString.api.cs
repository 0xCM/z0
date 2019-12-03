//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    partial struct BitString
    {
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
        /// Allocates a bitstring with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString alloc(int len)
            => new BitString(new byte[len]);

        /// <summary>
        /// Constructs a bitstring from a clr string of 0's and 1's 
        /// </summary>
        /// <param name="src">The bit source</param>
        public static BitString parse(string src)                
        {
            src = src.RemoveWhitespace();
            var len = src.Length;
            var lastix = len - 1;
            Span<byte> dst = new byte[len];
            for(var i=0; i<= lastix; i++)
                dst[lastix - i] = src[i] == Bit.Zero ? (byte)0 : (byte)1;
            return new BitString(dst);                        
        }

        /// <summary>
        /// Assembles a bistring given parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The source parts</param>
        [MethodImpl(Inline)]
        public static BitString assemble(params string[] parts)
            => parse(string.Join(string.Empty, parts.Reverse()));

        /// <summary>
        /// Constructs a bitstring from a pattern replicated a specified number of times
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="reps">The number of times to repeat the pattern</param>
        /// <typeparam name="T">The primal source type</typeparam>
        public static BitString replicate<T>(T src, int reps)                
            where T : unmanaged
        {
            BitSize capacity = Unsafe.SizeOf<T>() * 8;
            Span<byte> bitseq = new byte[capacity*reps];            
            var pattern = scalar(src);
            for(var i=0; i<reps; i++)
                pattern.BitSeq.CopyTo(bitseq, i*capacity);
            return fromseq(bitseq);            
        }

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        [MethodImpl(Inline)]
        public static BitString from<T>(ReadOnlySpan<T> src, int? maxbits = null)
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
        public static BitString from<T>(Span<T> src, int? maxbits = null)
            where T : unmanaged
                => from(src.ReadOnly(), maxbits);

        /// <summary>
        /// Populates a bitstring from a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString from<T>(Vector128<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.from(src.ToSpan(), maxbits);

        /// <summary>
        /// Populates a bitstring from a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString from<T>(Vector256<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.from(src.ToSpan(), maxbits);

        /// <summary>
        /// Constructs a bitstring from a power of 2
        /// </summary>
        /// <param name="exp">The value of the expoonent</param>
        [MethodImpl(Inline)]
        public static BitString frompow2(int exp)
        {
            Span<byte> dst = stackalloc byte[exp + 1];
            dst[exp] = 1;
            return fromseq(dst);
        }

        /// <summary>
        /// Constructs a bitstring from bitseq parameter array
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString fromseq(params byte[] src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitseq
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString fromseq(ReadOnlySpan<byte> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitspan
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString from(ReadOnlySpan<bit> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from a parameter array of bits, ordered lo -> hi
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString from(bit[] src)                
            => new BitString(src);

        /// <summary>
        /// Projects a bitstring onto a caller-allocated span via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static void map<T>(BitString src, Func<bit,T> f, Span<T> dst)
        {
            for(var i=0; i<dst.Length; i++)
                dst[i] = f((bit)src.bitseq[i]);
        }

        [MethodImpl(Inline)]
        public static byte uint8(BitString src)
            => src.Scalar<byte>(0);

    }
}