//-----------------------------------------------------------------------------
// Generated   :  2021-03-11.15.45.32.4478
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
