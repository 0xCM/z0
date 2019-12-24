//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static As;

    using static zfunc;

    public abstract class t_sb<X> : UnitTest<X>
        where X : t_sb<X>, new()
    {
        protected override int SampleCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline)]
        static T scatter<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(scatter(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(scatter(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(scatter(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(scatter(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static byte scatter(byte src, byte mask)
        {
            var dst = (byte)0;
            var x = (byte)1;
            while (mask != 0)
            {
                byte i =  (byte)(mask & math.negate(mask));
                mask ^= i;
                dst += (byte)(((x & src) != 0 ? i : 0));
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static uint scatter(uint src, uint mask)
        {
            var dst = 0u;
            var x = 1u;
            while (mask != 0)
            {
                var i = mask & math.negate(mask);
                mask ^= i;
                dst += ((x & src) != 0 ? i : 0);
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static ushort scatter(ushort src, ushort mask)
        {
            var dst = (ushort)0;
            var x = (ushort)1;
            while (mask != 0)
            {
                ushort i =  (ushort)(mask & math.negate(mask));
                mask ^= i;
                dst += (ushort)(((x & src) != 0 ? i : 0));
                x <<= 1;
            }
            return dst;
        }

        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mask"></param>
        /// <remark>Algorithm adapted from Arndt, Matters Computational </remark>
        static ulong scatter(ulong src, ulong mask)
        {
            var dst = 0ul;
            var x = 1ul;
            while (mask != 0)
            {
                var i = mask & math.negate(mask);
                mask ^= i;
                dst += ((x & src) != 0 ? i : 0);
                x <<= 1;
            }
            return dst;
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
                throw unsupported<T>();
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

        /// <summary>
        /// Generic scalar bit scatter check
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void sb_scatter_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = scatter(src,mask);
                var s2 = gbits.scatter(src,mask);
                Claim.eq(s1,s2);
            }
        }


       protected void sb_gather_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = gather(src,mask);
                var s2 = gbits.gather(src,mask);
                Claim.eq(s1,s2);
            }
        }

        /// <summary>
        /// Generic scalar bit left rotation check
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void sb_rotl_check<T>(T t = default)
            where T : unmanaged
        {
            var offset = Random.Next(1, bitsize<T>());
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.Next<T>();                
                var y = BitString.scalar(x);
                Claim.eq(x, y.TakeScalar<T>());
                
                x = gbits.rotl(x, offset);
                y = y.RotL(offset);
                
                var z = y.TakeScalar<T>();
                Claim.eq(x,z);
            }
        }

        protected void sb_bitview_check<T>(T t = default)
            where T : unmanaged
        {
            var src = gmath.maxval<T>();
            var view = BitView.Over(ref src);
            var bytecount = size<T>();

            for(var i=0; i<bytecount; i++)
            for(byte j=0; j<8; j++)
                view[i,j] = j % 2 == 0;
            
            var bs = BitString.scalar(src);
            for(var i=0; i< bytecount*8; i++)
                Claim.yea(bs[i] == (i%2 == 0));
        }

       protected void sb_unpack_check<S,T>()
            where S : unmanaged
            where T : unmanaged
        {
            for(var j=0; j< SampleCount; j++)
            {
                var src = Random.Next<S>();
                Span<T> dst = new T[bitsize<S>()];   
                gbits.unpack(src,dst);                     
                var bs = BitString.scalar(src);
                for(var i = 0; i< bs.Length; i++)
                {
                    var expect = bs[i] ? one<T>() : zero<T>();
                    var actual = dst[i];
                    Claim.eq(expect,actual);
                }
            }

            var x = Random.Span<S>(SampleCount);
            Span<T> y1 = new T[x.Length * bitsize<S>()];
            gbits.unpack(x,y1);
            var y2 = BitString.scalars(x);
            for(var i=0; i< y1.Length; i++)
            {
                var expect = y2[i] ? one<T>() : zero<T>();
                var actual = y1[i];
                Claim.yea(gmath.eq(expect,actual));
            }
        }

        protected void sb_bitrev_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)            
            {
                var src = Random.Next<T>();
                var r1 = gbits.rev(src);
                var r2 = BitString.scalar(src).Reverse().TakeScalar<T>();
                Claim.eq(r1,r2);
            }
        }

        /// <summary>
        /// Verifies even/odd bit-level interspersal
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        protected void sb_mix_check<T>(T t = default)
            where T : unmanaged
        {
            var len = bitsize<T>();

            for(var i=0; i<SampleCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();

                // odd a/b interspersal
                var abOdd = BitString.scalar(gbits.mix(n1,a,b));

                // even a/b interspersal
                var abEven = BitString.scalar(gbits.mix(n0,a,b));

                // even/odd bits for a/b via bitstring
                var bsaEven = BitString.scalar(a).Even();
                var bsaOdd = BitString.scalar(a).Odd();
                var bsbEven = BitString.scalar(b).Even();
                var bsbOdd = BitString.scalar(b).Odd();
                
                // bitstring reference interspersal for the even bits
                var bsEven = bsaEven.Intersperse(bsbEven);                
                Claim.eq(bsEven, abEven);

                // bitstring reference interspersal for the odd bits
                var bsOdd = bsaOdd.Intersperse(bsbOdd);
                Claim.eq(bsOdd, abOdd);                                
            }
        }

        protected void sb_cnonimpl_check<T>(T t = default)
            where T : unmanaged
        {
            var vZero = vzero<T>(n128);
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.Next<T>();                    
                var y = Random.Next<T>();                    
                var z1 = gmath.cnonimpl(x, y);
                var z2 = gmath.and(x,gmath.not(y));
                Claim.eq(z1,z2);
            }
        }

        protected void sb_msbpos_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<T>();
                var xpos = gbits.msbpos(x);
                Claim.lt(xpos, (int)bitsize<T>());
                
                var xcount = gbits.nlz(x);
                var bs = BitString.scalar(x);
                var bscount = bs.Nlz();
                Claim.eq(xcount, bscount);
                
                var bspos = bs.Length - 1 - bscount;
                Claim.eq(xpos,bspos);
            }
        }

        protected void sb_ntz_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<T>();
                var ntzX = gbits.ntz(x);
                var y = BitString.scalar(x);
                var ntzY = y.Ntz();

                if(ntzX != ntzY)
                {
                    Trace("scalar", x.ToString());
                    Trace("bitstring", y.Format());
                }

                Claim.eq(ntzX, ntzY);
            }
        }

        protected void sb_lsbx_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next<T>();
                var x = gbits.lsbx(src);
                var y = gmath.and(src, gmath.negate(src));
                Claim.eq(x,y);
            }
        }

        protected void sb_bitchars_check<T>(T t = default)
            where T : unmanaged
        {
            Span<char> s0 = stackalloc char[bitsize<T>()];
            ReadOnlySpan<char> s1 = default;
            for(var i=0; i<SampleCount; i++)
            {
                var a = Random.Next<T>();
                gbits.bitchars(a,s0);
                s1 = gbits.bitchars(a);
                Claim.eq(s0, s1);

                s0.Reverse();
                var textA = s0.Format();
                var textB = BitString.scalar(a).Format();
                Claim.eq(textA, textB);
            }
        }

        protected void sb_bitseq_check<T>(T t = default)
            where T : unmanaged
        {
            Span<byte> s0 = stackalloc byte[bitsize<T>()];
            Span<byte> s1 = stackalloc byte[bitsize<T>()];
            ReadOnlySpan<byte> s2 = default;
            for(var i=0; i<SampleCount; i++)
            {
                var a = Random.Next<T>();
                gbits.bitseq(a,s0);
                gbits.bitseq(a,s1);
                s2 = gbits.bitseq(a);
                Claim.eq(s0, s1);
                Claim.eq(s1, s2);
            }
        }

        protected void sb_zerohi_check<T>(T t = default)
            where T : unmanaged
        {
            var width = bitsize<T>();
            for(var i=0; i< width; i++)
                sb_zerohi_check<T>(i);            
        }

        protected void sb_zerohi_check<T>(int maxlen, T t = default)
            where T : unmanaged
        {
            var width = bitsize<T>();

            var bs0 = BitString.scalar(gmath.maxval<T>());
            var bv0 = bs0.ToBitVector<T>();

            Claim.eq(width, bs0.PopCount());
            Claim.eq(width, bs0.Length);

            Claim.eq(width, BitVector.pop(bv0));
            
            var bs1 = bs0.Truncate(maxlen);
            Claim.eq(maxlen, bs1.PopCount());
            Claim.eq(maxlen, bs1.Length);

            var bv1 = gbits.zerohi(bv0.Scalar, maxlen);
            Claim.eq(maxlen, gbits.pop(bv1));

            var bs2 = bs1.Pad(width);
            Claim.eq(width, bs2.Length);
            Claim.eq(maxlen, bs2.PopCount());

            for(var i= 0; i< SampleCount; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2, width - width/2);
                var y = gbits.zerohi(x, (int)j);

                var x0 = gbits.segment(x,0,j - 1);
                var y0 = gbits.segment(y,0,j - 1);
                var y1 = gbits.segment(y,j, width - 1);
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonzero(y1));                        
            }
        }

        protected void sb_lsboff_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.Next<T>();
                var y0 = gbits.lsboff(x);
                var y1 = gmath.and(gmath.sub(x, gmath.one<T>()), x);
                Claim.eq(y0,y1);
            }
        }

       protected void sb_toggle_check<T>(T t = default)
            where T : unmanaged
        {
            var src = Random.Span<T>(SampleCount);
            var tLen = bitsize<T>();
            var srcLen = src.Length;
            for(var i = 0; i< srcLen; i++)
            {
                var x = src[i];
                for(byte j =0; j< tLen; j++)
                {
                    var before = gbits.test(x, j);
                    x = BitMask.toggle(x, j);
                    var after = gbits.test(x, j);
                    Claim.neq(before, after);
                    x = BitMask.toggle(x, j);
                    Claim.eq(x, src[i]);
                }
            }
        }

        protected void bs_rep_check<T>()
            where T : unmanaged
        {
            var src = Random.Span<T>(SampleCount);
            for(var i=0; i<src.Length; i++)
            {
                var x = src[i];
                var bs = BitString.scalar(src[i]);
                var y = bs.TakeScalar<T>();
                Claim.eq(x,y);
                Claim.eq(bs.Format(), BitString.scalar(y).Format());
            }
        }

        protected void bs_fromscalar_check<T>(T t = default)
            where T : unmanaged
        {
            var src = Random.Span<T>(SampleCount);
            for(var i=0; i<src.Length; i++)
            {
                var bc1 =  BitString.scalar(src[i]).Format();
                var bc3 = BitString.scalar(src[i]);
                Claim.eq(bc1,bc3);
            }
        }
        
        protected void sb_width_check<T>(T t = default)
            where T : unmanaged
        {
            for(var sample = 0; sample < SampleCount; sample++)
            {
                var x = Random.Next<T>();
                var actual = gbits.width(x);
                var expect = bitsize<T>() - gbits.nlz(x);
                Claim.eq(expect, actual);

            }
        }


        protected void sb_himask_check<T>(T t = default)
            where T : unmanaged
        {
            var mincount = 1;
            var maxcount = bitsize<T>();
            for(var i=0; i< SampleCount; i++)
            {
                var count = Random.Single(mincount,maxcount);
                var mask = BitMask.hi(count,t);                
                var pop = gbits.pop(mask);
                if(pop != count)
                {
                    Trace("count", count.ToString());
                    Trace("popcount", pop.ToString());
                    Trace("mask", BitString.scalar(mask).Format());
                }
                
                Claim.eq(count, gbits.pop(mask));

                var lowered = gmath.srl(mask, bitsize(t) -  count);
                var width = gbits.width(lowered);
                if(count != width)
                {
                    Trace("mask", BitString.scalar(mask).Format());
                    Trace("lowered", BitString.scalar(lowered).Format());
                }
                Claim.eq(count, width);
            }
        }

        protected void sb_unpack_bench<S,T>(SystemCounter counter = default)
            where S : unmanaged
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var srcSign = signed<S>() ? "i" : string.Empty;
            var dstSign = signed<T>() ? "i" : string.Empty;            
            var opname = $"unpack_{bitsize<S>()}{srcSign}x{bitsize<T>()}{dstSign}";

            Span<T> dst = new T[bitsize<S>()];   

            for(var i=0; i<opcount; i++)
            {
                var src = Random.Next<S>();
                counter.Start();
                gbits.unpack(src,dst);
                counter.Stop();
            }

            ReportBenchmark(opname,opcount,counter);
        }
    }
}