//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    using Q = Z0;

    partial struct BitNumbers
    {
        public struct FormatCheck<W,T> : IRecord<FormatCheck<W,T>>
            where W : unmanaged, IDataWidth
            where T : unmanaged, IBitNumber
        {
            public uint Sequence;

            public byte Input;

            public T Number;

            public string Formatted;

            public byte LengthExpect;

            public byte LengthActual;

            public bool LenthMatch;

            public TableId TableId
                => new TableId(typeof(FormatCheck<W,T>), string.Format("uint{0}.format-check",default(T).Width));
        }

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell16'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell16 src, uint1 part)
            => ref seek(@as<Cell16,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell32'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell32 src, uint2 part)
            => ref seek(@as<Cell32,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell64'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell64 src, uint3 part)
            => ref seek(@as<Cell64,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell128'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell128 src, uint4 part)
            => ref seek(@as<Cell128,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell256 src, uint5 part)
            => ref seek(@as<Cell256,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell8 cell8(in Cell512 src, uint6 part)
            => ref seek(@as<Cell512,Cell8>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell64'/> value from a specified <see cref='Cell128'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell64 cell64(in Cell128 src, uint1 part)
            => ref seek(@as<Cell128,Cell64>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell64'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell64 cell64(in Cell256 src, uint2 part)
            => ref seek(@as<Cell256,Cell64>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell64'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell64 cell64(in Cell512 src, uint3 part)
            => ref seek(@as<Cell512,Cell64>(src), part);

         /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell64'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell64 src, uint1 part)
            => ref seek(@as<Cell64,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell128'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell128 src, uint2 part)
            => ref seek(@as<Cell128,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell256 src, uint3 part)
            => ref seek(@as<Cell256,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell32'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell32 cell32(in Cell512 src, uint4 part)
            => ref seek(@as<Cell512,Cell32>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell128'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell128 cell128(in Cell256 src, uint1 part)
            => ref seek(@as<Cell256,Cell128>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell128'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell128 cell128(in Cell512 src, uint2 part)
            => ref seek(@as<Cell512,Cell128>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell8'/> value from a specified <see cref='Cell32'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell16 cell16(in Cell32 src, uint1 part)
            => ref seek(@as<Cell32,Cell16>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell16'/> value from a specified <see cref='Cell64'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell16 cell16(in Cell64 src, uint2 part)
            => ref seek(@as<Cell64,Cell16>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell16'/> value from a specified <see cref='Cell128'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell16 cell16(in Cell128 src, uint3 part)
            => ref seek(@as<Cell128,Cell16>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell16'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell16 cell16(in Cell256 src, uint4 part)
            => ref seek(@as<Cell256,Cell16>(src), part);

        /// <summary>
        /// Seeks an index-identified <see cref='Cell16'/> value from a specified <see cref='Cell256'/> source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="part">The identifying index</param>
        [MethodImpl(Inline), Op]
        public static ref Cell16 cell16(in Cell512 src, uint5 part)
            => ref seek(@as<Cell512,Cell16>(src), part);
        [MethodImpl(Inline)]
        static S cast<S>(byte src)
            where S : unmanaged, IBitNumber<S>
                => @as<byte,S>(src);

        [MethodImpl(Inline)]
        static S cast<S>(Limits24u src)
            where S : unmanaged, IBitNumber<S>
                => @as<Limits24u,S>(src);

        [MethodImpl(Inline)]
        static S maxval<S>()
            where S : unmanaged, IBitNumber<S>
        {
            if(typeof(S) == typeof(uint1))
                return cast<S>(Q.uint1.MaxLiteral);
            else if(typeof(S) == typeof(uint2))
                return cast<S>(Q.uint2.MaxLiteral);
            else if(typeof(S) == typeof(uint3))
                return cast<S>(Q.uint3.MaxLiteral);
            else if(typeof(S) == typeof(uint4))
                return cast<S>(Q.uint4.MaxLiteral);
            else
                return maxval<S>(w5);
        }

        [MethodImpl(Inline)]
        static S maxval<S>(W5 w5)
            where S : unmanaged, IBitNumber<S>
        {
            if(typeof(S) == typeof(uint5))
                return cast<S>(Q.uint5.MaxLiteral);
            else if(typeof(S) == typeof(uint6))
                return cast<S>(Q.uint6.MaxLiteral);
            else if(typeof(S) == typeof(uint7))
                return cast<S>(Q.uint7.MaxLiteral);
            else if(typeof(S) == typeof(uint8T))
                return cast<S>(Q.uint8T.MaxLiteral);
            else
                return maxval<S>(w16);
        }

        [MethodImpl(Inline)]
        static S maxval<S>(W16 w)
            where S : unmanaged, IBitNumber<S>
        {
            if(typeof(S) == typeof(uint24))
                return cast<S>(Q.uint24.MaxVal);
            else
                throw no<S>();
        }
    }
}