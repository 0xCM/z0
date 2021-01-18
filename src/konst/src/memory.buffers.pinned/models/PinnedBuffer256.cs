//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// A buffer that contains 256 <typeparamref name='T'/> cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public sealed class PinnedBuffer256<T> : PinnedBuffer<PinnedBuffer256<T>,T>
    {
        public override uint CellCount
             => 256;

        protected override void Fill(Span<T> dst)
        {
            for(var i=0u; i<256; i++)
                seek(dst,i) = @as<uint,T>(i);
        }

        public override void Deposit(T[] src)
            => throw no();
    }
}