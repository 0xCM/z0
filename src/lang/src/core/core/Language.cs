//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ILanguage
    {
        Type Metatype {get;}
    }

    public interface ILanguage<L> : ILanguage
    {
        Name Id {get;}

        Type ILanguage.Metatype
            => typeof(L);
    }

    /// <summary>
    /// Identifies a language
    /// </summary>
    public readonly struct Language
    {
        public Name Id {get;}

        [MethodImpl(Inline)]
        public Language(string id)
            => Id  = id;

        [MethodImpl(Inline)]
        public static implicit operator Language(string id)
            => new Language(id);
    }
}