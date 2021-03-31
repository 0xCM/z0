//-----------------------------------------------------------------------------
// Generated   :  2021-03-31.15.21.10.9587
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ITypedInstruction
    {
        AsmMnemonicCode Mnemonic {get;}
    }

    public interface ITypedInstruction<T> : ITypedInstruction
        where T : struct, ITypedInstruction<T>
    {

    }
}
