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
        protected void gsb_scatter_check<T>()
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

        /// <summary>
        /// Generic scalar bit left rotation check
        /// </summary>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void gsb_rotl_check<T>()
            where T : unmanaged
        {
            var offset = Random.Next(1, bitsize<T>());
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();                
                var bsx = BitString.from(x);
                var bsxRef = bsx.Replicate();
                Claim.eq(x,bsx.TakeScalar<T>());
                x = gbits.rotl(x, offset);
                bsx.RotL(offset);
                
                var y = bsx.TakeScalar<T>();
                Claim.eq(x,y);
            }
        }

       protected void gsb_clear_check<T>()
            where T : unmanaged
        {
            var width = (int)bitsize<T>();
            var p0 = Random.Next(2, width/2 - 1);
            var p1 = Random.Next(width/2 + 1, width - 2);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = BitString.from(gbits.clear(x, p0,p1));
                var z = BitString.from(x).Clear(p0,p1);
                Claim.eq(y,z);            
            }
        }

        protected void gsb_bitview_check<T>()
            where T : unmanaged
        {
            var src = gmath.maxval<T>();
            var view = BitView.Over(ref src);
            var bytecount = size<T>();

            for(var i=0; i<bytecount; i++)
            for(byte j=0; j<8; j++)
                view[i,j] = j % 2 == 0;
            
            var bs = BitString.from(src);
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
                var bs = BitString.from(src);
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

    }

}