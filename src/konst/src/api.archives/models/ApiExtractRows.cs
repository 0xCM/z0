//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiExtractRows
    {
        readonly ApiExtractRow[] Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiExtractRow[](ApiExtractRows src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiExtractRows(ApiExtractRow[] src)
            => new ApiExtractRows(src);

        [MethodImpl(Inline)]
        public ApiExtractRows(ApiExtractRow[] data)
            => Data = data;

        public int Length
            => Data.Length;

        public ref readonly ApiExtractRow this[int index]
        {
            [MethodImpl(Inline)]
            get =>  ref Data[index];
        }
    }
}