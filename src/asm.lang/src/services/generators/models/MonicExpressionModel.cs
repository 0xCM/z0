//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class AsmGen
    {
        readonly struct MonicExpressionModel
        {
            readonly Index<AsmMnemonic> Monics;

            [MethodImpl(Inline)]
            public MonicExpressionModel(AsmMnemonic[] src)
            {
                Monics = src;
            }

            public void Render(uint margin, ITextBuffer buffer)
            {
                var src = Monics.View;

                buffer.AppendLine("namespace Z0.Asm");
                buffer.AppendLine("{");
                margin += 4;
                buffer.IndentLine(margin, "public readonly struct AsmMnemonics");
                buffer.IndentLine(margin, "{");
                margin += 4;

                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var monic = ref skip(src,i);
                    buffer.IndentLine(margin, string.Format("public static AsmMnemonic {0} => nameof({0});", monic.Name));
                    buffer.AppendLine();
                }
                margin -= 4;
                buffer.IndentLine(margin, "}");

                margin -= 4;
                buffer.IndentLine(margin, "}");
            }

            [MethodImpl(Inline)]
            public static implicit operator MonicExpressionModel(AsmMnemonic[] src)
                => new MonicExpressionModel(src);

            public static MonicExpressionModel Empty
                => new MonicExpressionModel(sys.empty<AsmMnemonic>());
        }
    }
}