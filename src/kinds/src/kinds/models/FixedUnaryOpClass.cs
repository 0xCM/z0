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
    using K = Kinds;

    public readonly struct FixedUnaryOpClass : IFixedOpClassF<FixedUnaryOpClass,C>
    {
        public TypeWidth Width {get;}

        public C Kind 
            => C.UnaryOp; 
                    
        public OperatorClass Generalized 
            => default;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(FixedUnaryOpClass src)
            => default;

        [MethodImpl(Inline)]
        public FixedUnaryOpClass(TypeWidth width)
            => Width = width;
    }

    public readonly struct FixedUnaryOpClass<W> : IFixedOpClassF<FixedUnaryOpClass<W>,W,C> 
        where W : unmanaged, ITypeWidth
    { 
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(FixedUnaryOpClass<W> src)
            => default;
        
        [MethodImpl(Inline)]
        public static implicit operator K.UnaryOpClass(FixedUnaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator FixedUnaryOpClass(FixedUnaryOpClass<W> src)
            => src.NonGeneric;

        public C Kind 
            => C.UnaryOp; 

        public TypeWidth Width 
            => Widths.type<W>();

        public OperatorClass<W> Generalized 
            => default;

        public FixedUnaryOpClass NonGeneric 
            => new FixedUnaryOpClass(Width);
    }
}