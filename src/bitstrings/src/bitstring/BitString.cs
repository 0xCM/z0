//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    /// <summary>
    /// Represents a sequence of bits
    /// </summary>
    public partial struct BitString : IEquatable<BitString>
    {
        byte[] data;

        [MethodImpl(Inline)]
        internal BitString(byte[] src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        internal BitString(ReadOnlySpan<byte> src)
        {
            data = src.ToArray();
        }

        [MethodImpl(Inline)]
        internal BitString(ReadOnlySpan<Bit32> src)
        {
            data = new byte[src.Length];
            for(var i=0; i<src.Length; i++)
                data[i] = (byte)src[i];
        }

        [MethodImpl(Inline)]
        internal BitString(ReadOnlySpan<bit> src)
        {
            data = new byte[src.Length];
            for(var i=0; i<src.Length; i++)
                data[i] = (byte)src[i];
        }

        /// <summary>
        /// Queries/manipulates bit at specified index
        /// </summary>
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => data[index] == 1;

            [MethodImpl(Inline)]
            set => data[index] = (byte)value;
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
            get => data.Length;
        }

        public readonly bool IsEmpty
            => this.data.Length == 0;

        public BitString Zero
            => Empty;

        /// <summary>
        /// The (unpacked) sequence of bits represented by the bitstring
        /// </summary>
        public Span<byte> BitSeq
        {
            [MethodImpl(Inline)]
            get => data ?? Span<byte>.Empty;
        }

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeScalar<T>()
            where T : unmanaged
                => PackOne<T>(0);

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeScalar<T>(int offset)
            where T : unmanaged
                => PackOne<T>(offset);

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
            => PackedBits(data, 0, null);

        [MethodImpl(Inline)]
        public readonly Span<byte> Pack(int offset, int minlen)
            => PackedBits(data, offset, minlen);

        /// <summary>
        /// Counts the number of leading zero bits
        /// </summary>
        public int Nlz()
        {
            var lastix = data.Length - 1;
            var count = 0;
            for(var i=lastix; i>= 0; i--)
            {
                if(data[i] != 0)
                    break;
                else
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Counts the number of trailing zero bits
        /// </summary>
        public int Ntz()
        {
            var count = 0;
            for(var i=0; i < data.Length; i++)
            {
                if(data[i] == 0)
                    count++;
                else
                    break;
            }
            return count;
        }

        /// <summary>
        /// Shifts the bits leftwards by a specifed offset in a manner that mimics the canonical scalar left-shift
        /// </summary>
        /// <param name="offset">The number of bits to shift</param>
        public BitString Sll(int offset)
        {
            Array.Copy(data, 0, data, offset, offset);
            for(var i=0; i<offset; i++)
                data[i] = 0;
            return this;
        }

        /// <summary>
        /// Counts the number of enabled bits
        /// </summary>
        public int PopCount()
        {
            var count = 0;
            for(var i=0; i<data.Length; i++)
                if(data[i] != 0)
                    count++;
            return count;
        }

        /// <summary>
        /// Creates a replica of the bitstring
        /// </summary>
        public BitString Replicate()
        {
            var dst = new byte[Length];
            data.CopyTo(dst);
            return new BitString(dst);
        }

        /// <summary>
        /// Copies n replicas to a new bitstring
        /// </summary>
        /// <param name="n">Then number of times to replicate the bistring in the target</param>
        public BitString Replicate(int n)
        {
            var storage = new byte[Length*n];
            Span<byte> dst = storage;

            for(var i=0; i<n; i++)
                data.CopyTo(dst.Slice(i*Length));
            return new BitString(storage);
        }

        /// <summary>
        /// Forms a new bitstring by concatenation
        /// </summary>
        /// <param name="tail">The trailing bits</param>
        public BitString Concat(BitString tail)
        {
            var dst = new byte[Length + tail.Length];
            tail.BitSeq.CopyTo(dst);
            BitSeq.CopyTo(dst, tail.Length);
            return new BitString(dst);
        }

        /// <summary>
        /// Forms a new bitstring by concatenation
        /// </summary>
        /// <param name="tail">The trailing bits</param>
        public BitString Concat(BitString s0, BitString s1)
        {
            var dst = new byte[Length + s0.Length + s1.Length];
            s1.BitSeq.CopyTo(dst);
            s0.BitSeq.CopyTo(dst, s1.Length);
            BitSeq.CopyTo(dst, s0.Length + s1.Length);
            return new BitString(dst);
        }
        /// <summary>
        /// Forms a new bitstring by concatenation
        /// </summary>
        /// <param name="tail">The trailing bits</param>
        public BitString Concat(BitString s0, BitString s1, BitString s2)
        {
            var dst = new byte[Length + s0.Length + s1.Length + s2.Length];
            s2.BitSeq.CopyTo(dst);
            s1.BitSeq.CopyTo(dst, s2.Length);
            s0.BitSeq.CopyTo(dst, s2.Length + s1.Length);
            BitSeq.CopyTo(dst, s2.Length + s1.Length + s0.Length);
            return new BitString(dst);
        }


        /// <summary>
        /// Returns a new bitstring of length no greater than a specified maximum
        /// </summary>
        /// <param name="maxlen">The maximum length</param>
        public BitString Truncate(int maxlen)
        {
            if(Length <= maxlen)
                return new BitString(data);
            var dst = data.AsSpan().Slice(0, maxlen).ToArray();
            return new BitString(dst);
        }

        /// <summary>
        /// Returns a new bitstring of length no less than a specified minimum
        /// </summary>
        /// <param name="minlen">The minimum length</param>
        public BitString Pad(uint minlen)
        {
            if(Length >= minlen)
                return new BitString(data);

            Span<byte> src = data;
            var dst = new byte[minlen];
            src.CopyTo(dst);
            return new BitString(dst);
        }

        /// <summary>
        /// Renders the content as a span of bits
        /// </summary>
        public Span<Bit32> ToBits()
        {
            Span<Bit32> dst = new Bit32[data.Length];
            for(var i=0; i< data.Length; i++)
                dst[i] = (Bit32)data[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public BitString Slice(int offset)
        {
            Span<byte> bits = data;
            return new BitString(bits.Slice(offset));
        }

        [MethodImpl(Inline)]
        public BitString Slice(int offset, int length)
        {
            Span<byte> bits = data;
            return new BitString(bits.Slice(offset,length));
        }

        /// <summary>
        /// Renders the content as a natural block of bits
        /// </summary>
        public NatSpan<N,Bit32> ToNatBits<N>(N n = default)
            where N : unmanaged, ITypeNat
        {
            var dst = NatSpan.alloc<N,Bit32>();
            for(var i=0; i< data.Length; i++)
                dst[i] = (Bit32)data[i];
            return dst;
        }

        /// <summary>
        /// Packs the bitsequence into a bytespan
        /// </summary>
        public Span<byte> ToPackedBytes()
            => PackedBits(data);

        /// <summary>
        /// Determines whether this bitstring represents the same value as another, ignoring
        /// leading zeroes
        /// </summary>
        /// <param name="rhs">The bitstring with which the comparison will be made</param>
        [MethodImpl(Inline)]
        public bool EqualsTrace(BitString rhs, Action<string> trace = null)
        {
            var x = Truncate(this.Length - this.Nlz());
            var y = rhs.Truncate(rhs.Length - rhs.Nlz());
            if(x.Length != y.Length)
            {
                trace?.Invoke($"The source length {x.Length} differs from the operand length {y.Length}");
                return false;
            }

            for(var i=0; i< x.Length; i++)
                if(x.data[i] != y.data[i])
                {
                    trace?.Invoke($"x[{i}] = {x.data[i]} != {y.data[i]} = y[{i}]");
                    return false;
                }
            return true;
        }

        /// <summary>
        /// Determines whether this bitstring represents the same value as another, ignoring
        /// leading zeroes
        /// </summary>
        /// <param name="rhs">The bitstring with which the comparison will be made</param>
        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
        {
            var x = Truncate(this.Length - this.Nlz());
            var y = rhs.Truncate(rhs.Length - rhs.Nlz());
            if(x.Length != y.Length)
            {
                return false;
            }

            for(var i=0; i< x.Length; i++)
                if(x.data[i] != y.data[i])
                {
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
            var minCount = Math.DivRem(data.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            Span<byte> src = data;
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
            if(data == null || data.Length == 0)
                return string.Empty;

            Span<char> dst = stackalloc char[data.Length];
            var lastix = dst.Length - 1;
            for(var i=0; i< dst.Length; i++)
                dst[lastix - i] = data[i] == 0 ? '0' : '1';

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
            if(blockWidth == null || blockWidth == 0)
                return FormatUnblocked(tlz,specifier);
            else
            {
                var sep = blocksep ?? ' ';
                var sb = new StringBuilder();
                var blocks = Partition(blockWidth.Value).Reverse();
                var lastix = blocks.Length - 1;
                var counter = 0;
                for(var i=0; i<=lastix; i++)
                {
                    sb.Append(blocks[i].FormatUnblocked(false,false));
                    if(i != lastix)
                    {
                        if(rowWidth != null && rowWidth != 0)
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

        public string Format(BitFormat? config = null)
        {
            var style = config ?? BitFormat.Default;
            var sep = style.BlockSep;
            var rowWidth = style.RowWidth;
            var specifier = style.SpecifierPrefix;
            var tlz = style.TrimLeadingZeros;

            if(style.BlockWidth == 0)
                return FormatUnblocked(style.TrimLeadingZeros, specifier);
            else
            {
                var blockWidth = style.BlockWidth;
                var sb = text.build();
                var blocks = Partition(blockWidth).Reverse();
                var lastix = blocks.Length - 1;
                var counter = 0;
                for(var i=0; i<=lastix; i++)
                {
                    sb.Append(blocks[i].FormatUnblocked(false,false));
                    if(i != lastix)
                    {
                        if(rowWidth != 0)
                        {
                            if(++counter % rowWidth == 0)
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
            => data.GetHashCode();

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
            var len = min((count == null ? (int)bitsize<T>() : count.Value), Length - offset);
            var bits = BitSeq.Slice(offset, len);
            return bits.Take<T>();
        }

        [MethodImpl(Inline)]
        readonly T PackOne<T>(int offset)
            where T : unmanaged
        {
            var src = data.ToReadOnlySpan();
            var packed = PackedBits(src, offset, bitsize<T>());
            return packed.Length != 0 ? packed.Singleton<byte,T>() : default;
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        static byte enable(byte src, int pos)
            =>  src |= (byte)(1 << pos);

        static Span<byte> PackedBits(ReadOnlySpan<byte> src, int offset = 0, int? minlen = null)
        {
            if(src.Length <= offset)
                return new byte[minlen ?? 1];

            var srcLen = (uint)(src.Length - offset);
            var dstLen = srcLen/8 + (srcLen % 8 == 0 ? 0 : 1);
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            Span<byte> dst = sys.alloc((int)dstLen);
            for(int i=0, j=0; j < dstLen; i+=8, j++)
            {
                ref var x = ref dst[j];
                for(var k=0; k<8; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < srcLen && src[srcIx] != 0)
                        x = enable(x, k);
                }
            }
            return dst;
        }

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

        /// <summary>
        /// Defines the canonical empty bitstring of 0 length
        /// </summary>
        public static BitString Empty
            => parse(string.Empty);
    }
}