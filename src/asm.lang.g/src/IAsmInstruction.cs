//-----------------------------------------------------------------------------
// Generated   :  20210219.04.04.06.5035
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
