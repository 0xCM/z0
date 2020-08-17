//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;
    
    public readonly struct WfStepArg : ITextual
    {
        public readonly string Name;

        public readonly string Value;        
        
        [MethodImpl(Inline)]
        public static implicit operator WfStepArg((string name, string value) src)
            => new WfStepArg(src.name, src.value);
        
        [MethodImpl(Inline)]
        public WfStepArg(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Value;
    }
}