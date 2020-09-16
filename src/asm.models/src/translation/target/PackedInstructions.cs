//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a <see cref='PackedInstruction'/> sequence
    /// </summary>
    public readonly struct PackedInstructions : ISequentialHost<PackedInstructions,PackedInstruction>
    {
        readonly TableSpan<PackedInstruction> Data;

        [MethodImpl(Inline)]
        public static implicit operator PackedInstructions(PackedInstruction[] src)
            => new PackedInstructions(src);

        [MethodImpl(Inline)]
        public PackedInstructions(PackedInstruction[] src)
            => Data = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        Pairings<uint,PackedInstruction> IBijection<uint, PackedInstruction>.Terms
            => Data.View.Map((i,x) => paired(i,x), z32);
    }
}