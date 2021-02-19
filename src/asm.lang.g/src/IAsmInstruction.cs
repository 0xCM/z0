//-----------------------------------------------------------------------------
// Generated   :  20210219.04.12.01.0733
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmInstruction
    {
        AsmMnemonicCode Mnemonic {get;}
    }

    public interface IAsmInstruction<T> : IAsmInstruction
        where T : struct, IAsmInstruction<T>
    {

    }
}
