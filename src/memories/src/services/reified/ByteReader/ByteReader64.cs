//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;

    partial struct ByteReader
    {
        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N0 n)    
            => skip8(src,n);
                    
        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N1 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N2 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N3 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N4 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N5 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N6 n)    
            => skip8(src,n);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        public static byte Read(ulong src, N7 n)    
            => skip8(src,n);
    }
}