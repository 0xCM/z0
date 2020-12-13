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
        public string Label {get;}

        public MemoryAddress BaseAddress {get;}

        public BinaryCode Encoded {get;}

        public AsciEncoded Asm {get;}

        [MethodImpl(Inline)]
        public MachineFunction(string label, MemoryAddress @base, BinaryCode instructions, string asm = null)
        {
            Label = label;
            BaseAddress = @base;
            Encoded = instructions;
            Asm = asm ?? EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Label);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}