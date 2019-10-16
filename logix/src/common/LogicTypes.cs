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

        public interface INullaryLogic : ILogicType<NullaryLogicKind>
        {

        }

        public interface IUnaryLogic : ILogicType<UnaryLogicKind>
        {
            
        }

        public interface IBinaryLogic : ILogicType<BinaryLogicKind>
        {

        }

        public interface ITernaryLogic : ILogicType<TernaryLogicKind>
        {

        }
        

        public readonly struct False : INullaryLogic
        {
            public NullaryLogicKind Operator
                => NullaryLogicKind.False;
        }

        public readonly struct True  : INullaryLogic
        {
            public NullaryLogicKind Operator
                => NullaryLogicKind.True;
        }

        public readonly struct Not : IUnaryLogic
        {
            public UnaryLogicKind Operator
                => UnaryLogicKind.Not;
        }

        public readonly struct Identity : IUnaryLogic
        {
            public UnaryLogicKind Operator
                => UnaryLogicKind.Identity;
        }
        

        public readonly struct And : IBinaryLogic
        {
            public BinaryLogicKind Operator
                => BinaryLogicKind.And;
        }

        public readonly struct Or : IBinaryLogic
        {
            public BinaryLogicKind Operator
                => BinaryLogicKind.Or;
        }

        public readonly struct XOr : IBinaryLogic
        {
            public BinaryLogicKind Operator
                => BinaryLogicKind.XOr;
        }


    }

}