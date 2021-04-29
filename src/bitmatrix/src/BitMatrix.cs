//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public partial class BitMatrix
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }


    /// <summary>
    /// Defines primary api surface for rowbit manipulation
    /// </summary>
    [ApiHost]
    public partial class RowBits
    {

    }


    public interface IBitMatrixServices
    {
        IBitMatrixWriter Writer(FS.FilePath dst)
            => new BitMatrixWriter(dst);
    }

    public readonly struct BitMatrixServices : IBitMatrixServices
    {
        public static IBitMatrixServices Factory => default(BitMatrixServices);

    }

    public static partial class XTend
    {
        static string format<N,T>(BitBlock<N,T> src, BitFormat? config = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(config);

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitBlock<N,T> src, BitFormat? config = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => format(src,config);
    }
}