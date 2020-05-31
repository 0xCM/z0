//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public readonly struct CpuEvent : IAppEvent<CpuEvent>
    {
        public static CpuEvent Empty => default;

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