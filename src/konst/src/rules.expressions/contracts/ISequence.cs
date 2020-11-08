//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Rules
    {
        public interface ISequence<T> : IExpression<IndexedView<T>>
            where T : IExpression<T>
        {
            IndexedView<T> Terms => Content;
        }

        public interface ISingletonSeq<T> : ISequence<T>
            where T : IExpression<T>
        {
            T Term => Terms[0];
        }

        public interface ILimitedSeq<T> : ISequence<T>
            where T : IExpression<T>
        {
            uint MinCount {get;}

            uint MaxCount {get;}
        }
    }
}