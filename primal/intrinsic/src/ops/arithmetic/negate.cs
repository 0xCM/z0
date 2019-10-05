//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;

    partial class dinx    
    {

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vnegate(in Vec128<sbyte> src)
            =>  vsub(Vec128<sbyte>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vnegate(in Vec128<byte> src)
            =>  vadd(BitUtil.flip(src), Vec128.Ones<byte>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vnegate(in Vec128<short> src)
            =>  vsub(Vec128<short>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vnegate(in Vec128<ushort> src)
            =>  vadd(BitUtil.flip(src), Vec128.Ones<ushort>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vnegate(in Vec128<int> src)
            =>  vsub(Vec128<int>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vnegate(in Vec128<uint> src)
            =>  vadd(BitUtil.flip(src), Vec128.Ones<uint>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vnegate(in Vec128<long> src)
            =>  vsub(Vec128<long>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vnegate(in Vec128<ulong> src)
            =>  vadd(BitUtil.flip(src), Vec128.Ones<ulong>());

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vnegate(in Vec256<byte> src)
            =>  vadd(BitUtil.flip(src), Vec256.Ones<byte>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vnegate(in Vec256<short> src)
            =>  vsub(Vec256<short>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vnegate(in Vec256<ushort> src)
            =>  vadd(BitUtil.flip(src), Vec256.Ones<ushort>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vnegate(in Vec256<int> src)
            =>  vsub(Vec256<int>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vnegate(in Vec256<uint> src)
            =>  vadd(BitUtil.flip(src), Vec256.Ones<uint>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vnegate(in Vec256<long> src)
            =>  vsub(Vec256<long>.Zero, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vnegate(in Vec256<ulong> src)
            =>  vadd(BitUtil.flip(src), Vec256.Ones<ulong>());

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vnegate(in Vec256<sbyte> src)
            =>  vsub(Vec256<sbyte>.Zero, src);

    }
}