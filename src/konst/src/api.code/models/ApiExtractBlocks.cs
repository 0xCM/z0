//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiExtractBlocks
    {
        readonly ApiExtractBlock[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiExtractBlock[](ApiExtractBlocks src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiExtractBlocks(ApiExtractBlock[] src)
            => new ApiExtractBlocks(src);

        [MethodImpl(Inline)]
        public ApiExtractBlocks(ApiExtractBlock[] data)
            => Data = data;

        public int Length
            => Data.Length;

        public ref readonly ApiExtractBlock this[int index]
        {
            [MethodImpl(Inline)]
            get =>  ref Data[index];
        }
    }
}