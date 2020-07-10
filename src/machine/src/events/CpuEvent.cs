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
        public string Label {get;}

        public string Content {get;}        
        
        [MethodImpl(Inline)]
        public static implicit operator CpuEvent((string label, object content) src)
            => new CpuEvent(src.label, src.content?.ToString() ?? string.Empty);

        [MethodImpl(Inline)]
        public CpuEvent(string label, string content)
        {
            Label = label;
            Content = content;
        }

        public string Description
             => $"{Label}: {Content}";
    
        public CpuEvent Zero 
            => Empty;                

        public static CpuEvent Empty 
            => default;
    }
}