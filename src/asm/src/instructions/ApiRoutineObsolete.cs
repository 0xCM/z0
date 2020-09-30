//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Specifies the asm routine determined by an api member
    /// </summary>
    public readonly struct ApiRoutineObsolete
    {
        public string OpId {get;}

        public ApiInstructions Instructions {get;}

        public MemoryAddress BaseAddress {get;}

        public MemoryAddress HostAddress {get;}

        public MemoryOffset OffsetAddress
            => MemoryOffsets.offset(BaseAddress, HostAddress);

        public uint InstructionCount
        {
            [MethodImpl(Inline)]
            get => Instructions.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => InstructionCount == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => InstructionCount != 0;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;
        }

        public ref ApiInstruction this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Instructions[i];
        }

        [MethodImpl(Inline)]
        public ApiRoutineObsolete(MemoryAddress @base, ApiInstruction[] src)
        {
            if(src.Length != 0)
            {
                var i = src[0];
                OpId = i.OpId;
                Instructions = src;
                HostAddress = @base;
                BaseAddress = i.Base;
            }
            else
            {
                OpId = EmptyString;
                Instructions = default;
                HostAddress = default;
                BaseAddress = default;
            }
        }
    }
}