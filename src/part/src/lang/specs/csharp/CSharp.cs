//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("lang.sharp")]
    public readonly partial struct CSharp : ILanguage<CSharp>
    {
        public LanguageSpec Specifier => Languages.csharp;

        public Name Id => Specifier.Id;
   }
}