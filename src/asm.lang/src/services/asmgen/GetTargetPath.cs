//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    partial class AsmGen
    {
        string FileIdentifier(AsmGenTarget kind)
            => kind switch {
                AsmGenTarget.InstructionType => "AsmInstructions",
                AsmGenTarget.MonicCode => "AsmMnemonicCode",
                AsmGenTarget.MonicExpression => "AsmMnemonics",
                AsmGenTarget.InstructionContracts=> "IAsmInstruction",
                _ => EmptyString
            };

        FS.FilePath GetTargetPath(AsmGenTarget kind)
            => Db.SourceFile(PartId.AsmLangG, FS.file(FileIdentifier(kind), FS.Extensions.Cs));
    }
}