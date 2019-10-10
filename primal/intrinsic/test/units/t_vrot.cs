//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vrot : IntrinsicTest<t_vrot>
    {

        public void vrotl_128x8_check()
        {
            vrotl_128_check<byte>();
        }

        public void vrotl_128x8_bench()
        {
            vrotl_128_bench<byte>();
        }

        public void vrotl_128x16_check()
        {
            vrotl_128_check<ushort>();
        }

        public void vrotl_128x16_bench()
        {
            vrotl_128_bench<ushort>();
        }

        public void vrotl_128x32_check()
        {
            vrotl_128_check<uint>();
        }

        public void vrotl_128x32_bench()
        {
            vrotl_128_bench<uint>();
        }

        public void vrotl_128x64_check()
        {
            vrotl_128_check<ulong>();
        }

        public void vrotl_128x64_bench()
        {
            vrotl_128_bench<ulong>();
        }

        public void vrotr_128x8_check()
        {
            vrotr_128_check<byte>();
        }

        public void vrotr_128x8_bench()
        {
            rotr_128_bench<byte>();
        }

        public void vrotr_128x16_check()
        {
            vrotr_128_check<ushort>();
        }

        public void vrotr_128x16_bench()
        {
            rotr_128_bench<ushort>();
        }

        public void vrotr_128x32_check()
        {
            vrotr_128_check<uint>();
        }

        public void vrotr_128x32_bench()
        {
            rotr_128_bench<uint>();
        }

        public void vrotr_128x64_check()
        {
            vrotr_128_check<ulong>();
        }

        public void vrotr_128x64_bench()
        {
            rotr_128_bench<ulong>();
        }

        public void vrotl_256x8_check()
        {
            vrotl_256_check<byte>();
        }

        public void vrotl_256x8_bench()
        {
            vrotl_256_bench<byte>();
        }

        public void vrotl_256x16_check()
        {
            vrotl_256_check<ushort>();
        }

        public void vrotl_256x16_bench()
        {
            vrotl_256_bench<ushort>();
        }

        public void vrotl_256x32_check()
        {
            vrotl_256_check<uint>();
        }

        public void vrotl_256x32_bench()
        {
            vrotl_256_bench<uint>();
        }

        public void vrotl_256x64_check()
        {
            vrotl_256_check<ulong>();
        }

        public void vrotl_256x64_bench()
        {
            vrotl_256_bench<ulong>();
        }

        public void vrotr_256x8_check()
        {
            vrotr_256_check<byte>();
        }

        public void vrotr_256x8_bench()
        {
            vrotr_256_bench<byte>();
        }

        public void vrotr_256x16_check()
        {
            vrotr_256_check<ushort>();
        }

        public void vrotr_256x16_bench()
        {
            vrotr_256_bench<ushort>();
        }

        public void vrotr_256x32_check()
        {
            vrotr_256_check<uint>();
        }

        public void vrotr_256x32_bench()
        {
            vrotr_256_bench<uint>();
        }

        public void vrotr_256x64_check()
        {
            vrotr_256_check<ulong>();
        }

        public void vrotr_256x64_bench()
        {
            vrotr_256_bench<ulong>();
        }

        public void vrotv_128x64_check()
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec128<ulong>();
                var offsets = Random.CpuVec128(closed(2ul, 30ul));
                
                var vL = dinx.rotl(src,offsets);
                var vRL = dinx.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = dinx.rotr(src,offsets);
                var vLR = dinx.rotl(vR,offsets);
                Claim.eq(src,vLR);


                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(Bits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(Bits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(Bits.rotl(vR[i], offsets[i]), vLR[i]);
                }        
            }
        }

        public void vrotv_256x64_check()
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec256<ulong>();
                var offsets = Random.CpuVec256(closed(2ul, 30ul));
                
                var vL = dinx.rotl(src,offsets);
                var vRL = dinx.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = dinx.rotr(src,offsets);
                var vLR = dinx.rotl(vR,offsets);
                Claim.eq(src,vLR);

                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(Bits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(Bits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(Bits.rotl(vR[i], offsets[i]), vLR[i]);
                }        
            }
        }

        void rot_256x8_check()
        {
            static void rotl_check(Vec256<byte> src, byte offset, Vec256<byte> computed)        
                => Claim.eq(bitspan.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vec256<byte> src, byte offset, Vec256<byte> computed)        
                => Claim.eq(bitspan.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<byte>();
                var offset = Random.Next(closed<byte>(2, 6));
                
                var vL = dinx.rotl(src,offset);                
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);

            }

        }


        void rot_256x16u()
        {
            static void rotl_check(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
                => Claim.eq(bitspan.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vec256<ushort> src, ushort offset, Vec256<ushort> computed)        
                => Claim.eq(bitspan.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<ushort>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.rotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        void rot_256x32u()
        {
            static void rotl_check(Vec256<uint> src, uint offset, Vec256<uint> computed)        
                => Claim.eq(bitspan.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vec256<uint> src, uint offset, Vec256<uint> computed)        
                => Claim.eq(bitspan.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<uint>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.rotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        void rot_256x64u()
        {
            static void rotl_check(Vec256<ulong> src, ulong offset, Vec256<ulong> computed)        
                => Claim.eq(bitspan.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vec256<ulong> src, ulong offset, Vec256<ulong> computed)        
                => Claim.eq(bitspan.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVec256<ulong>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.rotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.rotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }


        void rotv_256x32u()
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec256<uint>();
                var offsets = Random.CpuVec256(closed(2u, 30u));
                
                var vL = dinx.rotl(src,offsets);
                var vRL = dinx.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = dinx.rotr(src,offsets);
                var vLR = dinx.rotl(vR,offsets);
                Claim.eq(src,vLR);

                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(Bits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(Bits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(Bits.rotl(vR[i], offsets[i]), vLR[i]);
                }        
            }
        }

        void TraceRot(Vec256<uint> src, Vec256<uint> offsets)
        {
            var vL = dinx.rotl(src, offsets);
            var vX = dinx.rotr(vL, offsets);

            Trace("src", src.FormatHex(), 20);
            Trace("offsets", offsets.FormatHex(), 20);                
            Trace("rotl(src)", vL.FormatHex(), 20);
            Trace("rotr(rotl(src))", vX.FormatHex(), 20);
        }

        void rotv_128<T>(Interval<T> shiftRange)
            where T : unmanaged
        {
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVec128<T>();
                var offsets = Random.CpuVec128(shiftRange);
                
                var vL = gbits.rotl(src,offsets);
                var vRL = gbits.rotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = gbits.rotr(src,offsets);
                var vLR = gbits.rotl(vR,offsets);
                Claim.eq(src,vLR);


                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(gbits.rotl(src[i], offsets[i]), vL[i]);
                    Claim.eq(gbits.rotr(vL[i], offsets[i]), vRL[i]);
                    
                    Claim.eq(gbits.rotr(src[i], offsets[i]), vR[i]);
                    Claim.eq(gbits.rotl(vR[i], offsets[i]), vLR[i]);
                }        
            }
        }

        void vrotl_128_check<T>()
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVec128<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, convert<T>(offset)));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotl_128_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_128x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec128<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVec128<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotl(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void vrotl_256_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotl_256x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec256<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVec256<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotl(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void rotr_128_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotr_128x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec128<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVec128<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotr(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void vrotr_256_bench<T>()
            where T : unmanaged
        {
            var bz = bitsize<T>();
            var opname = $"rotr_256x{bz}";
            var sw = stopwatch();
            var opcount = RoundCount*CycleCount;
            var last = default(Vec256<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVec256<T>();
                var offset = Random.Next(offMin,offMax);
                sw.Start();
                last = ginx.vrotr(x,offset);
                sw.Stop();
            }
            Collect((opcount,sw,opname));
        }

        void vrotl_256_check<T>()
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVec256<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, convert<T>(offset)));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotr_128_check<T>()
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVec128<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, convert<T>(offset)));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        void vrotr_256_check<T>()
            where T : unmanaged
        {
            byte offMin = 2;
            byte offMax = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVec256<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, convert<T>(offset)));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

    }

}