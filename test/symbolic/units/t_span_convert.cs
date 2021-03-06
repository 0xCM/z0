//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    public sealed class t_span_convert : UnitTest<t_span_convert,NumericClaims,ICheckNumeric>
    {
        void VerifySpanBytesToValue<T>(Span<byte> src, T expect)
            where T : unmanaged
                => Claim.eq(expect, memory.first<T>(src));

        void VerifySpanBytesToValues<T>(Span<byte> src, Span<T> expect)
            where T : unmanaged
                => ClaimNumeric.eq(expect, memory.recover<T>(src));

        void VerifyBytesToValues<T>()
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var y = memory.bytes(x);
            VerifySpanBytesToValue(y,x);

            var valSize = Unsafe.SizeOf<T>();
            var values = Random.Stream<T>().ToSpan(Pow2.T08);
            var bytes = alloc<byte>(valSize*values.Length);
            for(int i = 0, offset = 0; i< values.Length; i++, offset += valSize)
            {
                var value = values[i];
                var valBytes = memory.bytes(value);
                valBytes.CopyTo(bytes, offset);
            }

            VerifySpanBytesToValues(bytes,values);
        }


        public void VerifyBytesToValues()
        {
            VerifyBytesToValues<sbyte>();
            VerifyBytesToValues<byte>();
            VerifyBytesToValues<short>();
            VerifyBytesToValues<ushort>();
            VerifyBytesToValues<long>();
            VerifyBytesToValues<ulong>();
            VerifyBytesToValues<float>();
            VerifyBytesToValues<double>();
        }

        public void VerifyReverse()
        {
            var src1 = Random.Span<byte>(23).ReadOnly();
            var src2 = Random.Span<byte>(24).ReadOnly();

            var rev1 = src1.Reverse();
            var rev2 = src2.Reverse();

            var lastix = src1.Length -1;
            for(var i=0; i<src1.Length; i++)
                Claim.eq(rev1[lastix - i], src1[i]);

            lastix = src2.Length -1;
            for(var i=0; i<src2.Length; i++)
                Claim.eq(rev2[lastix - i], src2[i]);
        }

        public void VerifyNonPrimal()
        {
            var bits = Random.BitStream32().ToSpan(Pow2.T08);
            var bytes = bits.AsUInt32();
            Claim.eq(bits.Length, bytes.Length);
            for(var i = 0; i<bits.Length; i++)
                Claim.eq((byte)bits[0], bytes[0]);
        }

        public void VerifySpanBytesToInt32()
        {
            var x = Random.Next<int>();
            var y = BitConverter.GetBytes(x);
            VerifySpanBytesToValue(y,x);

            var valSize = sizeof(int);
            var values = Random.Stream<int>().ToSpan(Pow2.T08);
            var bytes = memory.span<byte>(sizeof(int)*values.Length);
            for(int i = 0, offset = 0; i< values.Length; i++, offset += valSize)
            {
                var value = values[i];
                var valBytes = BitConverter.GetBytes(value).ToSpan();
                valBytes.CopyTo(bytes, offset);
            }

            VerifySpanBytesToValues(bytes,values);
        }

        public void VerifySpanBytesToInt64()
        {
            var x = Random.Next<long>();
            var y = BitConverter.GetBytes(x);
            VerifySpanBytesToValue(y,x);
        }

        #if BV

        public void VerifyBitCompression()
        {
            var x = Random.Next<ulong>();
            var bv = x.ToBitVector();
            var bits = span<Bit>(sizeof(ulong)*8);
            for(byte i=0; i< bits.Length; i++)
                bits[i] = bv[i];
            var bitBytes = Bits.pack(bits);
            var xBytes = ByteSpan.FromValue(x);
            Claim.eq(xBytes, bitBytes);

        }
        #endif
    }
}