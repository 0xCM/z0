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
    /// Defines a <see cref='PackedInstruction'/> sequence
    /// </summary>
    public readonly struct PackedInstructions : IIndex<PackedInstruction>
    {
        readonly Index<PackedInstruction> Data;

        [MethodImpl(Inline)]
        public PackedInstructions(PackedInstruction[] src)
            => Data = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public PackedInstruction[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator PackedInstructions(PackedInstruction[] src)
            => new PackedInstructions(src);
    }
}