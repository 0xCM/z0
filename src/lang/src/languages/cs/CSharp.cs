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

        public static string build<T>(Identifier f, SwitchCases<T> src)
            where T : unmanaged
        {
            var dst = text.buffer();
            dst.AppendLineFormat("public void {0}");
            dst.AppendLine("{");
            for(var i=0u; i<src.Count; i++)
            {
                (var branch, var target) = src[i];
                dst.AppendLineFormat("case {0}:", branch);
                dst.AppendLineFormat("{0}({1});", target, branch);
                dst.AppendLine("break;");
            }
            dst.AppendLine("}");
            return dst.Emit();
        }
   }
}