//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    public readonly struct ApiInstructionBlock
    {
        readonly Index<ApiInstruction> Data;

        [MethodImpl(Inline)]
        internal ApiInstructionBlock(ApiInstruction[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ApiInstruction[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ApiInstruction> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ApiInstruction[] All
            => Data;

        public static implicit operator ApiInstructionBlock(ApiInstruction[] src)
            => new ApiInstructionBlock(src);

        public static ApiInstructionBlock Empty
        {
            [MethodImpl(Inline)]
            get => sys.empty<ApiInstruction>();
        }
    }
}