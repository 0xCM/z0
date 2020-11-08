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

    /// <summary>
    /// A buffer that contains 256 <typeparamref name='T'/> cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public sealed class FixedBuffer256<T> : FixedBuffer<FixedBuffer256<T>,T>
    {
        public override uint CellCount
             => 256;

        [Op]
        protected override void Populate(Span<T> dst)
        {
            for(var i=0u; i<256; i++)
                seek(dst,i) = z.@as<uint,T>(i);
        }
    }
}