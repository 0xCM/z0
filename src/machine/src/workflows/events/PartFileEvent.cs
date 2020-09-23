//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;

    [Event]
    public readonly struct PartFileEvent : IWfEvent<PartFileEvent>
    {
        const string Pattern = Slot0 + FieldSep + "{1} | {2}";

        public WfEventId EventId {get;}

        public readonly string Label;

        public readonly string Content;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public static implicit operator PartFileEvent((string label, object content) src)
            => new PartFileEvent(src.label, src.content?.ToString() ?? EmptyString);

        [MethodImpl(Inline)]
        public PartFileEvent(string label, string content)
        {
            EventId = WfEventId.define(nameof(PartFileEvent));
            Label = label;
            Content = content;
            Timestamp = z.now();
        }

        public string Format()
             => text.format(Pattern, Timestamp, Label,Content);

        public PartFileEvent Zero
            => Empty;

        public static PartFileEvent Empty
            => default;
    }
}