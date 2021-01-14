//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Identifies a language
    /// </summary>
    public readonly struct LanguageSpec
    {
        public Name Id {get;}

        [MethodImpl(Inline)]
        public LanguageSpec(string id)
            => Id  = id;

        [MethodImpl(Inline)]
        public static implicit operator LanguageSpec(string id)
            => new LanguageSpec(id);
    }
}