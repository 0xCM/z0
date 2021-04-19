//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmGen
    {
        public static string MonicFactoryName(AsmMnemonic src)
        {
            var identifier = src.Format(MnemonicCase.Lowercase);
            return identifier switch{
                "in" => "@in",
                "out" => "@out",
                "int" => "@int",
                "lock" => "@lock",
                _ => identifier
            };
        }

        public static string MonicTypeName(AsmMnemonic src)
            => src.Format(MnemonicCase.Captialized);
    }
}