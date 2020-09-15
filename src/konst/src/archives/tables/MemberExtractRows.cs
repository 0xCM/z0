//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemberExtractRows
    {
        readonly MemberExtractRow[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MemberExtractRow[](MemberExtractRows src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator MemberExtractRows(MemberExtractRow[] src)
            => new MemberExtractRows(src);

        [MethodImpl(Inline)]
        public MemberExtractRows(MemberExtractRow[] data)
            => Data = data;

        public int Length
            => Data.Length;

        public ref readonly MemberExtractRow this[int index]
        {
            [MethodImpl(Inline)]
            get =>  ref Data[index];
        }
    }
}