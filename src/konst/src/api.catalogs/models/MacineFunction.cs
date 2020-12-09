//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an executable x86 function
    /// </summary>
    public struct MachineFunction
    {
        public ApiSig Sig {get;}

        public MemoryAddress BaseAddress {get;}

        public BinaryCode Encoded {get;}

        public AsciEncoded Asm {get;}

        [MethodImpl(Inline)]
        public MachineFunction(ApiSig sig, MemoryAddress @base, BinaryCode instructions, string asm = null)
        {
            Sig = sig;
            BaseAddress = @base;
            Encoded = instructions;
            Asm = asm ?? EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Sig.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}