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
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector8 inc(ref BitVector8 x)
        {
            math.inc(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector8 inc(BitVector8 x)        
            => math.inc(x.data);
        

        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector16 inc(ref BitVector16 x)
        {
            math.inc(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector16 inc(BitVector16 x)        
            => math.inc(x.data);
        
        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector32 inc(ref BitVector32 x)
        {
            math.inc(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector32 inc(BitVector32 x)        
            => math.inc(x.data);

        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector64 inc(ref BitVector64 x)
        {
            math.inc(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector64 inc(BitVector64 x)        
            => math.inc(x.data);
    }

}