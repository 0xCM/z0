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
    using static V0;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly struct EncodedCommand : IEncodedCommand<EncodedCommand>
    {        
        internal readonly Vector128<byte> Data;

        [MethodImpl(Inline)]
        internal EncodedCommand(Vector128<byte> src)
            => Data = src;
        
        public ReadOnlySpan<byte> Encoding
        {
            [MethodImpl(Inline)]
            get => Asm.Data.Encoding.encoding(this);
        }

        /// <summary>
        /// Specifies the size of the command, in bytes, which is constrained to a number 
        /// between 0 (the empty command) and 15 (The maximum instruction size)
        /// </summary>
        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => vcell(Data, 15);
        }

        public string Format()
            => Asm.Data.Encoding.format(this);

        public override string ToString()
            => Format();        

        public static EncodedCommand Empty 
            => default;
    }
}