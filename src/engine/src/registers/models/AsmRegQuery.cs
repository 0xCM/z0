//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = AsmRegs;

    public readonly struct AsmRegQuery
    {
        readonly Index<Register> Source;

        readonly Index<Register> Cache;

        readonly uint Count;

        [MethodImpl(Inline)]
        internal AsmRegQuery(Index<Register> src)
        {
            Source = src;
            Count = src.Count;
            Cache = alloc<Register>(src.Count);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<Register> Where(RegClass criteria)
        {
            var target = Cache.Edit;
            var count = api.filter(criteria, Source, target);
            return slice(target, 0, count);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<Register> Where(RegWidth criteria)
        {
            var target = Cache.Edit;
            var count = api.filter(criteria, Source, target);
            return slice(target, 0, count);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<Register> Where(RegClass @class, RegWidth width)
        {
            var target = Cache.Edit;
            var count = api.filter(@class, width, Source, target);
            return slice(target, 0, count);
        }
    }
}