//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public sealed class ModelServices : AppService<ModelServices>
    {
        List<NativeBuffer> Allocations;

        public ModelServices()
        {
            Allocations = new();
        }

        protected override void Disposing()
        {
            iter(Allocations, a => a.Dispose());
        }

        public LabelStore Labels(ByteSize size)
        {
            var buffer = memory.native(size);
            var store = new LabelStore(buffer.Address, buffer.Size);
            Allocations.Add(buffer);
            return store;
        }

        public LabelStore Labels(ReadOnlySpan<char> src)
            => new LabelStore(address(src), src.Length*2);
    }
}