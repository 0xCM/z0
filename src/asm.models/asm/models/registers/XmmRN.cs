//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    public readonly struct Xmm<R,N> : IXmmOperand<Xmm<R,N>, N>
        where R : unmanaged, IXmmOperand
        where N : unmanaged, ITypeNat                      
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public Xmm(Fixed128 value)
        {
            Content = value;
        }
        
        public RegisterCode Code 
        {
            [MethodImpl(Inline)]
            get => (RegisterCode)value<N>();
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => RegisterBits.join(Code, RegisterClass.XMM, RegisterWidth.W128);
        }
    }
}