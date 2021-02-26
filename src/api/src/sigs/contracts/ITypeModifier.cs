//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiSigs
    {
        public interface ITypeModifier<T> : ITextual
            where T : struct, ITypeModifier<T>
        {
            Name Name {get;}

            ModifierKind Kind {get;}
        }
    }
}