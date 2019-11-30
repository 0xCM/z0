//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public abstract class IntrinsicTest<X> : UnitTest<X>
        where X : IntrinsicTest<X>
    {
        protected void vbc_check<T>(N128 n)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast(n,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);            
        }

        protected void vbc_check<T>(N256 n)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = ginx.vbroadcast(n,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);
        }

        protected void cmp_gt_check<T>(N128 n, T t = default)
            where T : unmanaged
        {
            var ones = ginx.vpones<T>(n);
            var one = vcell(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.gt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vgt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void cmp_gt_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            var ones = ginx.vpones<T>(n);
            var one = vcell(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.gt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vgt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void vnot_check<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);

                var actual = ginx.vnot(x);
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();
                var expect  = ginx.vload(n, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);
            }
        }

        protected void vnot_check<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var actual = ginx.vnot(x);
                
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();                
                var expect  = ginx.vload(n, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);

            }
        }
         
        protected void vlt_check<T>(N128 n)
            where T : unmanaged
        {
            var ones = ginx.vpones<T>(n);
            var one = vcell(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void vlt_check<T>(N256 n)
            where T : unmanaged
        {
            var ones = ginx.vpones<T>(n);
            var one = vcell(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void vor_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N128,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            
            vblock.or(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);
        }


        protected void vor_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            
            vblock.or(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);
        }
     
        protected void vor_check<T>(N128 n)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();
                
                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        protected void vor_check<T>(N256 n)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();

                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);
                
            }
        } 

        protected void vextract_check<T>(N128 n)
            where T : unmanaged
        {

            var len = vlength<T>(n);
            var src = Random.CpuVector<T>(n);
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.Store(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);
        }
            
        protected void vextract_check<T>(N256 n)
            where T : unmanaged
        {
            var len = vlength<T>(n);
            var half = len >> 1;
            var src = Random.CpuVector<T>(n);
            var srcData = src.Store(span<T>(len));
            
            var x0 = ginx.vlo(src);
            var y0 = x0.Store(span<T>(half));
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.vhi(src);
            var y1 = x1.Store(span<T>(half));
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

        }

        protected void vreverse_check<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N128))
                vreverse_check<T>(n128);
            else if(typeof(N) == typeof(N256))
                vreverse_check<T>(n256);
            else
                throw unsupported<N>();        
        }

        protected void vreverse_check<T>(N128 n)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var inc = ginx.vincrements<T>(n);
                var dec = ginx.vdecrements<T>(n);
                var y = ginx.vreverse(inc);
                Claim.eq(dec, y);
                Claim.eq(inc, ginx.vreverse(y));
            }
        }

        protected void vreverse_check<T>(N256 n)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var inc = ginx.vincrements<T>(n);
                var dec = ginx.vdecrements<T>(n);
                var y = ginx.vreverse(inc);
                Claim.eq(dec, y);
                Claim.eq(inc, ginx.vreverse(y));
            }
        }

        protected void vxor_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;

            var stats = VBlockStats.Calc<N256,T>(blocks);
            Claim.eq(n/bitsize<T>(), stats.BlockLength);

            var xb = Random.Blocks<T>(n, blocks);
            var yb = Random.Blocks<T>(n, blocks);
            var zb = DataBlocks.alloc<T>(n, blocks);
            
            vblock.xor(n, blocks, stats.BlockLength, in xb.Head, in yb.Head, ref zb.Head);
            
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);

            zb.Clear();
            vblock.xor(xb, yb, zb);

            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }

        protected void vxor_check<T>(N128 n)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var bX = Random.Blocks<T>(n);
                var bY = Random.Blocks<T>(n);
                var vX = bX.LoadVector();
                var vY = bY.LoadVector();
                
                var bExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< bExpect.CellCount; i++)
                    bExpect[i] = gmath.xor(bX[i], bY[i]);
                
                var vExpect = bExpect.LoadVector();
                var vActual = ginx.vxor(vX,vY);
                Claim.eq(vExpect,vActual);
            }
        }

        protected void vxor_check<T>(N256 n)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var bX = Random.Blocks<T>(n);
                var bY = Random.Blocks<T>(n);
                var vX = bX.LoadVector();
                var vY = bY.LoadVector();

                var bExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< bExpect.CellCount; i++)
                    bExpect[i] = gmath.xor(bX[i], bY[i]);
                
                var vExpect = bExpect.LoadVector();
                var vActual = ginx.vxor(vX,vY);
                Claim.eq(vExpect,vActual);
                
            }
        } 

        protected void vxor_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N128,T>(blocks);

            var xb = Random.Blocks<T>(n, blocks);
            var yb = Random.Blocks<T>(n, blocks);
            var zb = DataBlocks.alloc<T>(n, blocks);
            vblock.xor(n, blocks, stats.BlockLength, in xb.Head, in yb.Head, ref zb.Head);

            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
            
            zb.Clear();
            vblock.xor(xb, yb, zb);
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }

        protected void xor_gmath_bench<T>(N256 n, SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_gmath_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(n);
            var xb = Random.Blocks<T>(n,blocks);
            var yb = Random.Blocks<T>(n,blocks);
            var zb = DataBlocks.alloc<T>(n,blocks);
            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
            {                
                for(var block = 0; block< blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    zb.Block(block)[cell] = gmath.xor(xb.Block(block)[cell], yb.Block(block)[cell]);                                    
            }
            counter.Stop();
            Benchmark(opname, counter,opcount);
        }

        protected void xor_intrinsic_bench<T>(N256 n, SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_ginx_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(n);
            var xb = Random.Blocks<T>(n,blocks);
            var yb = Random.Blocks<T>(n,blocks);
            var zb = DataBlocks.alloc<T>(n,blocks);
            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
                vblock.xor(xb, yb, zb);
            counter.Stop();
            Benchmark(opname, counter,opcount);

        }

        protected void vxor_bench<T>(N256 n)
            where T : unmanaged
        {
            xor_gmath_bench<T>(n);
            xor_intrinsic_bench<T>(n);
        }

        protected void vtestz_check<T>(N128 n = default)
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n128);
                var xbs = x.ToBitString();
                var ybs = BitString.alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = Bit.On;

                var y = ybs.ToCpuVector<T>(n128);

                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

        protected void vtestz_check<T>(N256 n = default)
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n256);
                var xbs = x.ToBitString();
                var ybs = BitString.alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = Bit.On;

                var y = ybs.ToCpuVector<T>(n256);

                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

    }

}