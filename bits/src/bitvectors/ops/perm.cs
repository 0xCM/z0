//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class bitvector
    {
        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 perm(ref BitVector16 x, in Perm spec)
        {
            var src = x.Replicate();
            ref var dst = ref x;
            var len = x.Length;
            for(var i=0; i<len; i++)
            {
                ref readonly var j = ref spec[i];
                if(j != i)
                    dst[i] = src[j];
            }
            return ref x;
        }        

        /// <summary>
        /// Creates a new vector by permuting a replica of the source vector as
        /// specified by a permuation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static BitVector16 perm(BitVector16 x, Perm spec)
        {
            var dst = x.Replicate();
            return perm(ref dst, spec);
        }

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 perm(ref BitVector32 x, in Perm spec)
        {
            var src = x.Replicate();
            ref var dst = ref x;
            var len = x.Length;
            for(var i=0; i<len; i++)
            {
                ref readonly var j = ref spec[i];
                if(j != i)
                    dst[i] = src[j];
            }
            return ref x;
        }        

        /// <summary>
        /// Creates a new vector by permuting a replica of the source vector as
        /// specified by a permuation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static BitVector32 perm(BitVector32 x, Perm spec)
        {
            var dst = x.Replicate();
            return perm(ref dst, spec);
        }

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 perm(ref BitVector64 x, in Perm spec)
        {
            var src = x.Replicate();
            ref var dst = ref x;
            var len = x.Length;
            for(var i=0; i<len; i++)
            {
                ref readonly var j = ref spec[i];
                if(j != i)
                    dst[i] = src[j];
            }
            return ref x;
        }        

        /// <summary>
        /// Creates a new vector by permuting a replica of the source vector as
        /// specified by a permuation
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static BitVector64 perm(BitVector64 x, Perm spec)
        {
            var dst = x.Replicate();
            return perm(ref dst, spec);
        }


    }

}