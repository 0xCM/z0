//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.XedWf
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using E = Z0.XedWf;

    [ApiHost]
    public readonly struct XedEvents
    {
        [MethodImpl(Inline), Op]
        public static E.ParsingInstructions ParsingInstructions(FilePath src, CorrelationToken? ct = null)
            => new E.ParsingInstructions(id(nameof(E.ParsingInstructions), ct), src);

        [MethodImpl(Inline), Op]
        public static E.ParsedInstructions ParsedInstructions(FilePath src, int count, in WfEventId running)
            => new E.ParsedInstructions(id(nameof(E.ParsingInstructions), running.Ct), src, (uint)count);

        [MethodImpl(Inline), Op]
        public static WfEventId id(string name, CorrelationToken? ct = null)
            => WfEventId.define(name, correlate(ct), timestamp());

        public static WfEventId id<T>(CorrelationToken? ct = null)
            => WfEventId.define(typeof(T).Name, correlate(ct), timestamp());
    }
}