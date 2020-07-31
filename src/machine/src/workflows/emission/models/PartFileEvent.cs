//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct PartFileEvent : IAppEvent<PartFileEvent>
    {
        public string Label {get;}

        public string Content {get;}        
        
        [MethodImpl(Inline)]
        public static implicit operator PartFileEvent((string label, object content) src)
            => new PartFileEvent(src.label, src.content?.ToString() ?? string.Empty);

        [MethodImpl(Inline)]
        public PartFileEvent(string label, string content)
        {
            Label = label;
            Content = content;
        }

        public string Description
             => $"{Label}: {Content}";
    
        public PartFileEvent Zero 
            => Empty;                

        public static PartFileEvent Empty 
            => default;
    }
}