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
    
    partial class Kinds
    {
        public readonly struct FixedUnaryOp : IFixedOpClassF<FixedUnaryOp,C>
        {
            public TypeWidth Width {get;}

            public C Kind 
                => C.UnaryOp; 
                        
            public OperatorClass Generalized 
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedUnaryOp src)
                => default;

            [MethodImpl(Inline)]
            public FixedUnaryOp(TypeWidth width)
                => Width = width;
        }

        public readonly struct FixedUnaryOp<W> : IFixedOpClassF<FixedUnaryOp<W>,W,C> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedUnaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator K.UnaryOpClass(FixedUnaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedUnaryOp(FixedUnaryOp<W> src)
                => src.NonGeneric;

            public C Kind 
                => C.UnaryOp; 

            public TypeWidth Width 
                => Widths.type<W>();

            public OperatorClass<W> Generalized 
                => default;

            public FixedUnaryOp NonGeneric 
                => new FixedUnaryOp(Width);
        }

        public readonly struct FixedBinaryOp : IFixedOpClassF<FixedBinaryOp,C>
        {
            public TypeWidth Width {get;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedBinaryOp src)
                => src.Generalized;

            public C Kind 
                => C.BinaryOp; 

            public OperatorClass Generalized 
            {
                [MethodImpl(Inline)]
                get => new OperatorClass(Kind);
            }


            [MethodImpl(Inline)]
            public FixedBinaryOp(TypeWidth width)
            {
                Width = width;
            }
        }

        public readonly struct FixedBinaryOp<W> : IFixedOpClassF<FixedBinaryOp<W>,W,C> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedBinaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator K.BinaryOpClass(FixedBinaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedBinaryOp(FixedBinaryOp<W> src)
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

            public FixedBinaryOp NonGeneric 
            {            
                [MethodImpl(Inline)]
                get => new FixedBinaryOp(Width);
            }
        }

        public readonly struct FixedTernaryOp : IFixedOpClassF<FixedTernaryOp,C>
        {
            public TypeWidth Width {get;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedTernaryOp src)
                => new OperatorClass(src.Kind);

            public C Kind 
                => C.TernaryOp; 

            public OperatorClass Generalized 
                => default;

            [MethodImpl(Inline)]
            public FixedTernaryOp(TypeWidth width)
                => Width = width; 
        }

        public readonly struct FixedTernaryOp<W> : IFixedOpClassF<FixedTernaryOp<W>,W,C> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedTernaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator K.TernaryOpClass(FixedTernaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedTernaryOp(FixedTernaryOp<W> src)
                => src.NonGeneric;

            public C Kind 
                => C.TernaryOp; 

            public TypeWidth Width 
                => Widths.type<W>();

            public OperatorClass<W> Generalized => default;

            public FixedTernaryOp NonGeneric => new FixedTernaryOp(Width);
        }
    }
}