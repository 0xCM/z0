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
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vdec(in Vec128<sbyte> src)
            =>  vsub(src, Vec128Pattern.units<sbyte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vdec(in Vec128<byte> src)
            =>  vsub(src, Vec128Pattern.units<byte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vdec(in Vec128<short> src)
            =>  vsub(src, Vec128Pattern.units<short>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vdec(in Vec128<ushort> src)
            =>  vsub(src, Vec128Pattern.units<ushort>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vdec(in Vec128<int> src)
            =>  vsub(src, Vec128Pattern.units<int>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vdec(in Vec128<uint> src)
            =>  vsub(src, Vec128Pattern.units<uint>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vdec(in Vec128<long> src)
            =>  vsub(src, Vec128Pattern.units<long>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vdec(in Vec128<ulong> src)
            =>  vsub(src, Vec128Pattern.units<ulong>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vdec(in Vec256<sbyte> src)
            =>  vsub(src, Vec256Pattern.Units<sbyte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vdec(in Vec256<byte> src)
            =>  vsub(src, Vec256Pattern.Units<byte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vdec(in Vec256<short> src)
            =>  vsub(src, Vec256Pattern.Units<short>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vdec(in Vec256<ushort> src)
            =>  vsub(src, Vec256Pattern.Units<ushort>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vdec(in Vec256<int> src)
            =>  vsub(src, Vec256Pattern.Units<int>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vdec(in Vec256<uint> src)
            =>  vsub(src, Vec256Pattern.Units<uint>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vdec(in Vec256<long> src)
            =>  vsub(src, Vec256Pattern.Units<long>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vdec(in Vec256<ulong> src)
            =>  vsub(src, Vec256Pattern.Units<ulong>());


    }
}