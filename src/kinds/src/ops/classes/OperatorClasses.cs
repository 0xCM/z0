//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using K = OperatorClass;

    partial class OpClass
    {
        public readonly struct OperatorClass : IOpClassF<OperatorClass,K> 
        {
            public K Class => K.Operator; 
        } 

        public readonly struct UnaryOp : IOpClassF<UnaryOp,K> 
        {
            public K Class => K.UnaryOp; 

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct BinaryOp : IOpClassF<BinaryOp,K> 
        {
            public K Class => K.BinaryOp; 

            public static implicit operator OperatorClass(BinaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct TernaryOp : IOpClassF<TernaryOp,K> 
        {
            public K Class => K.TernaryOp; 

            public static implicit operator OperatorClass(TernaryOp src)
                => default;

            public OperatorClass Generalized => default;
        }

        public readonly struct OperatorClass<T> : IOpClass<K,T> 
            where T : unmanaged 
        { 
            public K Class => K.Operator; 
        }

        public readonly struct UnaryOp<T> : IOpClassF<UnaryOp<T>, K,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(UnaryOp<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(UnaryOp<T> src)
                => default;
                        
            public K Class => K.UnaryOp; 

            public OperatorClass<T> Generalized => default;

            public UnaryOp NonGeneric => default;
        }

        public readonly struct BinaryOp<T> : IOpClassF<BinaryOp<T>,K,T> 
            where T : unmanaged 
        { 
            public static implicit operator OperatorClass<T>(BinaryOp<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(BinaryOp<T> src)
                => default;
                        
            public K Class => K.BinaryOp; 

            public OperatorClass<T> Generalized => default;

            public BinaryOp NonGeneric => default;            
        }

        public readonly struct TernaryOp<T> : IOpClassF<TernaryOp<T>,K,T> 
            where T : unmanaged 
        {
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<T>(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp(TernaryOp<T> src)
                => default;

            public K Class => K.TernaryOp; 

            public OperatorClass<T> Generalized => default;

            public TernaryOp NonGeneric => default;
        }


        public readonly struct FixedUnaryOp : IFixedOpClassF<FixedUnaryOp,K>
        {
            public K Class => K.UnaryOp; 

            public TypeWidth Width {get;}
                        
            public OperatorClass Generalized => default;

            [MethodImpl(Inline)]
            public FixedUnaryOp(TypeWidth width)
            {
                this.Width = width;
            }

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedUnaryOp src)
                => default;
        }

        public readonly struct FixedUnaryOp<W> : IFixedOpClassF<FixedUnaryOp<W>,W,K> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedUnaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(FixedUnaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedUnaryOp(FixedUnaryOp<W> src)
                => src.NonGeneric;

            public K Class => K.UnaryOp; 

            public TypeWidth Width => Widths.type<W>();

            public OperatorClass<W> Generalized => default;

            public FixedUnaryOp NonGeneric => new FixedUnaryOp(Width);
        }

        public readonly struct FixedBinaryOp : IFixedOpClassF<FixedBinaryOp,K>
        {
            public K Class => K.BinaryOp; 

            public TypeWidth Width {get;}
                        
            public OperatorClass Generalized => default;

            [MethodImpl(Inline)]
            public FixedBinaryOp(TypeWidth width)
            {
                this.Width = width;
            }

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedBinaryOp src)
                => default;
        }

        public readonly struct FixedBinaryOp<W> : IFixedOpClassF<FixedBinaryOp<W>,W,K> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedBinaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(FixedBinaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedBinaryOp(FixedBinaryOp<W> src)
                => src.NonGeneric;

            public K Class => K.BinaryOp; 

            public TypeWidth Width => Widths.type<W>();

            public OperatorClass<W> Generalized => default;

            public FixedBinaryOp NonGeneric => new FixedBinaryOp(Width);
        }

        public readonly struct FixedTernaryOp : IFixedOpClassF<FixedTernaryOp,K>
        {
            public K Class => K.TernaryOp; 

            public TypeWidth Width {get;}
                        
            public OperatorClass Generalized => default;

            [MethodImpl(Inline)]
            public FixedTernaryOp(TypeWidth width)
            {
                this.Width = width;
            }

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(FixedTernaryOp src)
                => default;
        }

        public readonly struct FixedTernaryOp<W> : IFixedOpClassF<FixedTernaryOp<W>,W,K> 
            where W : unmanaged, ITypeWidth
        { 
            [MethodImpl(Inline)]
            public static implicit operator OperatorClass<W>(FixedTernaryOp<W> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator TernaryOp(FixedTernaryOp<W> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FixedTernaryOp(FixedTernaryOp<W> src)
                => src.NonGeneric;

            public K Class => K.TernaryOp; 

            public TypeWidth Width => Widths.type<W>();

            public OperatorClass<W> Generalized => default;

            public FixedTernaryOp NonGeneric => new FixedTernaryOp(Width);
        }
   }
}