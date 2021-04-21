//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Images
    {
        [Record(TableId)]
        public struct UserString : IRecord<UserString>
        {
            public const string TableId = "image.strings.user";

            public Count Sequence;

            public bool IsSystemString;

            public ByteSize HeapSize;

            public Count Length;

            public Address32 Offset;

            public string Content;

            [MethodImpl(Inline)]
            public UserString(Count seq, ByteSize heap, Address32 offset, string data)
            {
                Sequence = seq;
                IsSystemString = false;
                HeapSize = heap;
                Length = data.Length;
                Offset = offset;
                Content = data;
            }
        }
    }
}