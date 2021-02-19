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
        readonly struct InstructionContracts
        {
            public void Render(uint margin, ITextBuffer dst)
            {
                dst.AppendLine(Pattern);
            }

            const string Pattern = @"namespace Z0.Asm
{
    public interface IAsmInstruction
    {
        AsmMnemonicCode Mnemonic {get;}
    }

    public interface IAsmInstruction<T> : IAsmInstruction
        where T : struct, IAsmInstruction<T>
    {

    }
}";

        }
    }
}