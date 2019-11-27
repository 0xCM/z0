//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class t_sb<X> : t_bits<X>
        where X : t_sb<X>, new()
    {
        protected override int SampleSize => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        /// <summary>
        /// Generic scalar bit scatter check
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void sb_scatter_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = BitRef.scatter(src,mask);
                var s2 = gbits.scatter(src,mask);
                Claim.eq(s1,s2);
            }
        }

       protected void sb_gather_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = BitRef.gather(src,mask);
                var s2 = gbits.gather(src,mask);
                Claim.eq(s1,s2);
            }
        }

        /// <summary>
        /// Generic scalar bit left rotation check
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void sb_rotl_check<T>()
            where T : unmanaged
        {
            var offset = Random.Next(1, bitsize<T>());
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                
                var bsx = BitString.scalar(x);
                var bsxRef = bsx.Replicate();
                Claim.eq(x,bsx.TakeScalar<T>());
                x = gbits.rotl(x, offset);
                bsx.RotL(offset);
                
                var y = bsx.TakeScalar<T>();
                Claim.eq(x,y);
            }
        }

       protected void sb_clear_check<T>()
            where T : unmanaged
        {
            var width = (int)bitsize<T>();
            var p0 = Random.Next(2, width/2 - 1);
            var p1 = Random.Next(width/2 + 1, width - 2);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = BitString.scalar(gbits.clear(x, p0,p1));
                var z = BitString.scalar(x).Clear(p0,p1);
                Claim.eq(y,z);            
            }
        }

        protected void sb_bitview_check<T>()
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
            for(var j=0; j< SampleSize; j++)
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

            var x = Random.Span<S>(SampleSize);
            Span<T> y1 = new T[x.Length * bitsize<S>()];
            gbits.unpack(x,y1);
            var y2 = BitString.from(x);
            for(var i=0; i< y1.Length; i++)
            {
                var expect = y2[i] ? one<T>() : zero<T>();
                var actual = y1[i];
                Claim.yea(gmath.eq(expect,actual));
            }
        }

        protected void sb_unpack_bench<S,T>()
            where S : unmanaged
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var srcSign = signed<S>() ? "i" : string.Empty;
            var dstSign = signed<T>() ? "i" : string.Empty;            
            var opname = $"unpack_{bitsize<S>()}{srcSign}x{bitsize<T>()}{dstSign}";
            var sw = stopwatch(false);

            Span<T> dst = new T[bitsize<S>()];   

            for(var i=0; i<opcount; i++)
            {
                var src = Random.Next<S>();
                sw.Start();
                gbits.unpack(src,dst);
                sw.Stop();
            }

            Collect((opcount,sw,opname));
        }

        protected void sb_bitrev_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)            
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
        protected void sb_mix_check<T>()
            where T : unmanaged
        {
            var len = bitsize<T>();

            for(var i=0; i<SampleSize; i++)
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

        protected void sb_cnonimpl_check<T>()
            where T : unmanaged
        {
            var vZero = vzero<T>(n128);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                    
                var y = Random.Next<T>();                    
                var z1 = gmath.cnonimpl(x, y);
                var z2 = gmath.and(x,gmath.not(y));
                Claim.eq(z1,z2);
            }
        }

        protected void sb_msbpos_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var xpos = gbits.msbpos(x);
                var xcount = gbits.nlz(x);
                var bs = BitString.scalar(x);
                var bscount = bs.Nlz();
                Claim.eq(xcount, bscount);
                var bspos = bs.Length - 1 - bscount;
                Claim.eq(xpos,bspos);
            }
        }

        protected void sb_lsbpos_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var xpos = gbits.lsbpos(x);
                var xcount = gbits.ntz(x);
                var bs = BitString.scalar(x);
                var bscount = bs.Ntz();
                Claim.eq(xcount, bscount);
                var bspos = bscount;
                Claim.eq(xpos,bspos);
            }
        }

        protected void sb_blsi_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var x = gbits.blsi(src);
                var y = gmath.and(src,gmath.negate(src));
                Claim.eq(x,y);
            }
        }

        protected void bitchars_check<T>()
            where T : unmanaged
        {
            Span<char> s0 = stackalloc char[bitsize<T>()];
            ReadOnlySpan<char> s1 = default;
            for(var i=0; i<SampleSize; i++)
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

        protected void bitseq_check<T>()
            where T : unmanaged
        {
            Span<byte> s0 = stackalloc byte[bitsize<T>()];
            Span<byte> s1 = stackalloc byte[bitsize<T>()];
            ReadOnlySpan<byte> s2 = default;
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<T>();
                gbits.bitseq(a,s0);
                gbits.bitseq(a,s1);
                s2 = gbits.bitseq(a);
                Claim.eq(s0, s1);
                Claim.eq(s1, s2);
            }
        }

        protected void bzhi_check<T>()
            where T : unmanaged
        {
            var width = bitsize<T>();
            for(var i=0; i< width; i++)
                bzhi_check<T>(i);            
        }

        protected void bzhi_check<T>(int maxlen)
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

            for(var i= 0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2u, width - width/2);
                var y = gbits.zerohi(x, (int)j);

                var x0 = gbits.range(x,0,j - 1);
                var y0 = gbits.range(y,0,j - 1);
                var y1 = gbits.range(y,j, width - 1);
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonzero(y1));                        
            }
        }

        protected void sb_blsr_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y0 = gbits.blsr(x);
                var y1 = gmath.and(gmath.sub(x, gmath.one<T>()), x);
                Claim.eq(y0,y1);
            }
        }

    }
}