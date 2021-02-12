//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiSigs
    {
        public interface IOperandModifier<T> : ITextual
            where T : struct, IOperandModifier<T>
        {
            Name Name {get;}

            ModifierKind Kind {get;}
        }
    }
}