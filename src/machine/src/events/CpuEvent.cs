//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CpuEvent : IAppEvent<CpuEvent>
    {
        public static CpuEvent Empty => default;

        [MethodImpl(Inline)]
        public static CpuEvent Create(string label, object content)
            => new CpuEvent(label, content.ToString());

        [MethodImpl(Inline)]
        public static implicit operator CpuEvent((string label, object content) src)
            => new CpuEvent(src.label, src.content?.ToString() ?? string.Empty);

        [MethodImpl(Inline)]
        public CpuEvent(string label, string content)
        {
            Label = label;
            Content = content;
        }

        public string Label {get;}

        public string Content {get;}

        public string Description
             => $"{Label}: {Content}";
    
        public CpuEvent Zero 
            => Empty;                
    }
}