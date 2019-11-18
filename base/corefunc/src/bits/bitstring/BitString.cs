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
    /// Represents a sequence of bits
    /// </summary>
    public partial struct BitString : IWord<BitString, BinaryAlphabet>
    {
        byte[] bitseq;

        /// <summary>
        /// Defines the canonical emtpy bitstring of 0 length
        /// </summary>
        public static BitString Empty => parse(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator string(BitString src)                
            => src.Format();

        [MethodImpl(Inline)]
        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitString lhs, BitString rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitString operator +(BitString lhs, BitString rhs)
            => lhs.Concat(rhs);

        [MethodImpl(Inline)]
        public static BitString operator &(BitString lhs, BitString rhs)
            => and(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitString operator |(BitString lhs, BitString rhs)
            => or(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitString operator ^(BitString lhs, BitString rhs)
            => xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitString operator <<(BitString lhs, int offset)
            => sll(lhs,offset);

        [MethodImpl(Inline)]
        public static BitString operator >>(BitString lhs, int offset)
            => srl(lhs,offset);

        [MethodImpl(Inline)]
        public static BitString operator ~(BitString src)
            => not(src);

        [MethodImpl(Inline)]
        BitString(byte[] src)
        {
            this.bitseq = src;
        }

        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<byte> src)
        {
            this.bitseq = src.ToArray();
        }

        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<bit> src)
        {
            this.bitseq = new byte[src.Length];
            for(var i=0; i<src.Length; i++)
                this.bitseq[i] = (byte)src[i];
        }

        [MethodImpl(Inline)]
        BitString(bit[] src)
        {
            this.bitseq = new byte[src.Length];
            for(var i=0; i<src.Length; i++)
                this.bitseq[i] = (byte)src[i];
        }

        /// <summary>
        /// Queries/manipulates bit at specified index
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => bitseq[index] == 1;

            [MethodImpl(Inline)]
            set => bitseq[index] = (byte)value;
        }

        /// <summary>
        /// Extracts a substring determined by start/end indices
        /// </summary>
        public BitString this[int i0, int i1]
        {
            [MethodImpl(Inline)]
            get => new BitString(BitSeq.Slice(i0, i1 - i0 + 1));
        }

        /// <summary>
        /// Extracts a substring determined by a range
        /// </summary>
        public BitString this[Range range]
        {
            [MethodImpl(Inline)]
            get => this[range.Start.Value, range.End.Value];
        }

        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => bitseq.Length;
        }            

        public readonly bool IsEmpty
            => this.bitseq.Length == 0;

        public BitString Zero 
            => Empty;

        /// <summary>
        /// The (unpacked) sequence of bits represented by the bitstring
        /// </summary>
        public Span<byte> BitSeq
        {
            [MethodImpl(Inline)]
            get => bitseq ?? Span<byte>.Empty;
        }

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeScalar<T>()
            where T : unmanaged
                => PackSingle<T>(0);

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeScalar<T>(int offset)
            where T : unmanaged
                => PackSingle<T>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed byte value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public byte TakeUInt8(int offset)
            => TakeScalar<byte>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed byte value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public byte TakeUInt8()
            => TakeScalar<byte>();

        /// <summary>
        /// Renders a bitstring segment as a packed ushort value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ushort TakeUInt16(int offset)
            => TakeScalar<ushort>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed ushort value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ushort TakeUInt16()
            => TakeScalar<ushort>();

        /// <summary>
        /// Renders a bitstring segment as a packed uint value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public uint TakeUInt32(int offset)
            => TakeScalar<uint>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed uint value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public uint TakeUInt32()
            => TakeScalar<uint>();

        /// <summary>
        /// Renders a bitstring segment as a packed ulong value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ulong TakeUInt64(int offset)
            => TakeScalar<ulong>(offset);

        [MethodImpl(Inline)]
        public ulong TakeUInt64()
            => TakeScalar<ulong>();

        /// <summary>
        /// Packs a section of the represented bits into a bytespan
        /// </summary>
        /// <param name="offset">The position of the first bit</param>
        /// <param name="minlen">The the minimum length of the produced span</param>
        [MethodImpl(Inline)]
        public readonly Span<byte> Pack()
            => PackedBits(bitseq, 0, null);

        [MethodImpl(Inline)]
        public readonly Span<byte> Pack(int offset, int minlen)
            => PackedBits(bitseq, offset, minlen);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        public int Nlz()
        {
            var lastix = bitseq.Length - 1;
            var count = 0;
            for(var i=lastix; i>= 0; i--)
            {
                if(bitseq[i] != 0)
                    break;
                else
                    count++;                
            }
            return count;
        }

        /// <summary>
        /// Shifts the bits leftwards by a specifed offset in a manner that mimics the canonical scalar left-shift
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        public BitString Sll(int offset)
        {
            Array.Copy(bitseq, 0, bitseq, offset, offset);
            for(var i=0; i<offset; i++)
                bitseq[i] = 0;
            return this;
        }
                  
        /// <summary>
        /// Counts the number of enabled bits
        /// </summary>
        public int PopCount()
        {
            var count = 0;
            for(var i=0; i<bitseq.Length; i++)
                if(bitseq[i] == 1)
                    count++;
            return count;
        }

        /// <summary>
        /// Creates a replica of the bitstring
        /// </summary>
        public BitString Replicate()
        {
            Span<byte> dst = new byte[Length];
            bitseq.CopyTo(dst);
            return new BitString(dst);
        }

        /// <summary>
        /// Copies n replicas to a new bitstring
        /// </summary>
        /// <param name="n">Then number of times to replicate the bistring in the target</param>
        public BitString Replicate(int n)
        {            
            Span<byte> dst = new byte[Length*n];
            for(var i=0; i<n; i++)
                bitseq.CopyTo(dst.Slice(i*Length));
            return new BitString(dst);
        }


        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        public void RotL(int offset)
        {
            Span<byte> dst = bitseq;
            Span<byte> src = stackalloc byte[Length];
            dst.CopyTo(src);
            var cut = Length - offset;
            var seg1 = src.Slice(0, cut);
            var seg2 = src.Slice(cut);
            seg2.CopyTo(dst, 0);
            seg1.CopyTo(dst, offset);
        }

        /// <summary>
        /// Forms a new bitstring by concatenation
        /// </summary>
        /// <param name="tail">The trailing bits</param>
        public BitString Concat(BitString tail)
        {
            Span<byte> dst = new byte[Length + tail.Length];
            tail.BitSeq.CopyTo(dst);
            BitSeq.CopyTo(dst, tail.Length);
            return new BitString(dst);
        }

        /// <summary>
        /// Returns a new bitstring of length no greater than a specified maximum
        /// </summary>
        /// <param name="maxlen">The maximum length</param>
        public BitString Truncate(int maxlen)
        {
            if(Length <= maxlen)
                return new BitString(bitseq);
            var dst = bitseq.AsSpan().Slice(0, maxlen).ToArray();
            return new BitString(dst);
        }

        /// <summary>
        /// Returns a new bitstring of length no less than a specified minimum
        /// </summary>
        /// <param name="minlen">The minimum length</param>
        public BitString Pad(int minlen)
        {
            if(Length >= minlen)
                return new BitString(bitseq);
            
            Span<byte> src = bitseq;
            var dst = new byte[minlen];
            src.CopyTo(dst);
            return new BitString(dst);            
        }

        /// <summary>
        /// Converts the bistring to a binary digit representation
        /// </summary>
        public Span<BinaryDigit> ToDigits()
        {
            Span<BinaryDigit> dst = new BinaryDigit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = (BinaryDigit)bitseq[i];
            return dst;
        }

        /// <summary>
        /// Renders the content as a span of bits
        /// </summary>
        public Span<bit> ToBitSpan()
        {
            Span<bit> dst = new bit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = (bit)bitseq[i];
            return dst;
        }

        /// <summary>
        /// Renders the content as a natural bitspan
        /// </summary>
        public Span<N,bit> ToBitSpan<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var dst = NatSpan.alloc<N,bit>();
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = (bit)bitseq[i];
            return dst;
        }

        /// <summary>
        /// Packs the bitsequence into a bytespan
        /// </summary>
        public Span<byte> ToPackedBytes()
            => PackedBits(bitseq);

        /// <summary>
        /// Determines whether this bitstring represents the same value as another, ignoring
        /// leading zeroes
        /// </summary>
        /// <param name="rhs">The bitstring with which the comparison will be made</param>
        [MethodImpl(Inline)]
        public bool Equals(BitString rhs, Action<string> trace = null)
        {                                                            
            var x = Truncate(this.Length - this.Nlz());
            var y = rhs.Truncate(rhs.Length - rhs.Nlz());
            if(x.Length != y.Length)
            {
                trace?.Invoke($"The source length {x.Length} differs from the operand length {y.Length}");                
                return false;
            }
                
            for(var i=0; i< x.Length; i++)            
                if(x.bitseq[i] != y.bitseq[i])
                {
                    trace?.Invoke($"x[{i}] = {x.bitseq[i]} != {y.bitseq[i]} = y[{i}]");
                    return false;            
                }
            return true;
        }

        /// <summary>
        /// Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        public BitString[] Partition(int width)
        {
            var minCount = Math.DivRem(bitseq.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            Span<byte> src = bitseq;
            var dst = new BitString[count];
            var lastix = dst.Length - 1;            
            for(int i=0, offset = 0; i< dst.Length; i++, offset += width)
            {   
                if(i == lastix && remainder != 0)
                {
                    Span<byte> fullBlock = new byte[width];
                    src.Slice(offset,remainder).CopyTo(fullBlock);
                    dst[i] = new BitString(fullBlock);
                }                    
                else
                    dst[i] = new BitString(src.Slice(offset, width));
            }
            return dst;
        }

        readonly string FormatUnblocked(bool tlz, bool specifier)
        {
            if(bitseq == null || bitseq.Length == 0)
                return string.Empty;

            Span<char> dst = stackalloc char[bitseq.Length];
            var lastix = dst.Length - 1;
            for(var i=0; i< dst.Length; i++)
                dst[lastix - i] = bitseq[i] == 0 ? '0' : '1';
            
            var result = new string(dst);
            if(tlz)
                result = result.TrimStart('0');
            if(specifier)
                result = $"0b{result}";
            return result;
        }

        /// <summary>
        /// Formats bitstring content
        /// </summary>
        /// <param name="tlz">Indicates whether leading zero bits should be eliminated from the result</param>
        /// <param name="specifier">True if the canonical 0b specifier is to precede bitstring content, false if to omit the speicifier</param>
        /// <param name="blockWidth">If unspecified, no blocking will be applied; otherwise, indicates the width of the block partitions</param>
        /// <param name="blocksep">If unspecified, when block formatting, indicates the default block delimiter (An ASCII space) will be used;
        /// if specified, when block formatting, indicates the block delimiter to place between the block partitions</param>
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null, int? rowWidth = null)
        {                                            
            if(blockWidth == null)
                return FormatUnblocked(tlz,specifier);
            else
            {
                var sep = blocksep ?? ' ';
                var sb = sbuild();
                var blocks = Partition(blockWidth.Value).Reverse();
                var lastix = blocks.Length - 1;
                var counter = 0;
                for(var i=0; i<=lastix; i++)
                {
                    sb.Append(blocks[i].FormatUnblocked(false,false));
                    if(i != lastix)
                    {
                        if(rowWidth != null)
                        {
                            if(++counter % rowWidth.Value == 0)
                            {
                                counter = 0;
                                sb.AppendLine();
                            }
                            else 
                                sb.Append(sep);
                        }
                        else
                            sb.Append(sep);
                    }
                
                }
                var x = sb.ToString();
                return  (specifier ? "0b" : string.Empty) + (tlz ? x.TrimStart('0') : x);
            }            
        }

        /// <summary>
        /// Formats bitstring using default parameter values
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => Format(false, false, null, null);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => bitseq.GetHashCode();

        public override bool Equals(object rhs)
            => rhs is BitString x && Equals(x);

        /// <summary>
        /// Packs a section of bits into a scalar 
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        public T Scalar<T>(int offset = 0, int? count = null)
            where T : unmanaged
        {
            var len = Math.Min((count == null ? (int)bitsize<T>() : count.Value), Length - offset);       
            var bits = BitSeq.Slice(offset, len);
            return bits.TakeScalar<T>();
        }

        [MethodImpl(Inline)]
        readonly T PackSingle<T>(int offset)
            where T : unmanaged
        {                        
            var src = bitseq.ToReadOnlySpan();
            var packed = PackedBits(src, offset, size<T>());
            return packed.Length != 0 ? SpanConvert.TakeSingle<byte,T>(packed) : default;
        }

        [MethodImpl(Inline)]
        static bool HasBitSpecifier(in string bs)
        {
            if(bs.Length < 2)
                return false;            
            return bs[0] == '0' && bs[1] == 'b';        
        }

        /// <summary>
        /// Constructs a bitstring from a span of primal values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static BitString FromScalars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
                 => new BitString(ReadBitSeq(src, maxlen));

        static Span<byte> ReadBitSeq<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
        {
            require(typeof(T) != typeof(char));            
            var seglen = Unsafe.SizeOf<T>()*8;
            Span<byte> dst = new byte[src.Length * seglen];
            for(var i=0; i<src.Length; i++)
                BitStore.bitseq(src[i]).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }

        static Span<byte> PackedBits(ReadOnlySpan<byte> src, int offset = 0, int? minlen = null)
        {            
            if(src.Length <= offset)
                return new byte[minlen ?? 1];

            var srcLen = (uint)(src.Length - offset);
            var dstLen = Mod8.div(srcLen) + (Mod8.mod(srcLen) == 0 ? 0 : 1);   
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            Span<byte> dst = new byte[dstLen];
            for(int i=0, j=0; j < dstLen; i+=8, j++)
            {
                ref var x = ref dst[j];
                for(var k=0; k<8; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < srcLen && src[srcIx] != 0)
                        BitMask.enable(ref x, k);
                }
            }
            return dst;
        }
    }
}