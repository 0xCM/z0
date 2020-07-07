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
    
    public readonly struct FixedTernaryOpClass : IFixedOpClassF<FixedTernaryOpClass,C>
    {
        public TypeWidth Width {get;}

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(FixedTernaryOpClass src)
            => new OperatorClass(src.Kind);

        public C Kind 
            => C.TernaryOp; 

        public OperatorClass Generalized 
            => default;

        [MethodImpl(Inline)]
        public FixedTernaryOpClass(TypeWidth width)
            => Width = width; 
    }

    public readonly struct FixedTernaryOpClass<W> : IFixedOpClassF<FixedTernaryOpClass<W>,W,C> 
        where W : unmanaged, ITypeWidth
    { 
        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<W>(FixedTernaryOpClass<W> src)
            => default;
        
        [MethodImpl(Inline)]
        public static implicit operator K.TernaryOpClass(FixedTernaryOpClass<W> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator FixedTernaryOpClass(FixedTernaryOpClass<W> src)
            => src.NonGeneric;

        public C Kind 
            => C.TernaryOp; 

        public TypeWidth Width 
            => Widths.type<W>();

        public OperatorClass<W> Generalized 
            => default;

        public FixedTernaryOpClass NonGeneric 
            => new FixedTernaryOpClass(Width);
    }
}