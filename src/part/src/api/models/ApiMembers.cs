//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines and index over <see cref='ApiMember'/> values
    /// </summary>
    public readonly struct ApiMembers : IIndex<ApiMember>
    {
        readonly Index<ApiMember> Data;

        public MemoryAddress BaseAddress {get;}

        [MethodImpl(Inline)]
        public ApiMembers(ApiMember[] src)
        {
            Data = src;
            BaseAddress = default;
        }

        [MethodImpl(Inline)]
        public ApiMembers(MemoryAddress @base, ApiMember[] src)
        {
            Data = src;
            BaseAddress = @base;
        }

        public bool IsBased
        {
            get => BaseAddress != 0;
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

        public ApiMembers Sort()
        {
            Data.Sort();
            return this;
        }

        public ApiMembers Where(Func<ApiMember,bool> predicate)
            => Data.Storage.Where(predicate);

        [MethodImpl(Inline)]
        public static implicit operator ApiMembers(ApiMember[] src)
            => new ApiMembers(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiMembers((MemoryAddress @base, ApiMember[] members) src)
            => new ApiMembers(src.@base, src.members);

        [MethodImpl(Inline)]
        public static implicit operator ApiMember[](ApiMembers src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Index<ApiMember>(ApiMembers src)
            => src.Data;

        public static ApiMembers Empty
            => new ApiMembers(Index<ApiMember>.Empty);
    }
}