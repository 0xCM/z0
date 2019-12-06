//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;   

    partial class BitVector
    {
        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 gather(BitVector4 src, BitVector4 spec)
            => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 gather(BitVector8 src, BitVector8 spec)
            => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 gather(BitVector16 src, BitVector16 spec)
            => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 gather(BitVector32 src, BitVector32 spec)
            => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 gather(BitVector64 src, BitVector64 spec)
            => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector<T> gather<T>(BitVector<T> src, BitVector<T> spec)
            where T : unmanaged
                => ginx.gather(src.data, spec.data);

        /// <summary>
        /// Populates a target vector with specified source bits
        /// </summary>
        /// <param name="spec">Identifies the source bits of interest</param>
        /// <param name="dst">Receives the identified bits</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> gather<N,T>(BitVector<N,T> src, BitVector<N,T> spec)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ginx.gather(src.data, spec.data);
    }
}