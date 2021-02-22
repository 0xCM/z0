//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    partial class AsmGen
    {
        readonly struct MonicEnumModel
        {
            readonly Index<AsmMnemonic> Monics;

            [MethodImpl(Inline)]
            public MonicEnumModel(AsmMnemonic[] src)
            {
                Monics = src;
            }

            public void Render(uint margin, ITextBuffer buffer)
            {
                var src = Monics.View;
                buffer.AppendLine("namespace Z0.Asm");
                buffer.AppendLine(Open);
                margin += 4;
                buffer.IndentLine(margin, "public enum AsmMnemonicCode : ushort");
                buffer.IndentLine(margin, Open);
                margin += 4;

                buffer.IndentLine(margin, "None = 0,");
                buffer.AppendLine();

                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var monic = ref skip(src,i);
                    buffer.IndentLine(margin, string.Format("{0} = {1},", monic.Name, i+1));
                    buffer.AppendLine();
                }
                margin -= 4;
                buffer.IndentLine(margin, Close);

                margin -= 4;
                buffer.IndentLine(margin, Close);
            }


            [MethodImpl(Inline)]
            public static implicit operator MonicEnumModel(AsmMnemonic[] src)
                => new MonicEnumModel(src);

            public static MonicEnumModel Empty
                => new MonicEnumModel(sys.empty<AsmMnemonic>());
        }
    }
}