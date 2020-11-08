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
        public interface IConjunction<T> : ISequence<T>
            where T : IExpression<T>
        {

        }
    }
}