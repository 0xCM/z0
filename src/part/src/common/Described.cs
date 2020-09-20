//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Described : IDescribed<Described>
    {
        public string Label {get;}

        public static Described Attributed 
        {
            [MethodImpl(Inline)]
            get => new Described(DescriptionAttribute.TargetDescription<Described>());
        }
        
        [MethodImpl(Inline)]
        public static Described From(string src)
            => new Described(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Described src)
            => src.Label;

        [MethodImpl(Inline)]
        public static implicit operator Described(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Described(string label)
        {
            Label = label;
        }    
    }    
}