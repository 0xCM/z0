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
    using static As;

    partial class Stacked
    {
        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head8(ref MemStack64 src)
            => ref uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head64(ref MemStack64 src)
            => ref src.X0;

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head64(ref MemStack128 src)
            => ref src.X0;

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head8(ref MemStack128 src)
            => ref uint8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ushort head16(ref MemStack128 src) 
            => ref uint16(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head8(ref MemStack256 src)
            => ref head8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head64(ref MemStack256 src)
            => ref head64(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head8(ref MemStack512 src)
            => ref head8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head64(ref MemStack512 src)
            => ref head64(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as a byte reference
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head8(ref MemStack1024 src)
            => ref head8(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head64(ref MemStack1024 src)
            => ref head64(ref src.X0);

        public ref struct MemStack64
        {
            public const int Size = 8;            

            internal ulong X0;
        }

        /// <summary>
        /// Defines 16 bytes = 512 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack128
        {
            public const int Size = 16;

            public ulong X0;

            public ulong X1;      
                                      
        }

        /// <summary>
        /// Covers 32 bytes = 256 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack256
        {
            public const int Size = 32;

            internal MemStack128 X0;

            MemStack128 X1;
        }

        /// <summary>
        /// Covers 64 bytes = 512 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack512
        {
            public const int Size = 64;            

            internal MemStack256 X0;

            MemStack256 X1;
        }

        /// <summary>
        /// Covers 128 bytes = 1024 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack1024
        {
            public const int Size = 128;            

            internal MemStack512 X0;

            MemStack512 X1;
        }
    }
}