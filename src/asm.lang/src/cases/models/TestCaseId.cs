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

    public readonly struct TestCaseId
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        public TestCaseId(ulong data)
        {
            Data = data;
        }

        [MethodImpl(Inline)]
        public ulong Segment(byte offset, byte length)
            => BitMasks.extract(Data, offset, length);

        [MethodImpl(Inline)]
        public T Segment<T>(byte offset, byte length)
            => @as<ulong,T>(BitMasks.extract(Data, offset, length));

        public ulong this[byte offset, byte length]
        {
            [MethodImpl(Inline)]
            get => Segment(offset,length);
        }

        public string Format()
            => Data.ToString();

        public string FormatHex(params byte[] partitions)
        {
            var count = partitions.Length;
            if(count != 0)
            {
                var dst = text.buffer();
                var parts = @readonly(partitions);
                var content = bytes(Data);
                var current = 0;
                for(var i=0; i<count; i++)
                {
                    var len = skip(parts,i);
                    var seg = slice(content, current, len);
                    dst.Append(string.Format("[{0}]", seg.FormatHex()));
                    dst.Append(Chars.Space);
                    current += len;
                }
                dst.Append(string.Format("[{0}]", slice(content,current).FormatHex()));
                return dst.Emit();
            }
            else
                return Data.FormatHex();
        }

        public static implicit operator TestCaseId(ulong src)
            => new TestCaseId(src);
    }

}