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
        public static ref BitVector8 dec(ref BitVector8 x)
        {
            math.dec(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector8 dec(BitVector8 x)        
            => math.dec(x.data);
        

        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector16 dec(ref BitVector16 x)
        {
            math.dec(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector16 dec(BitVector16 x)        
            => math.dec(x.data);
        
        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector32 dec(ref BitVector32 x)
        {
            math.dec(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector32 dec(BitVector32 x)        
            => math.dec(x.data);

        /// <summary>
        /// Increments a vector in-place
        /// </summary>
        /// <param name="x">The source vector</param>
        public static ref BitVector64 dec(ref BitVector64 x)
        {
            math.dec(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Increments the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector64 dec(BitVector64 x)        
            => math.dec(x.data);


    }

}