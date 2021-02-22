//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    [ApiHost("lang.sharp")]
    public readonly partial struct CSharp : ILanguage<CSharp>
    {
        public Language Specifier => Languages.csharp;

        public Name Id => Specifier.Id;
   }
}