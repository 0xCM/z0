//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Defines and index over <see cref='ApiMember'/> values
    /// </summary>
    public readonly struct ApiMembers : IIndex<ApiMember>
    {
        public static ApiMembers create(Index<ApiMember> src)
        {
            if(src.Length != 0)
            {
                Array.Sort(src.Storage);
                return new ApiMembers(src.First.BaseAddress, src);
            }
            else
                return Empty;
        }

        readonly Index<ApiMember> Data;

        public MemoryAddress BaseAddress {get;}

        [MethodImpl(Inline)]
        ApiMembers(MemoryAddress @base, Index<ApiMember> src)
        {
            Data = src;
            BaseAddress = @base;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<ApiMember> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ApiMember[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref ApiMember this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref ApiMember this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public Index<ApiHostMembers> HostGroups()
        {
            var dst = root.list<ApiHostMembers>();
            var groups = Storage.GroupBy(x => x.Host);
            foreach(var g in groups)
            {
                var host = g.Key;
                var members = g.ToArray();
                dst.Add(new ApiHostMembers(host, create(members)));
            }
            return dst.ToArray();
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiMember[](ApiMembers src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Index<ApiMember>(ApiMembers src)
            => src.Data;

        public static ApiMembers Empty
            => new ApiMembers(MemoryAddress.Zero, Index<ApiMember>.Empty);
    }
}