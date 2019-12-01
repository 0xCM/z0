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

    partial class DataBlocks
    {

        /// <summary>
        /// Specifies the number of bytes in a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize(N32 n)
            => 32;

        /// <summary>
        /// Specifies the number of bytes in a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize(N64 n)
            => 8;

        /// <summary>
        /// Specifies the number of bytes in a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize(N128 n)
            => 16;

        /// <summary>
        /// Specifies the number of bytes in a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize(N256 n)
            => 32;

    }

}