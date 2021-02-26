//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiSigs
    {
        public interface ISigModifier<T> : ITextual
            where T : struct, ISigModifier<T>
        {
            Name Name {get;}

            ModifierKind Kind {get;}
        }
    }
}