//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EncodedAsmRoutine
    {
        public readonly asci32 Name;

        public readonly EncodedFx[] Commands;

        [MethodImpl(Inline)]
        public EncodedAsmRoutine(asci32 name, EncodedFx[] commands)
        {
            Name = name;
            Commands = commands;
        }

        public ref EncodedFx this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Commands[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Commands.Length == 0;
        }
    }
}