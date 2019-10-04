//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    partial class bitvector
    {

        public static BitVector4 mask(Perm spec, out BitVector4 mask)
        {
            mask = BitVector4.Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static ref BitVector8 mask(Perm spec, out BitVector8 mask)
        {
            mask = BitVector8.Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static ref BitVector16 mask(Perm spec, out BitVector16 mask)
        {
            mask = BitVector16.Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static ref BitVector32 mask(Perm spec, out BitVector32 mask)
        {
            mask = BitVector32.Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
                mask[spec[i]] = i; 
            return ref mask;
        }

        /// <summary>
        /// Creates a permutation-defined bitvector mask 
        /// </summary>
        /// <param name="spec">The permutation</param>
        public static ref BitVector64 mask(Perm spec, out BitVector64 mask)
        {
            mask = BitVector64.Alloc();
            var n = math.min(spec.Length, mask.Length);
            for(var i = 0; i < n; i++)
            {
                ref var j = ref spec[i];
                mask[j] = i; 
            }
            return ref mask;
        }
        
    }

}