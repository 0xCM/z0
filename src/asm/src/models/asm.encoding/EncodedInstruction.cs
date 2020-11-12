//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly struct EncodedInstruction
    {
        public readonly Vector128<byte> Data;

        [MethodImpl(Inline)]
        public EncodedInstruction(Vector128<byte> src)
            => Data = src;

        /// <summary>
        /// Specifies the size of the command, in bytes, which is constrained to a number
        /// between 0 (the empty command) and 15 (The maximum instruction size)
        /// </summary>
        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 15);
        }
    }
}