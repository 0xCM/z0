//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Labeled : ILabeled<Labeled>
    {
        public string Label {get;}

        public static Labeled Attributed 
        {
            [MethodImpl(Inline)]
            get => new Labeled(LabelAttribute.TargetLabel<Labeled>());
        }
        
        [MethodImpl(Inline)]
        public static Labeled From(string src)
            => new Labeled(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Labeled src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Labeled(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Labeled(string label)
        {
            Label = label;
        }    
    }
}