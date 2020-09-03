//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using C = OperatorClassKind;

    public readonly struct FixedBinaryOpClass : IFixedOpClassF<FixedBinaryOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(FixedBinaryOpClass src)
            => src.Generalized;

        public C Kind 
            => C.BinaryOp; 

        public OperatorClass Generalized 
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }


        [MethodImpl(Inline)]
        public FixedBinaryOpClass(TypeWidth width)
        {
            Width = width;
        }
    }

    public readonly struct FixedBinaryOpClass<W> : IFixedOpClassF<FixedBinaryOpClass<W>,W,C> 
        where W : unmanaged, ITypeWidth
    { 
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(FixedBinaryOpClass<W> src)
            => default;
        
        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(FixedBinaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator FixedBinaryOpClass(FixedBinaryOpClass<W> src)
            => src.NonGeneric;

        public C Kind 
            => C.BinaryOp; 

        public TypeWidth Width 
            => Widths.type<W>();

        public OperatorClass<W> Generalized
        { 
            [MethodImpl(Inline)]
            get => new OperatorClass<W>(Kind);
        }

        public FixedBinaryOpClass NonGeneric 
        {            
            [MethodImpl(Inline)]
            get => new FixedBinaryOpClass(Width);
        }
    }
}