//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;
    
    public readonly struct imm<T> : IImmOp<T>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public imm(T value)
        {
            Value = value;
        }

        public DataWidth Width 
        {
            [MethodImpl(Inline)]
            get => (DataWidth)bitsize<T>();
        }
    }

    public readonly struct imm<E,T> : IImmOp<@enum<E,T>>        
        where T : unmanaged
        where E : unmanaged, Enum
    {
        public @enum<E,T> Value {get;}

        [MethodImpl(Inline)]
        public imm(@enum<E,T> value)
        {
            Value = value;
        }

        public DataWidth Width 
        {
            [MethodImpl(Inline)]
            get => Value.Width;
        }
    }    
}