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

    public struct ToolHelp
    {
        Index<dynamic> Data {get;}

        public ToolHelp(uint count)
        {
            Data = alloc<dynamic>(count);
        }

        public ref dynamic this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<dynamic> View
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
    }
}