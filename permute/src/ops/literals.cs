//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 4-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline)]
        public static Span<Perm4L> literals(Perm4L src)
        {            
            const int length = 4;

            var dst = new Perm4L[length];
            for(var i=0; i < length; i++)
                if(!literal(src,i, out dst[i]))
                    return Span<Perm4L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline)]
        public static bit literals(Perm8L src, Span<Perm8L> dst)
        {
            const int length = 8;

            for(var i=0; i< length; i++)
                if(!literal(src, i, out dst[i]))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline)]
        public static Span<Perm8L> literals(Perm8L src)
        {            
            const int length = 8;
            
            Span<Perm8L> dst = new Perm8L[length];
            if(!literals(src, dst))
                return Span<Perm8L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline)]
        public static bit literals(Perm16L src, Span<Perm16L> dst)
        {
            const int length = 16;

            for(var i=0; i< length; i++)
                if(!literal(src, i, out dst[i]))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        public static Span<Perm16L> literals(Perm16L src)
        {            
            const int length = 16;

            Span<Perm16L> dst = new Perm16L[length];
            if(!literals(src,dst))
                return Span<Perm16L>.Empty;
            
            return dst;
        }
    }
}