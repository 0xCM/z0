//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static TernaryLogic;

    public static class LogicTypes
    {

        public interface ILogicType 
        {

        }

        public interface ILogicType<K> : ILogicType
            where K : Enum
        {
            K Operator {get;}
        }

        public interface INullaryLogic : ILogicType<NullaryLogic>
        {

        }

        public interface IUnaryLogic : ILogicType<UnaryLogic>
        {
            
        }

        public interface IBinaryLogic : ILogicType<BinaryLogic>
        {

        }

        public interface ITernaryLogic : ILogicType<TernaryLogic>
        {

        }
        

        public readonly struct False : INullaryLogic
        {
            public NullaryLogic Operator
                => NullaryLogic.False;
        }

        public readonly struct True  : INullaryLogic
        {
            public NullaryLogic Operator
                => NullaryLogic.True;
        }

        public readonly struct Not : IUnaryLogic
        {
            public UnaryLogic Operator
                => UnaryLogic.Not;
        }

        public readonly struct Identity : IUnaryLogic
        {
            public UnaryLogic Operator
                => UnaryLogic.Identity;
        }
        

        public readonly struct And : IBinaryLogic
        {
            public BinaryLogic Operator
                => BinaryLogic.And;
        }

        public readonly struct Or : IBinaryLogic
        {
            public BinaryLogic Operator
                => BinaryLogic.Or;
        }

        public readonly struct XOr : IBinaryLogic
        {
            public BinaryLogic Operator
                => BinaryLogic.XOr;
        }

        public readonly struct LogicVal
        {
            public static implicit operator LogicVal(bool? src)
                => new LogicVal(src);

            public static implicit operator bool?(LogicVal src)
                => src.Value;

            public LogicVal(bool? value = null)
                => this.Value = value;

            public readonly bool? Value;

        }

        public readonly struct Single
        {
            public static implicit operator bool?(Single src)
                => src.A.Value;

            public static implicit operator Single(bool? src)
                => new Single(src);


            public Single(LogicVal src)
                => this.A = src;
            
            public readonly LogicVal A;

        }

        public readonly struct Pair
        {
            public static implicit operator (bool? a, bool? b)(Pair src)
                => (src.A, src.B);

            public static implicit operator Pair((bool? a, bool? b) src)
                => new Pair(src.a, src.b);


            public Pair(LogicVal a, LogicVal b)
            {
                this.A = a;
                this.B = b;
            }

            public readonly LogicVal A;

            public readonly LogicVal B;

        }
        
        public readonly struct Triple
        {
            public static implicit operator (bool? a, bool? b, bool? c)(Triple src)
                => (src.A, src.B, src.C);

            public static implicit operator Triple((bool? a, bool? b, bool? c) src)
                => new Triple(src.a, src.b, src.c);

            public Triple(LogicVal a, LogicVal b, LogicVal c)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }

            public readonly LogicVal A;

            public readonly LogicVal B;

            public readonly LogicVal C;
        }

    }

}