//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Base type for vectorized intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_vinx<X> : t_inx<X>
        where X : t_vinx<X>
    {
        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vector128UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            
            var src = random.Blocks<T>(n128,blocks).ReadOnly();
            var blocklen = src.BlockLength;
            Claim.eq(blocks*blocklen,src.CellCount);
                        
            var expect = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = ginx.vload<T>(n128, in head(tmp));
             
                var vX = src.LoadVector(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vector256UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            
            var src = random.Blocks<T>(n256,blocks).ReadOnly();
            var blocklen = src.BlockLength;                     

            Claim.eq(blocks*blocklen,src.CellCount);
                        
            var expect = DataBlocks.alloc<T>(n256, blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = ginx.vload<T>(n256, in head(tmp));
             
                var vX = src.LoadVector(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector128BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {
            
            var lhs = random.Blocks<T>(n128,blocks).ReadOnly();
            var blocklen = lhs.BlockLength;
            Claim.eq(blocks*blocklen,lhs.CellCount);
            
            var rhs = random.Blocks<T>(n128,blocks).ReadOnly();
            Claim.eq(blocks*blocklen,rhs.CellCount);
            
            var expect = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vload(in head(tmp), out Vector128<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector256BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {                    
            var lhs = random.Blocks<T>(n256, blocks).ReadOnly();
            var blocklen = lhs.BlockLength;                     
            Claim.eq(blocks*blocklen,lhs.CellCount);
            
            var rhs = random.Blocks<T>(n256,blocks).ReadOnly();
            Claim.eq(blocks*blocklen,rhs.CellCount);
            
            var expect = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vload(in head(tmp), out Vector256<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }

        protected void vbroadcast_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = vbuild.broadcast(w,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);            
        }

        protected void vbroadcast_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var x = Random.Next<T>();
            var vX = vbuild.broadcast(w,x);
            var data = vX.ToSpan();
            for(var i=0; i<data.Length; i++)
                Claim.eq(x,data[i]);
        }

        protected void cmp_gt_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var one = vcell(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(w);
                var y = Random.Blocks<T>(w);
                var z = DataBlocks.single<T>(w);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.gt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vload(w, in head(z));
                var actual = ginx.vgt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void cmp_gt_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var one = vcell(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(w);
                var y = Random.Blocks<T>(w);
                var z = DataBlocks.single<T>(w);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.gt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vload(w, in head(z));
                var actual = ginx.vgt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       
            }
        }

        protected void vnot_check<T>(N128 w = default, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);

                var actual = ginx.vnot(x);
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();
                var expect  = ginx.vload(w, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);
            }
        }

        protected void vnot_check<T>(N256 w = default, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var actual = ginx.vnot(x);
                
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();                
                var expect  = ginx.vload(w, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);
            }
        }
         
        protected void vlt_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var one = vcell(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(w);
                var y = Random.Blocks<T>(w);
                var z = DataBlocks.single<T>(w);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vload(w, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        protected void vlt_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var one = vcell(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(w);
                var y = Random.Blocks<T>(w);
                var z = DataBlocks.single<T>(w);
                
                for(var j=0; j<z.CellCount; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vload(w, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       
            }
        }

        protected void vor_blocks_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc<N128,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            
            vblock.or(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);
        }

        protected void vor_blocks_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            
            vblock.or(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);
        }
     
        protected void vor_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(w);
                var srcY = Random.Blocks<T>(w);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();
                
                var dstExpect = DataBlocks.single<T>(w);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        protected void vor_check<T>(N256 w, T t = default)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(w);
                var srcY = Random.Blocks<T>(w);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();

                var dstExpect = DataBlocks.single<T>(w);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);               
            }
        } 

        protected void vextract_check<T>(N128 w, T t = default)
            where T : unmanaged
        {

            var len = vlength<T>(w);
            var src = Random.CpuVector<T>(w);
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.StoreTo(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);
        }
            
        protected void vextract_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var len = vlength<T>(w);
            var half = len >> 1;
            var src = Random.CpuVector<T>(w);
            var srcData = span<T>(len);
            src.StoreTo(srcData);
            
            var x0 = ginx.vlo(src);
            var y0 = span<T>(half);
            x0.StoreTo(y0);
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.vhi(src);
            var y1 = span<T>(half);
            x1.StoreTo(y1);
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

        }

        protected void vreverse_check<N,T>(N w = default, T t = default)
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

        protected void vreverse_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var inc = vbuild.increments<T>(w);
                var dec = vbuild.decrements<T>(w);
                var y = ginx.vreverse(inc);
                Claim.eq(dec, y);
                Claim.eq(inc, ginx.vreverse(y));
            }
        }

        protected void vreverse_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var inc = vbuild.increments<T>(w);
                var dec = vbuild.decrements<T>(w);
                var y = ginx.vreverse(inc);
                Claim.eq(dec, y);
                Claim.eq(inc, ginx.vreverse(y));
            }
        }

        protected void vxor_blocks_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;

            var stats = BlockStats.Calc<N256,T>(blocks);
            Claim.eq(w/bitsize<T>(), stats.BlockLength);

            var xb = Random.Blocks<T>(w, blocks);
            var yb = Random.Blocks<T>(w, blocks);
            var zb = DataBlocks.alloc<T>(w, blocks);
            
            vblock.xor(w, blocks, stats.BlockLength, in xb.Head, in yb.Head, ref zb.Head);
            
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);

            zb.Clear();
            ginx.vxor(xb, yb, zb);

            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }

        protected void vxor_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var bX = Random.Blocks<T>(w);
                var bY = Random.Blocks<T>(w);
                var vX = bX.LoadVector();
                var vY = bY.LoadVector();
                
                var bExpect = DataBlocks.single<T>(w);
                for(var i=0; i< bExpect.CellCount; i++)
                    bExpect[i] = gmath.xor(bX[i], bY[i]);
                
                var vExpect = bExpect.LoadVector();
                var vActual = ginx.vxor(vX,vY);
                Claim.eq(vExpect,vActual);
            }
        }

        protected void vxor_check<T>(N256 w, T t = default)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var bX = Random.Block(w,t);
                var bY = Random.Block(w,t);
                var vX = bX.LoadVector();
                var vY = bY.LoadVector();

                var bExpect = DataBlocks.single<T>(w);
                for(var i=0; i< bExpect.CellCount; i++)
                    bExpect[i] = gmath.xor(bX[i], bY[i]);
                
                var vExpect = bExpect.LoadVector();
                var vActual = ginx.vxor(vX,vY);
                Claim.eq(vExpect,vActual);               
            }
        } 

        protected void vxor_blocks_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = SampleSize;
            var stats = BlockStats.Calc(count,w,t);

            var xb = Random.Blocks(w, count, t);
            var yb = Random.Blocks(w, count, t);
            var zb = DataBlocks.alloc<T>(w, count);
            vblock.xor(w, count, stats.BlockLength, in xb.Head, in yb.Head, ref zb.Head);

            for(var i=0; i < stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
            
            zb.Clear();
            ginx.vxor(xb, yb, zb);
            for(var i=0; i < stats.CellCount; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }


        protected void vtestz_check<T>(N128 n = default, T t = default)
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector(n,t);
                var xbs = x.ToBitString();
                var ybs = BitString.alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = bit.On;

                var y = ybs.ToCpuVector(n,t);

                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

        protected void vtestz_check<T>(N256 w = default, T t = default)
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector(w,t);
                var xbs = x.ToBitString();
                var ybs = BitString.alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = bit.On;

                var y = ybs.ToCpuVector(w,t);
                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

        protected void vhi_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = vlength<T>(w);
            for(var sample=0; sample< SampleSize; sample++)
            {                
                var x = Random.CpuVector<T>(w,t);
                var h = ginx.vhi(x);

                for(int i=0, j = count/2; j < count; i++, j++)
                    Claim.eq(x.Item(j), h.Item(i));
            }
        }

        protected void vhi_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var count = vlength<T>(w);
            for(var sample=0; sample< SampleSize; sample++)
            {                
                var x = Random.CpuVector<T>(w,t);
                var h = ginx.vhi(x);

                for(int i=0, j = count/2; j < count; i++, j++)
                    Claim.eq(vcell(x,j), h.Item(i));
            }
        }

       protected void add_blocks_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = SampleSize;
            var stats = BlockStats.Calc(count,w,t);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks(w, count, t);
            var rhs = Random.Blocks(w, count, t);
            var dst = DataBlocks.alloc<T>(w, count);
            vblock.add(w, count, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.add(lhs[i],rhs[i]), dst[i]);
        }

        protected void add_blocks_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.add(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.add(lhs[i],rhs[i]), dst[i]);
        }

        protected void add_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var length = BitCalcs.mincells<T>(w);
            Span<T> xbuffer = stackalloc T[length];
            Span<T> ybuffer = stackalloc T[length];
            Span<T> zbuffer = stackalloc T[length];
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                x.StoreTo(xbuffer);

                var y = Random.CpuVector<T>(w);
                y.StoreTo(ybuffer);

                var z = ginx.vadd(x,y);
                z.StoreTo(zbuffer);
                
                for(var i=0; i< length; i++)
                    Claim.eq(gmath.add(xbuffer[i],ybuffer[i]), zbuffer[i]);                
            }
        }

        protected void add_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var length = BitCalcs.mincells<T>(w);
            Span<T> xbuffer = stackalloc T[length];
            Span<T> ybuffer = stackalloc T[length];
            Span<T> zbuffer = stackalloc T[length];
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                x.StoreTo(xbuffer);

                var y = Random.CpuVector<T>(w);
                y.StoreTo(ybuffer);

                var z = ginx.vadd(x,y);
                z.StoreTo(zbuffer);
                
                for(var i=0; i< length; i++)
                    Claim.eq(gmath.add(xbuffer[i],ybuffer[i]), zbuffer[i]);                
            }
        }

        protected void vinsert_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i < SampleSize; i++)
            {
                var v128Src = Random.CpuVector<T>(w);
                var srcSpan = v128Src.ToSpan();

                var dst = vbuild.zero(n256,t);
                
                var vLo = ginx.vinsert(v128Src, dst,0);
                var vLoSpan = vLo.ToSpan().Slice(0, vLo.Length()/2);

                var vHi = ginx.vinsert(v128Src, dst, 1);
                var vHiSpan = vHi.ToSpan().Slice(vLo.Length()/2);

                Claim.eq(srcSpan, vLoSpan);
                Claim.eq(srcSpan, vHiSpan);
            }
        }

        protected void vrotl_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var minshift = 2;
            var maxshift = bitsize<T>() - 2;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(minshift,maxshift);
                var result = ginx.vrotl(x,(byte)offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        protected void vrotl_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            byte minshift = 2;
            byte maxshift = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(minshift,maxshift);
                var result = ginx.vrotl(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotl(src, (int)offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        protected void vrotr_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            byte minshift = 2;
            byte maxshift = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n256);
                var offset = Random.Next(minshift,maxshift);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        protected void vrotr_check<T>(N128 n, T t = default)
            where T : unmanaged
        {
            byte minshift = 2;
            byte maxshift = (byte)(bitsize<T>() - 2);
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n128);
                var offset = Random.Next(minshift,maxshift);
                var result = ginx.vrotr(x,offset).ToSpan();
                var expect = x.ToSpan().Map(src => gbits.rotr(src, offset));
                for(var i=0; i<expect.Length; i++)
                    Claim.eq(expect[i],result[i]);
            }
        }

        protected void vnonz_check<T>(N128 n, T t = default)
            where T : unmanaged
        {            
            var  src = Random.Blocks<T>(n, count: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = ginx.vload(n, in src.BlockRef(i));
                Claim.yea(ginx.vnonz(v));
            }
            
            Claim.nea(ginx.vnonz(vzero<T>(n)));
        }

        protected void vnonz_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            var  src = Random.Blocks<T>(n, count: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = ginx.vload(n, in src.BlockRef(i));
                Claim.yea(ginx.vnonz(v));
            }
            
            Claim.nea(ginx.vnonz(vzero<T>(n)));
        }

        protected void vnegate_blocks_check<T>(N128 n, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc<N128,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var src = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.negate(n, blocks, step, in src.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.negate(src[i]), dst[i]);
        }

        protected void vnegate_blocks_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var src = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.negate(n, blocks, step, in src.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.negate(src[i]), dst[i]);
        }

        protected void vnegate_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(w);
                Claim.eq(y,z);
            }
        }

        protected void vnegate_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(w);
                Claim.eq(y,z);
            }
        }

        protected void vinc_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var zb = DataBlocks.alloc<T>(w, blocks);
            var eb = DataBlocks.alloc<T>(w, blocks);            
            Claim.eq(zb.BlockCount, blocks);

            var blocklen = DataBlocks.blocklen<T>(w);
            
            for(var i=0; i<CycleCount; i++)
            {
                var xb = Random.Blocks<T>(w,blocks);
                ginx.vinc(xb, zb);

                for(var block = 0; block < blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    eb[block,cell] = gmath.inc(xb[block,cell]);

                Claim.eq(eb,zb);
            }
        }

        protected void vinc_check<T>(N256 w, T t = default)
            where T : unmanaged
        {

            var blocks = SampleSize;
            var zb = DataBlocks.alloc<T>(w, blocks);
            var eb = DataBlocks.alloc<T>(w, blocks);
            Claim.eq(zb.BlockCount, blocks);

            var blocklen = DataBlocks.blocklen<T>(w);

            for(var i=0; i<CycleCount; i++)
            {
                var xb = Random.Blocks<T>(w,blocks);                
                ginx.vinc(xb, zb);

                for(var block = 0; block < blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    eb[block,cell] = gmath.inc(xb[block,cell]);

                Claim.eq(eb,zb);
            }
        }

        protected void vmax_check<T>(N256 w, T t = default)
            where T : unmanaged
        {

            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.single<T>(w);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.max(xs[i],ys[i]);
                
                var expect = zs.LoadVector();                
                var actual = ginx.vmax(x,y);
                Claim.eq(expect,actual);                
            }
        }

        protected void vmax_check<T>(N128 w, T t = default)
            where T : unmanaged
        {

            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.single<T>(w);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.max(xs[i],ys[i]);
                
                var expect = zs.LoadVector();                
                var actual = ginx.vmax(x,y);
                Claim.eq(expect,actual);                
            }
        }

        protected void vmax_block_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.max(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.max(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmax_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.max(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.max(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmin_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.single<T>(w);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.min(xs[i],ys[i]);
                
                var expect = zs.LoadVector();                
                var actual = ginx.vmin(x,y);
                Claim.eq(expect,actual);                
            }
        }

        protected void vmin_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.single<T>(w);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.min(xs[i],ys[i]);
                
                var expect = zs.LoadVector();                
                var actual = ginx.vmin(x,y);
                Claim.eq(expect,actual);                
            }
        }

        protected void vmin_block_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.min(w, blocks, stats.BlockLength, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmin_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.min(w, blocks, stats.BlockLength, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

        protected void vunits_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var units = VData.uints<T>(w).ToSpan();
            for(var i=0; i<units.Length; i++)
                Claim.eq(gmath.one<T>(), units[i]);
        }
        
        protected void vunits_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var units = VData.uints<T>(w).ToSpan();
            for(var i=0; i<units.Length; i++)
                Claim.eq(gmath.one<T>(), units[i]);
        }

        protected void vones_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var bs = ones.ToBitString();
            Claim.eq(w,bs.Length);
            Claim.eq(w,bs.PopCount());
        }

        protected void vones_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var ones = vbuild.ones<T>(w);
            var bs = ones.ToBitString();
            Claim.eq(w,bs.Length);
            Claim.eq(w,bs.PopCount());
        }

        protected void vsub_check<T>(N128 w, T t = default)
            where T : unmanaged
            => VerifyBinOp(Random, SampleSize, new Vector128BinOp<T>(ginx.vsub), gmath.sub<T>);

        protected void vsub_check<T>(N256 w, T t = default)
            where T : unmanaged
                => VerifyBinOp(Random, SampleSize, new Vector256BinOp<T>(ginx.vsub), gmath.sub<T>);

        protected void vsub_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var lhs = Random.Blocks<T>(n256,SampleSize).ReadOnly();
            var rhs = Random.Blocks<T>(n256,SampleSize).ReadOnly();
            var dstA = lhs.Replicate();
            ginx.vsub(lhs, rhs, dstA);
            var dstB = DataBlocks.alloc<T>(n256,lhs.BlockCount);
            for(var i = 0; i < dstA.CellCount; i++)
                dstB[i] = gmath.sub(lhs[i], rhs[i]);
            Claim.yea(dstA.Identical(dstB));
        }

        protected void vnext_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = vbuild.units<T>(w);
                
                Claim.yea(ginx.vadd<T>(xp, uints).Equals(x));
                Claim.yea(ginx.vsub<T>(xn, uints).Equals(x));

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xns[j], gmath.inc(xs[j]));
                    Claim.eq(xps[j], gmath.dec(xs[j]));
                }
            }
        }

        protected void vnext_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = vbuild.units<T>(w);
                
                Claim.yea(ginx.vadd<T>(xp, uints).Equals(x));
                Claim.yea(ginx.vsub<T>(xn, uints).Equals(x));

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xns[j], gmath.inc(xs[j]));
                    Claim.eq(xps[j], gmath.dec(xs[j]));
                }
            }
        }

        protected void vsll_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var maxshift = (byte)bitsize<T>();
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var shift = Random.Next<byte>(1, maxshift);
                var actual = ginx.vsll(x, shift);
                var expect = mathspan.sll(x.ToSpan().ReadOnly(), shift).LoadVector(w);
                Claim.eq(actual,expect);
            }
        }

        protected void vsll_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var maxshift = (byte)bitsize<T>();
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var shift = Random.Next<byte>(1, maxshift);
                var actual = ginx.vsll(x, shift);
                var expect = mathspan.sll(x.ToSpan().ReadOnly(), shift).LoadVector(w);
                Claim.eq(actual,expect);
            }
        }

        protected void vsrl_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var maxshift = (byte)bitsize<T>();
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var shift = Random.Next<byte>(1, maxshift);
                var actual = ginx.vsrl(x, shift);
                var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                Claim.eq(actual,expect);
            }
        }

        protected void vsrl_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var maxshift = (byte)bitsize<T>();
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<T>(w);
                var shift = Random.Next<byte>(1, maxshift);
                var actual = ginx.vsrl(x, shift);
                var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                Claim.eq(actual,expect);
            }
        }

        protected void vand_blocks_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.and(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.and(lhs[i],rhs[i]), dst[i]);
        }

        protected void vand_blocks_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            vblock.and(w, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.and(lhs[i],rhs[i]), dst[i]);
        }
     
        protected void vand_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(w);
                var srcY = Random.Blocks<T>(w);
                var vX = ginx.vload(w, in head(srcX));
                var vY = ginx.vload(w, in head(srcY));
                
                var dstExpect = DataBlocks.single<T>(w);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(w, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        protected void vand_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(w);
                var srcY = Random.Blocks<T>(w);
                var vX = ginx.vload(w, in head(srcX));
                var vY = ginx.vload(w, in head(srcY));
                var dstExpect = DataBlocks.single<T>(w);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(w, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        protected void vsrlv_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.alloc<T>(w);
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsrlv(x,offsets);
                var expect = ginx.vload(w,mathspan.srlv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

        protected void vsrlv_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.alloc<T>(w);
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsrlv(x,offsets);
                var expect = ginx.vload(w,mathspan.srlv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

        protected void vsllv_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.alloc<T>(w);
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsllv(x,offsets);
                var expect = ginx.vload(w,mathspan.sllv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

        protected void vsllv_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var shiftrange = (default(T),convert<int,T>(bitsize(t) - 1));
            var buffer = DataBlocks.alloc<T>(w);
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(w);
                var offsets = Random.CpuVector<T>(w, shiftrange);
                var actual = ginx.vsllv(x,offsets);
                var expect = ginx.vload(w,mathspan.sllv<T>(x.ToSpan(), offsets.ToSpan(), buffer));
                Claim.eq(expect, actual);
            }
        }

        protected void vsll_bench<T>(N128 w, T t = default, SystemCounter counter = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"sll_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(w);
                counter.Start();
                last = ginx.vsll(x,offset);
                counter.Stop();
            
            }
            Benchmark(opname, counter, opcount);
        }

        protected void vsll_bench<T>(N256 w, T t = default, SystemCounter counter = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"sll_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n256);
                counter.Start();
                last = ginx.vsll(x,offset);
                counter.Stop();
            
            }
            Benchmark(opname, counter, opcount);
        }

        protected void vsrl_bench<T>(N128 w, T t = default, SystemCounter counter = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"srl_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(w);
                counter.Start();
                last = ginx.vsrl(x,offset);
                counter.Stop();
            
            }
            Benchmark(opname, counter, opcount);
        }

        protected void vsrl_bench<T>(N256 w, T t = default, SystemCounter counter = default)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(w);
            var bitlen = bitsize<T>();
            var opname = $"srl_{w}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(w);
                counter.Start();
                last = ginx.vsrl(x,offset);
                counter.Stop();            
            }

            Benchmark(opname, counter, opcount);
        }        

        void xor_gmath_bench<T>(N256 w, T t = default, SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_gmath_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(w);
            var xb = Random.Blocks<T>(w,blocks);
            var yb = Random.Blocks<T>(w,blocks);
            var zb = DataBlocks.alloc<T>(w,blocks);

            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
            {                
                for(var block = 0; block< blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    zb[block,cell] = gmath.xor(xb[block,cell], yb[block,cell]);                                    
            }
            counter.Stop();
            Benchmark(opname, counter,opcount);
        }

        void xor_ginx_bench<T>(N256 w, T t = default,  SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_ginx_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(w);
            var xb = Random.Blocks<T>(w,blocks);
            var yb = Random.Blocks<T>(w,blocks);
            var zb = DataBlocks.alloc<T>(w,blocks);
            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
                ginx.vxor(xb, yb, zb);
            counter.Stop();

            Benchmark(opname, counter, opcount);
        }

        protected void vxor_bench<T>(N256 w, T t = default)
            where T : unmanaged
        {
            xor_gmath_bench(w,t);
            xor_ginx_bench(w,t);
        }
    }
}