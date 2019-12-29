//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    /// <summary>
    /// Base type for vectorized intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_vinx<X> : t_inx<X>
        where X : t_vinx<X>
    {

        protected t_vinx()
        {
            Check = new CheckExec(Config);
        }
        
        protected CheckExec Check {get;}

        static void CheckFailed()
            => throw new Exception();
                
        /// <summary>
        /// Verifies the correct function of a vectorized factory operator
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="f">The factory operator to verify</param>
        /// <param name="check">The adjudication operator</param>
        /// <param name="s">A factory input type representative</param>
        /// <param name="t">A target vector component type representative</param>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="C">The check operator type</typeparam>
        /// <typeparam name="S">The factory input type</typeparam>
        /// <typeparam name="T">The target vector component type</typeparam>
        protected void CheckFactory<F,C,S,T>(N128 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : IVFactoryOp128<S,T>
            where C : IVChecker128<S,T>
        {
            void exec()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    if(!check.Invoke(a,v))
                        CheckFailed();
                }
            }
            CheckAction(exec, TestCaseName(f));
        }

        /// <summary>
        /// Verifies the correct function of a vectorized factory operator
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="f">The factory operator to verify</param>
        /// <param name="check">The adjudication operator</param>
        /// <param name="s">A factory input type representative</param>
        /// <param name="t">A target vector component type representative</param>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="C">The check operator type</typeparam>
        /// <typeparam name="S">The factory input type</typeparam>
        /// <typeparam name="T">The target vector component type</typeparam>
        protected void CheckFactory<F,C,S,T>(N256 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : IVFactoryOp256<S,T>
            where C : IVChecker256<S,T>
        {
            void exec()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    if(!check.Invoke(a,v))
                        CheckFailed();
                }
            }

            CheckAction(exec, TestCaseName(f));
        }

        protected void CheckUnaryScalarMatch<F,T>(F f, N128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVUnaryOp128D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(f));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(f),succeeded,count);
            }
        }

        protected void CheckUnaryScalarMatch<F,T>(F f, N256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(f));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(f),succeeded,count);
            }
        }

         

        protected void vextract_check<T>(N128 w, T t = default)
            where T : unmanaged
        {

            var len = zfunc.vcount<T>(w);
            var src = Random.CpuVector<T>(w);
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.StoreTo(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);
        }
            


        protected void vhi_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var count = zfunc.vcount<T>(w);
            for(var sample=0; sample< RepCount; sample++)
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
            var count = zfunc.vcount<T>(w);
            for(var sample=0; sample< RepCount; sample++)
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
            var count = RepCount;
            var stats = BlockStats.Calc(count,w,t);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks(w, count, t);
            var rhs = Random.Blocks(w, count, t);
            var dst = DataBlocks.alloc<T>(w, count);
            ginx.vadd(lhs,rhs,dst);

            //vblock.add(w, count, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.add(lhs[i],rhs[i]), dst[i]);
        }

        protected void add_blocks_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = BlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            ginx.vadd(lhs,rhs,dst);

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
            for(var sample=0; sample<RepCount; sample++)
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
            for(var sample=0; sample<RepCount; sample++)
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
            for(var i=0; i < RepCount; i++)
            {
                var v128Src = Random.CpuVector<T>(w);
                var srcSpan = v128Src.ToSpan();

                var dst = CpuVector.vzero(n256,t);
                
                var vLo = ginx.vinsert(v128Src, dst,0);
                var vLoSpan = vLo.ToSpan().Slice(0, vLo.Length()/2);

                var vHi = ginx.vinsert(v128Src, dst, 1);
                var vHiSpan = vHi.ToSpan().Slice(vLo.Length()/2);

                Claim.eq(srcSpan, vLoSpan);
                Claim.eq(srcSpan, vHiSpan);
            }
        }


        protected void vnegate_blocks_check<T>(N128 n, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = BlockStats.Calc<N128,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var src = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            ginx.vnegate(src,dst);

            for(var i=0; i<cells; i++)
                Claim.eq(gmath.negate(src[i]), dst[i]);
        }

        protected void vnegate_blocks_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = BlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;
            var src = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            ginx.vnegate(src,dst);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.negate(src[i]), dst[i]);
        }

        protected void vnegate_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
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
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(w);
                Claim.eq(y,z);
            }
        }

        protected void vmax_check<T>(N256 w, T t = default)
            where T : unmanaged
        {

            for(var sample=0; sample<RepCount; sample++)
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

            for(var sample=0; sample<RepCount; sample++)
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
            var blocks = RepCount;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            ginx.vmax(lhs,rhs,dst);

            for(var i=0; i<cells; i++)
                Claim.eq(gmath.max(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmax_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = BlockStats.Calc(blocks,w, default(T));
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            ginx.vmax(lhs,rhs,dst);

            for(var i=0; i<cells; i++)
                Claim.eq(gmath.max(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmin_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            for(var sample=0; sample<RepCount; sample++)
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
            for(var sample=0; sample<RepCount; sample++)
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
            var blocks = RepCount;
            var stats = BlockStats.Calc(blocks,w, default(T));

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            ginx.vmin(lhs,rhs,dst);

            //vblock.min(w, blocks, stats.BlockLength, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

        protected void vmin_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = BlockStats.Calc(blocks,w, default(T));

            var lhs = Random.Blocks<T>(w, blocks);
            var rhs = Random.Blocks<T>(w, blocks);
            var dst = DataBlocks.alloc<T>(w, blocks);
            ginx.vmin(lhs,rhs,dst);

            //vblock.min(w, blocks, stats.BlockLength, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<stats.CellCount; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

        protected void vunits_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var units = CpuVector.vunits(w,t).ToSpan();
            for(var i=0; i<units.Length; i++)
                Claim.eq(gmath.one<T>(), units[i]);
        }
        
        protected void vunits_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var units = CpuVector.vunits(w,t).ToSpan();
            for(var i=0; i<units.Length; i++)
                Claim.eq(gmath.one<T>(), units[i]);
        }

        protected void vones_check<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var ones = CpuVector.vones<T>(w);
            var bs = ones.ToBitString();
            Claim.eq(w,bs.Length);
            Claim.eq(w,bs.PopCount());
        }

        protected void vones_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var ones = CpuVector.vones<T>(w);
            var bs = ones.ToBitString();
            Claim.eq(w,bs.Length);
            Claim.eq(w,bs.PopCount());
        }

        protected void vsub_block_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var lhs = Random.Blocks<T>(n256,RepCount);
            var rhs = Random.Blocks<T>(n256,RepCount);
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
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = CpuVector.vunits<T>(w);
                
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
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var xs = x.ToSpan();
                var xn = x.Next();
                var xns = xn.ToSpan();
                var xp = x.Prior();
                var xps = xp.ToSpan();

                var uints = CpuVector.vunits<T>(w);
                
                Claim.yea(ginx.vadd<T>(xp, uints).Equals(x));
                Claim.yea(ginx.vsub<T>(xn, uints).Equals(x));

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xns[j], gmath.inc(xs[j]));
                    Claim.eq(xps[j], gmath.dec(xs[j]));
                }
            }
        }



        public void vbyteswap_check_256<T>(N128 w, T t = default)
            where T : unmanaged
        {
            var n = CpuVector.vcount(w,t);
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = ginx.vbyteswap(x);
                for(var j = 0; j< n; j++)
                    Claim.yea(gmath.eq(gbits.byteswap(x.Cell(j)), y.Cell(j)));                    
            }
        }

        public void vbyteswap_check_256<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var n = CpuVector.vcount(w,t);
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = ginx.vbyteswap(x);
                for(var j = 0; j< n; j++)
                    Claim.yea(gmath.eq(gbits.byteswap(x.Cell(j)), y.Cell(j)));
                    
            }
        }
    }
}