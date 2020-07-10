//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Named : INamed<Named>
    {
        public string Label {get;}

        public static Named Attributed 
        {
            [MethodImpl(Inline)]
            get => new Named(LabelAttribute.TargetLabel<Named>());
        }
        
        [MethodImpl(Inline)]
        public static Named From(string src)
            => new Named(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Named src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Named(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Named(string label)
        {
            Label = label;
        }    
    }    
}