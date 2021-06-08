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

    [ApiHost]
    public readonly struct AsmRegQuery
    {
        readonly Symbols<RegKind> Symbols;

        readonly Index<Register> Cache;

        public uint RegCount
        {
            [MethodImpl(Inline)]
            get => Symbols.Count;
        }

        internal AsmRegQuery(Symbols<RegKind> src)
        {
            Symbols = src;
            Cache = alloc<Register>(src.Count);
        }

        public ReadOnlySpan<Register> Source
        {
            [MethodImpl(Inline)]
            get => recover<RegKind,Register>(Symbols.Kinds);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Register> Where(RegClass @class)
        {
            var target = Cache.Edit;
            var count = api.filter(@class, Source, target);
            return slice(target, 0, count);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Register> Where(RegWidth width)
        {
            var target = Cache.Edit;
            var count = api.filter(width, Source, target);
            return slice(target, 0, count);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Register> Where(RegClass @class, RegWidth width)
        {
            var target = Cache.Edit;
            var count = api.filter(@class, width, Source, target);
            return slice(target, 0, count);
        }
    }
}