//-----------------------------------------------------------------------------
// Generated   :  2021-06-09.00.04.02.867
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ITypedInstruction
    {
        AsmMnemonicCode Mnemonic {get;}

        AsmHexCode Encoded {get;}
    }

    public interface ITypedInstruction<T> : ITypedInstruction
        where T : struct, ITypedInstruction<T>
    {

    }
}
