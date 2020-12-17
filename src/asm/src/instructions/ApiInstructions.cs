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

    public readonly struct ApiInstructions
    {
        readonly ApiInstruction[] Data;

        [MethodImpl(Inline)]
        internal ApiInstructions(ApiInstruction[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref ApiInstruction this[ulong i]
        {
            [MethodImpl(Inline)]
            get => ref z.first(z.span(Data));
        }

        public ref ApiInstruction this[long i]
        {
            [MethodImpl(Inline)]
            get => ref z.first(z.span(Data));
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

        public static implicit operator ApiInstructions(ApiInstruction[] src)
            => new ApiInstructions(src);
    }
}