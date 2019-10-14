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
        public static Vec128<sbyte> vinc(in Vec128<sbyte> src)
            =>  vadd(src, Vec128Pattern.units<sbyte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vinc(in Vec128<byte> src)
            =>  vadd(src, Vec128Pattern.units<byte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vinc(in Vec128<short> src)
            =>  vadd(src, Vec128Pattern.units<short>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vinc(in Vec128<ushort> src)
            =>  vadd(src, Vec128Pattern.units<ushort>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vinc(in Vec128<int> src)
            =>  vadd(src, Vec128Pattern.units<int>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vinc(in Vec128<uint> src)
            =>  vadd(src, Vec128Pattern.units<uint>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vinc(in Vec128<long> src)
            =>  vadd(src, Vec128Pattern.units<long>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vinc(in Vec128<ulong> src)
            =>  vadd(src, Vec128Pattern.units<ulong>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vinc(in Vec256<sbyte> src)
            =>  vadd(src, Vec256Pattern.Units<sbyte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vinc(in Vec256<byte> src)
            =>  vadd(src, Vec256Pattern.Units<byte>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> vinc(in Vec256<short> src)
            =>  vadd(src, Vec256Pattern.Units<short>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vinc(in Vec256<ushort> src)
            =>  vadd(src, Vec256Pattern.Units<ushort>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vinc(in Vec256<int> src)
            =>  vadd(src, Vec256Pattern.Units<int>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vinc(in Vec256<uint> src)
            =>  vadd(src, Vec256Pattern.Units<uint>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vinc(in Vec256<long> src)
            =>  vadd(src, Vec256Pattern.Units<long>());

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vinc(in Vec256<ulong> src)
            =>  vadd(src, Vec256Pattern.Units<ulong>());


    }
}