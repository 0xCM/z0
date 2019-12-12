//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines an 8-bit immediate
    /// </summary>    
    public readonly struct Imm8 : IImm<Imm8,byte>
    {            
        /// <summary>
        /// Defines an 8-bit immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm8 From(byte src)
            => src;

        /// <summary>
        /// Defines an 8-bit immediate from 8 explicitly specified bit values
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm8 From(
            bit b0 = default(bit), bit b1 = default(bit), bit b2 = default(bit), bit b3 = default(bit), 
            bit b4 = default(bit), bit b5 = default(bit), bit b6 = default(bit), bit b7 = default(bit))
        {
            byte dst = (byte)b0;
            dst |= (byte)((byte)b1 << 1);
            dst |= (byte)((byte)b2 << 2);
            dst |= (byte)((byte)b3 << 3);
            dst |= (byte)((byte)b4 << 4);
            dst |= (byte)((byte)b5 << 5);
            dst |= (byte)((byte)b6 << 6);
            dst |= (byte)((byte)b7 << 7);
            return new Imm8(dst);
        }

        /// <summary>
        /// The value of the immediate constant
        /// </summary>
        public readonly byte Value;

        /// <summary>
        /// Specifies the size of the immediate in bytes
        /// </summary>
        public static readonly BitSize Size = 8;

        /// <summary>
        /// Defines an 8-bit immediate from an 8-bit source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Imm8 Define(byte src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator Imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline)]
        public Imm8(byte src)
            => this.Value = src;

        public ImmInfo Description 
        {
            [MethodImpl(Inline)]
            get => new ImmInfo(Size,Value);
        }

        /// <summary>
        /// Formats the immediate value as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public string Formatbits()
            => Value.ToBitString().Format();
        
        /// <summary>
        /// Formats the immediate as a block of primal cells, one for each bit
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public string FormatBlocked<T>()
            where T : unmanaged
        {
            var label = $"imm8".PadRight(6);
            var format = Unpack(new Span<T>(new T[8])).FormatCellBlocks();
            return $"{label}{format}";
        }

        /// <summary>
        /// Populates a primal span where each cell indicates the value of the corresponding bit
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public Span<T> Unpack<T>(Span<T> dst)
            where T : unmanaged
        {
            var bitseq = Value.ToBitString().BitSeq;
            for(var i=0; i<dst.Length; i++)
                dst[i] = convert<T>(bitseq[i]);                    
            return dst;
        }

        byte IImm<byte>.Value 
            => Value;

        Imm8 IImm<Imm8,byte>.Redefine(byte src)
            => new Imm8(src);
    }
}
