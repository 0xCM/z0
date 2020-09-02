//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct CapturingPart : IWfEvent<CapturingPart>
    {
        public WfEventId EventId  => WfEventId.define("Placeholder");

        public readonly PartId Part;

        [MethodImpl(Inline)]
        public CapturingPart(PartId part)
            => Part = part;

        public string Format()
            => $"{Part.Format()} part capture step starting";

        public static CapturingPart Empty
            => default;
    }
}