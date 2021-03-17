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
        const string IAsmInstructionName = nameof(IAsmInstruction);

        const string InlineAttribute = "[MethodImpl(Inline)]";

        readonly struct InstructionModel
        {
            readonly AsmMnemonic Monic;

            [MethodImpl(Inline)]
            public InstructionModel(AsmMnemonic src)
            {
                Monic = src;
            }

            string TypeName()
                => Monic.Format(MnemonicCase.Captialized);

            string FactoryName()
            {
                var identifier = Monic.Format(MnemonicCase.Lowercase);
                return identifier switch{
                    "in" => "@in",
                    "out" => "@out",
                    "int" => "@int",
                    "lock" => "@lock",
                    _ => identifier
                };
            }

            public void Render(uint margin, ITextBuffer buffer)
            {
                var type = TypeName();
                var factory = FactoryName();
                buffer.IndentLine(margin, string.Format("public struct {0} : {1}<{0}>", type, IAsmInstructionName));
                buffer.IndentLine(margin, Open);
                margin += Indent;
                buffer.IndentLine(margin, string.Format("public AsmHexCode Encoded;"));
                buffer.AppendLine();
                buffer.IndentLine(margin, InlineAttribute);
                buffer.IndentLine(margin, string.Format("public {0}(AsmHexCode encoded)", type));
                buffer.IndentLine(margin, Open);
                margin += Indent;
                buffer.IndentLine(margin, string.Format("Encoded = encoded;"));
                margin -= Indent;
                buffer.IndentLine(margin, Close);
                buffer.AppendLine();
                buffer.IndentLine(margin, string.Format("public AsmMnemonicCode Mnemonic => AsmMnemonicCode.{0};", Monic.Name));
                buffer.AppendLine();
                buffer.IndentLine(margin, string.Format("public static implicit operator AsmMnemonicCode({0} src) => src.Mnemonic;", type));
                buffer.AppendLine();
                buffer.IndentLine(margin, string.Format("public static implicit operator AsmMnemonic({0} src) => AsmMnemonics.{1};", type, Monic.Name));
                margin -= Indent;
                buffer.IndentLine(margin, Close);
                buffer.AppendLine();
                buffer.IndentLine(margin, string.Format("public static {0} {1}() => default;", type, factory));
                buffer.AppendLine();
                buffer.IndentLine(margin, InlineAttribute);
                buffer.IndentLine(margin, string.Format("public static {0} {1}(AsmHexCode encoded) => new {0}(encoded);", type, factory));
                buffer.AppendLine();
            }

            [MethodImpl(Inline)]
            public static implicit operator InstructionModel(AsmMnemonic src)
                => new InstructionModel(src);

            public static InstructionModel Empty
                => new InstructionModel(AsmMnemonic.Empty);
        }
    }
}