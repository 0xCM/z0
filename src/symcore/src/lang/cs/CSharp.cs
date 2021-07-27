//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static CsModels;

    [ApiHost]
    public readonly partial struct CSharp : ILanguage<CSharp>
    {
        public Language Specifier => "csharp";

        public string Id => Specifier.Id;

        [Op]
        public static SummaryComment comment(string content)
            => new SummaryComment(content);
   }
}