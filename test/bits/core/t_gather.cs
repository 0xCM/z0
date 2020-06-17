//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public class t_gather : t_bitcore<t_gather>
    {            
        public void gather_masks()
        {

            var m2 = BitMasks.Lsb32x8x1;
            var x2 = Bits.gather(UInt32.MaxValue, m2);
            var y2 = Bits.scatter(x2, m2).ToBitVector();
            var bv = m2.ToBitVector();
            Claim.eq(y2.Scalar,bv.Scalar);
            
            for(var i=0; i<y2.Width; i++)
                Claim.eq(y2[i], i % 8 == 0 ? bit.On : bit.Off);
        }

        public void gather_8()
            => gather_check<byte>();

        public void gather_16()
            => gather_check<ushort>();

        public void gather_32()
            => gather_check<uint>();

        public void gather_64()
            => gather_check<ulong>();        

        void gather_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = gather(src,mask);
                var s2 = gbits.gather(src,mask);
                Claim.eq(s1,s2);
            }
        }

        /// <summary>
        /// Collects mask-identified source bits that are deposited to contiguous low bits in a target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static T gather<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(gather(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(gather(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(gather(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(gather(uint64(src), uint64(mask)));
            else            
                throw Unsupported.define<T>();
        }           

        /// <summary>
        /// Collects mask-identified source bits that are deposited to
        /// contiguous low bits in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">The mask that identifies the bits to gather</param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static byte gather(byte src, byte mask)
        {
            var dst = (byte)0;
            var x = (byte)1;
            while (mask != 0)
            {
                byte i = (byte)(mask & math.negate(mask));
                mask ^= i;
                dst += (byte)((i & src) != 0 ? x : 0);
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Collects mask-identified source bits that are deposited to
        /// contiguous low bits in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">The mask that identifies the bits to gather</param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static ushort gather(ushort src, ushort mask)
        {
            var dst = (ushort)0;
            var x = (ushort)1;
            while (mask != 0)
            {
                ushort i = (ushort)(mask & math.negate(mask));
                mask ^= i;
                dst += (ushort)((i & src) != 0 ? x : 0);
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Collects mask-identified source bits that are deposited to
        /// contiguous low bits in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">The mask that identifies the bits to gather</param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static uint gather(uint src, uint mask)
        {
            var dst = 0u;
            var x = 1u;
            while (mask != 0)
            {
                var i = mask & math.negate(mask);
                mask ^= i;
                dst += ((i & src) != 0 ? x : 0);
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Collects mask-identified source bits that are deposited to
        /// contiguous low bits in the target
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">The mask that identifies the bits to gather</param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static ulong gather(ulong src, ulong mask)
        {
            var dst = 0ul;
            var x = 1ul;
            while (mask != 0)
            {
                var i = mask & math.negate(mask);
                mask ^= i;
                dst += ((i & src) != 0 ? x : 0);
                x <<= 1;
            }
            return dst;
        }
    }
}