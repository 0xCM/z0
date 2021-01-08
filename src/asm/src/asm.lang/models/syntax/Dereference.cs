//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmLang
    {
        public readonly struct Dereference<T> : IExpression<Dereference<T>,T>
        {
            public T Subject {get;}

            public string RenderPattern => "[{0}]";
        }
    }
}