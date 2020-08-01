//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct PartFileEvent : IWorkflowEvent<PartFileEvent>
    {
        const string Pattern = "{0}: {1} - {2}";
        
        public readonly string Label;

        public readonly string Content;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public static implicit operator PartFileEvent((string label, object content) src)
            => new PartFileEvent(src.label, src.content?.ToString() ?? string.Empty);

        [MethodImpl(Inline)]
        public PartFileEvent(string label, string content)
        {
            Label = label;
            Content = content;
            Timestamp = z.now();
        }

        public string Description
             => text.format(Pattern, Timestamp, Label,Content);
    
        public PartFileEvent Zero 
            => Empty;                

        public static PartFileEvent Empty 
            => default;
    }
}