//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
     using System;
     using System.Runtime.CompilerServices;

    [ApiHost("api")]
    public partial class BitMatrix
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }

    [ApiHost("logix")]
    public partial class SquareBitLogix
    {

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
        IBitMatrixWriter Writer(FilePath dst) => new BitMatrixWriter(dst);
    }

    public readonly struct BitMatrixServices : IBitMatrixServices
    {
        public static IBitMatrixServices Factory => default(BitMatrixServices);

    }

    public static partial class XTend
    {

    }
}