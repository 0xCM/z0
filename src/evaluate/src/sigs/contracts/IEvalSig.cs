//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct EvalSigs
    {
        public interface IEvalSig
        {
            Index<Type> Components {get;}
        }

        public interface IEvalSig<R> : IEvalSig
        {
            Index<Type> IEvalSig.Components
            {
                [MethodImpl(Inline)]
                get => array(typeof(R));
            }
        }

        public interface IEvalSig<A,R> : IEvalSig
        {
            Index<Type> IEvalSig.Components
            {
                [MethodImpl(Inline)]
                get => array(typeof(A), typeof(R));
            }

        }

        public interface IEvalSig<A,B,R> : IEvalSig
        {
            Index<Type> IEvalSig.Components
            {
                [MethodImpl(Inline)]
                get => array(typeof(A), typeof(B), typeof(R));
            }
        }

        public interface IEvalSig<A,B,C,R> : IEvalSig
        {
            Index<Type> IEvalSig.Components
            {
                [MethodImpl(Inline)]
                get => array(typeof(A), typeof(B), typeof(C), typeof(R));
            }
        }
    }
}