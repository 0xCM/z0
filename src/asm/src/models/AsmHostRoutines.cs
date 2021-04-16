//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmHostRoutines : IIndex<AsmMemberRoutine>
    {
        public static ApiMembers members(Index<AsmHostRoutines> src)
        {
            if(src.Length == 0)
                return ApiMembers.Empty;
            var members = src.SelectMany(x => x.Storage).Select(x => x.Member).Sort();
            return new ApiMembers(members.First.BaseAddress,members);
        }

        readonly Index<AsmMemberRoutine> Data;

        [MethodImpl(Inline)]
        public AsmHostRoutines(AsmMemberRoutine[] src)
            => Data = src;

        public Index<AsmRoutine> AsmRoutines
        {
            [MethodImpl(Inline)]
            get => Data.Select(x => x.Routine);
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty ? Data.First.Member.Host : ApiHostUri.Empty;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref AsmMemberRoutine First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<AsmMemberRoutine> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<AsmMemberRoutine> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public AsmMemberRoutine[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmHostRoutines(AsmMemberRoutine[] src)
            => new AsmHostRoutines(src);

        public static AsmHostRoutines Empty
        {
            [MethodImpl(Inline)]
            get => new AsmHostRoutines(sys.empty<AsmMemberRoutine>());
        }
    }
}