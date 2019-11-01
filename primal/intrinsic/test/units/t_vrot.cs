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
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vrot : IntrinsicTest<t_vrot>
    {

        public void rotrx_check()
        {
            var x = ginx.vunits<byte>(n128);            
            var y = ginx.vrotrx(x, 8);
            var z = ginx.vrotr(x, 8);
            Claim.eq(y,z);

        }


        public void rotlx_check()
        {
            var x = ginx.vunits<byte>(n128);
            var y = ginx.vrotlx(x, 8);
            var z = ginx.vrotl(x, 8);
            Claim.eq(y,z);
        }


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
            var n = n128;
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVector<ulong>(n);
                var offsets = Random.CpuVector(n,closed(2ul, 30ul));
                
                var vL = dinx.vrotl(src,offsets);
                var vRL = dinx.vrotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offsets);
                var vLR = dinx.vrotl(vR,offsets);
                Claim.eq(src,vLR);


                var srcSpan = src.ToSpan();
                var offSpan = offsets.ToSpan();
                var vRSpan = vR.ToSpan();
                var vLSpan = vL.ToSpan();
                var vRLSpan = vRL.ToSpan();
                var vLRSpan = vLR.ToSpan();

                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(srcSpan[i], offSpan[i]), vLSpan[i]);
                    Claim.eq(Bits.rotr(vLSpan[i], offSpan[i]), vRLSpan[i]);
                    
                    Claim.eq(Bits.rotr(srcSpan[i], offSpan[i]), vRSpan[i]);
                    Claim.eq(Bits.rotl(vRSpan[i], offSpan[i]), vLRSpan[i]);
                }        
            }
        }

        public void vrotv_256x64_check()
        {
            var n = n256;
            for(var sample=0; sample < SampleSize; sample++)
            {
                var src = Random.CpuVector<ulong>(n);
                var offsets = Random.CpuVector(n,closed(2ul, 30ul));
                
                var vL = dinx.vrotl(src,offsets);
                var vRL = dinx.vrotr(vL,offsets);
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offsets);
                var vLR = dinx.vrotl(vR,offsets);
                Claim.eq(src,vLR);


                var srcSpan = src.ToSpan();
                var offSpan = offsets.ToSpan();
                var vRSpan = vR.ToSpan();
                var vLSpan = vL.ToSpan();
                var vRLSpan = vRL.ToSpan();
                var vLRSpan = vLR.ToSpan();

                for(var i=0; i<src.Length(); i++)
                {
                    Claim.eq(Bits.rotl(srcSpan[i], offSpan[i]), vLSpan[i]);
                    Claim.eq(Bits.rotr(vLSpan[i], offSpan[i]), vRLSpan[i]);
                    
                    Claim.eq(Bits.rotr(srcSpan[i], offSpan[i]), vRSpan[i]);
                    Claim.eq(Bits.rotl(vRSpan[i], offSpan[i]), vLRSpan[i]);
                }        
            }
        }

        void rot_256x8_check()
        {
            static void rotl_check(Vector256<byte> src, byte offset, Vector256<byte> computed)        
                => Claim.eq(BitRot.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vector256<byte> src, byte offset, Vector256<byte> computed)        
                => Claim.eq(BitRot.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector256<byte>();
                var offset = Random.Next(closed<byte>(2, 6));
                
                var vL = dinx.vrotl(src,offset);                
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.vrotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);

            }

        }


        void rot_256x16u()
        {
            static void rotl_check(Vector256<ushort> src, ushort offset, Vector256<ushort> computed)        
                => Claim.eq(BitRot.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vector256<ushort> src, ushort offset, Vector256<ushort> computed)        
                => Claim.eq(BitRot.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector256<ushort>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.vrotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.vrotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        void rot_256x32u()
        {
            static void rotl_check(Vector256<uint> src, uint offset, Vector256<uint> computed)        
                => Claim.eq(BitRot.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vector256<uint> src, uint offset, Vector256<uint> computed)        
                => Claim.eq(BitRot.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector256<uint>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.vrotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.vrotl(vR,offset);
                Claim.eq(src,vLR);

                rotl_check(src, offset, vL);
                rotr_check(vL, offset, vRL);
                rotr_check(src, offset, vR);
                rotl_check(vR, offset, vLR);
            }
        }

        void rot_256x64u()
        {
            static void rotl_check(Vector256<ulong> src, ulong offset, Vector256<ulong> computed)        
                => Claim.eq(BitRot.rotl(src.ToSpan(), offset), computed.ToSpan());

            static void rotr_check(Vector256<ulong> src, ulong offset, Vector256<ulong> computed)        
                => Claim.eq(BitRot.rotr(src.ToSpan(), offset), computed.ToSpan());

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector256<ulong>();
                var offset = Random.Next(closed<byte>(2, 14));
                
                var vL = dinx.vrotl(src,offset);
                var vRL = dinx.vrotr(vL,offset);                
                Claim.eq(src,vRL);
                
                var vR = dinx.vrotr(src,offset);
                var vLR = dinx.vrotl(vR,offset);
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
                var vSrc = Random.CpuVector256<uint>();
                var src = vSrc.ToSpan();

                var vOffsets = Random.CpuVector256(closed(2u, 30u));
                var offsets = vOffsets.ToSpan();
                
                var vL = dinx.vrotl(vSrc,vOffsets);
                var left = vL.ToSpan();
                
                var vRL = dinx.vrotr(vL,vOffsets);
                var lrl = vRL.ToSpan();
                
                Claim.eq(vSrc,vRL);
                
                var vR = dinx.vrotr(vSrc,vOffsets);
                var right = vR.ToSpan();

                var vLR = dinx.vrotl(vR,vOffsets);
                var rlr = vLR.ToSpan();
                Claim.eq(vSrc,vLR);
                

                for(var i=0; i<vSrc.Length(); i++)
                {
                    Claim.eq(Bits.rotl(src[i], offsets[i]), left[i]);
                    Claim.eq(Bits.rotr(left[i], offsets[i]), lrl[i]);
                    
                    Claim.eq(Bits.rotr(src[i], offsets[i]), right[i]);
                    Claim.eq(Bits.rotl(right[i], offsets[i]), rlr[i]);
                }        
            }
        }



        void vrotl_128_check<T>()
            where T : unmanaged
        {
            var offMin = 2;
            var offMax = bitsize<T>() - 2;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector128<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,(byte)offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, offset));
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
                var x = Random.CpuVector128<T>();
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
                var x = Random.CpuVector256<T>();
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
            var last = default(Vector128<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector128<T>();
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
            var last = default(Vector256<T>);

            byte offMin = 2;
            byte offMax = (byte)(bz - 2);
            
            for(var rep=0; rep < opcount; rep++)
            {
                var x = Random.CpuVector256<T>();
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
                var x = Random.CpuVector256<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotl(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, (int)offset));
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
                var x = Random.CpuVector128<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, (int)offset));
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
                var x = Random.CpuVector256<T>();
                var offset = Random.Next(offMin,offMax);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, (int)offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

    }

}