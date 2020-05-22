//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public readonly struct CommandM : ICommandM<CommandM>
    {
        public const int PhysicalSize = 16;
        
        readonly Vector128<byte> Data;

        [MethodImpl(Inline)]
        internal CommandM(Vector128<byte> src)
        {
            Data = src;
        }
        
        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Commands.bytes(Data);
        }

        /// <summary>
        /// Specifies the size of the command, in bytes, which is constrained to a number
        /// between 0 (the empty command) and 15 (The maximum instruction size)
        /// </summary>
        public byte Size
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 15);
        }
    }
}