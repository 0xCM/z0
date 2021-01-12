//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes the assembly encoding of a member api
    /// </summary>
    public class AsmRoutine
    {
        /// <summary>
        /// The defining operation uri
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The function identifier
        /// </summary>
        public OpIdentity OpId {get;}

        /// <summary>
        /// The source member signature
        /// </summary>
        public ClrDisplaySig DisplaySig {get;}

        /// <summary>
        /// The function encoding
        /// </summary>
        public ApiCodeBlock Code {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public IceInstructionList Instructions {get;}

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode {get;}

        /// <summary>
        /// The operation metadata uri
        /// </summary>
        public ApiArtifactUri MetaUri {get;}

        [MethodImpl(Inline)]
        public AsmRoutine(ApiArtifactUri meta, OpUri uri, ClrDisplaySig sig, ApiCodeBlock code, ExtractTermCode term, IceInstructionList instructions)
        {
            MetaUri = meta;
            Uri = uri;
            OpId = uri.OpId;
            DisplaySig = sig;
            Instructions = instructions;
            Code = code;
            TermCode =term;
        }

        /// <summary>
        /// The head of the address range
        /// </summary>
        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Code.BaseAddress;
        }

        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;
        }

        public bool IsEmpty
            => InstructionCount == 0;

        public bool IsNonEmpty
            => InstructionCount != 0;

        public static AsmRoutine Empty
            => new AsmRoutine(ApiArtifactUri.Empty, OpUri.Empty, ClrDisplaySig.Empty, ApiCodeBlock.Empty, 0, IceInstructionList.Empty);
    }
}