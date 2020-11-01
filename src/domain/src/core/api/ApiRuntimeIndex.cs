//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    public sealed class ApiRuntimeIndex : ApiIndex<ApiRuntimeIndex>
    {
        public const uint MaxEntryCount = ushort.MaxValue;

        public static ApiRuntimeIndex create(uint? count = null)
            => new ApiRuntimeIndex(count ?? MaxEntryCount);

        ApiRuntimeMember[] EntryData;

        ApiRuntimeIndex(uint count)
        {
            EntryData = alloc<ApiRuntimeMember>(count);
        }

        public Span<ApiRuntimeMember> Entries
        {
            [MethodImpl(Inline)]
            get => EntryData;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => (uint)EntryData.Length;
        }

        public ref ApiRuntimeMember LeadingEntry
        {
            [MethodImpl(Inline)]
            get => ref z.first(EntryData);
        }


        public ref ApiRuntimeMember this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(LeadingEntry, index);
        }
    }
}