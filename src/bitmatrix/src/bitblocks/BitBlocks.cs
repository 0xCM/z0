//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public static partial class XBitBlocks
    {

    }

    [ApiHost]
    public partial class BitBlocks
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Reads a cell determined by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        internal static ref readonly X readcell<X>(in X src, int bitpos)
            where X : unmanaged
                => ref skip(in src, bitpos / bitwidth<X>());

        [MethodImpl(Inline)]
        internal static bit readbit<X>(in X src, int bitpos)
            where X : unmanaged
                => gbits.testbit(readcell(in src, bitpos), (byte)(bitpos % bitwidth<X>()));

        /// <summary>
        /// Reads/manipulates a cell identified by a linear bit position
        /// </summary>
        /// <param name="bitpos">The linear bit position</param>
        /// <param name="src">A reference to grid storage</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static ref X cell<X>(ref X src, uint bitpos)
            where X : unmanaged
                => ref seek(src, bitpos / bitwidth<X>());

        /// <summary>
        /// Transfers span content to a bitblock without checks
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The bitblock length representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> transfer<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src,true);


   }
}