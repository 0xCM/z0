//-----------------------------------------------------------------------------
// Generated   :  2021-04-09.14.40.58.8759
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
