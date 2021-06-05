//-----------------------------------------------------------------------------
// Generated   :  2021-06-05.17.41.54.965
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
