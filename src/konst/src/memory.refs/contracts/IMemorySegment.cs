//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes a segment reference
    /// </summary>
    public interface IMemorySegment : INullity, ITextual, IHashed
    {
        MemoryAddress BaseAddress {get;}

        // unsafe ReadOnlySpan<byte> View
        //     => memory.cover<byte>(BaseAddress.Pointer<byte>(), DataSize);

        uint DataSize  {get;}

        bool INullity.IsEmpty
            => DataSize == 0;

        uint CellCount
            => DataSize * CellSize;

        uint CellSize
            => 1;

        ref byte Cell(int index);

        ref byte this[int index]
            => ref Cell(index);
    }
}