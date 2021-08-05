//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public interface ICmpPred : ITextual
        {
            CmpKind Kind {get;}
        }

        public interface ICmpPred<T> : ICmpPred
        {
            T A {get;}

            T B {get;}
        }

        public interface ICmpPred<F,T> : ICmpPred<T>
            where F : ICmpPred<F,T>
        {

        }
    }
}