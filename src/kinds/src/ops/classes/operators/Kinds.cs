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


    partial class Kinds
    {
        public readonly struct OperatorClass : IOperatorClass<OperatorClass,K> 
        {
            public K Class {get;}

            [MethodImpl(Inline)]
            public OperatorClass(K k)
            {
                this.Class = k;
            }

            public OperatorClass Generalized => new OperatorClass(Class);
        } 

        public readonly struct EmitterOpClass : IOperatorClass<EmitterOpClass,K> 
        {
            public K Class => K.Emitter; 

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(EmitterOpClass src)
                => src.Generalized;

            public OperatorClass Generalized => new OperatorClass(Class);
        }

        public readonly struct UnaryOpClass : IOperatorClass<UnaryOpClass,K> 
        {
            public K Class => K.UnaryOp; 

            [MethodImpl(Inline)]
            public static implicit operator OperatorClass(UnaryOpClass src)
                => src.Generalized;

            public OperatorClass Generalized => new OperatorClass(Class);
        }

        public readonly struct BinaryOpClass : IOperatorClass<BinaryOpClass,K> 
        {
            public K Class => K.BinaryOp; 

            public static implicit operator OperatorClass(BinaryOpClass src)
                => src.Generalized;

            public OperatorClass Generalized => new OperatorClass(Class);
        }

        public readonly struct TernaryOpClass : IOperatorClass<TernaryOpClass,K> 
        {
            public K Class => K.TernaryOp; 

            public static implicit operator OperatorClass(TernaryOpClass src)
                => src.Generalized;

            public OperatorClass Generalized => new OperatorClass(Class);
        }

        public readonly struct ShiftOpClass : IOperatorClass<ShiftOpClass,K> 
        {
            public K Class => K.ShiftOp; 

            public static implicit operator OperatorClass(ShiftOpClass src)
                => src.Generalized;

            public OperatorClass Generalized => new OperatorClass(Class);
        }
    }
}