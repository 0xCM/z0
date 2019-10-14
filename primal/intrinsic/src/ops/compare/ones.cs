//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {   
        /// <summary>
        /// Returns a 128x8u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<byte> ones_128x8u()
            => CompareEqual(default(Vector128<byte>), default(Vector128<byte>));

        /// <summary>
        /// Returns a 128x8i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> ones_128x8i()
            => CompareEqual(default(Vector128<sbyte>), default(Vector128<sbyte>));

        /// <summary>
        /// Returns a 128x16i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<short> ones_128x16i()
            => CompareEqual(default(Vector128<short>), default(Vector128<short>));

        /// <summary>
        /// Returns a 128x16u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> ones_128x16u()
            => CompareEqual(default(Vector128<ushort>), default(Vector128<ushort>));

        /// <summary>
        /// Returns a 128x32i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<int> ones_128x32i()
            => CompareEqual(default(Vec128<int>), default(Vec128<int>));

        /// <summary>
        /// Returns a 128x32u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<uint> ones_128x32u()
            => CompareEqual(default(Vec128<uint>), default(Vec128<uint>));

        /// <summary>
        /// Returns a 128x64i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<long> ones_128x64i()
            => CompareEqual(default(Vec128<long>), default(Vec128<long>));

        /// <summary>
        /// Returns a 128x64u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ulong> ones_128x64u()
            => CompareEqual(default(Vec128<ulong>), default(Vec128<ulong>));

        /// <summary>
        /// Returns a 128x8u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<byte> ones_256x8u()
            => CompareEqual(default(Vector256<byte>), default(Vector256<byte>));

        /// <summary>
        /// Returns a 256x8i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> ones_256x8i()
            => CompareEqual(default(Vector256<sbyte>), default(Vector256<sbyte>));

        /// <summary>
        /// Returns a 256x16i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<short> ones_256x16i()
            => CompareEqual(default(Vector256<short>), default(Vector256<short>));

        /// <summary>
        /// Returns a 256x16u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<ushort> ones_256x16u()
            => CompareEqual(default(Vector256<ushort>), default(Vector256<ushort>));

        /// <summary>
        /// Returns a 256x32i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<int> ones_256x32i()
            => CompareEqual(default(Vec256<int>), default(Vec256<int>));

        /// <summary>
        /// Returns a 256x32u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<uint> ones_256x32u()
            => CompareEqual(default(Vec256<uint>), default(Vec256<uint>));

        /// <summary>
        /// Returns a 256x64i vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<long> ones_256x64i()
            => CompareEqual(default(Vec256<long>), default(Vec256<long>));

        /// <summary>
        /// Returns a 256x64u vector where all bits are enabled
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec256<ulong> ones_256x64u()
            => CompareEqual(default(Vec256<ulong>), default(Vec256<ulong>));

    }
}