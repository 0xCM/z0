//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {
        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 4-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        public static Span<Perm4> literals(Perm4 src)
        {            
            const int length = 4;

            var dst = new Perm4[length];
            for(var i=0; i < length; i++)
                if(!literal(src,i, out dst[i]))
                    return Span<Perm4>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline)]
        public static bit literals(Perm8 src, Span<Perm8> dst)
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
        public static Span<Perm8> literals(Perm8 src)
        {            
            const int length = 8;
            
            Span<Perm8> dst = new Perm8[length];
            if(!literals(src, dst))
                return Span<Perm8>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline)]
        public static bit literals(Perm16 src, Span<Perm16> dst)
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
        public static Span<Perm16> literals(Perm16 src)
        {            
            const int length = 16;

            Span<Perm16> dst = new Perm16[length];
            if(!literals(src,dst))
                return Span<Perm16>.Empty;
            
            return dst;
        }
    }
}