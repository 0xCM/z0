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

        /// <summary>
        /// Extracts a scalar value from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="offset">The bit position at which to begin extraction</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T scalar<T>(BitString src, int offset = 0)
            where T : unmanaged 
                => src.Scalar<T>(offset);
    }
}