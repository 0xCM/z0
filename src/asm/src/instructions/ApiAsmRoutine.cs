//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Specifies the asm routine determined by an api member
    /// </summary>
    public readonly struct ApiAsmRoutine
    {
        [MethodImpl(Inline)]
        public static ApiAsmRoutine create(MemoryAddress @base, X86ApiCode uriCode, Instruction[] src)
            => new ApiAsmRoutine(@base, ApiInstruction.map(uriCode, src.ToArray()));

        /// <summary>
        /// The member uri
        /// </summary>
        public OpUri Uri {get;}

        public ApiInstructions Instructions {get;}

        public MemoryAddress BaseAddress {get;}

        public MemoryAddress HostAddress {get;}

        public MemoryOffset OffsetAddress
            => MemoryOffsets.offset(BaseAddress, HostAddress);

        public OpIdentity OpId => Uri.OpId;

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

        public ApiAsmRoutine Zero
            => Empty;

        [MethodImpl(Inline)]
        public ApiAsmRoutine(MemoryAddress @base, ApiInstruction[] src)
        {
            Uri = src.Length != 0 ? src[0].OpUri : OpUri.Empty;
            Instructions = src;
            HostAddress = @base;
            BaseAddress = src.Length != 0 ? src[0].BaseAddress : MemoryAddress.Empty;
        }

        public static ApiAsmRoutine Empty
            => new ApiAsmRoutine(MemoryAddress.Empty, Array.Empty<ApiInstruction>());
    }
}