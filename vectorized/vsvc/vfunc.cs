//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;    

    /// <summary>
    /// Vectorized functions
    /// </summary>
    public static partial class VSvcFactories
    {

    }

    /// <summary>
    /// Vectorized operator types
    /// </summary>
    public static partial class VSvcHosts
    {

    }
    
    public static class vfunc
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vpipe<F,G,T>(Vector128<T> x, F f, G g)
            where T : unmanaged
            where F : IVUnaryOp128<T>
            where G : IVUnaryOp128<T>
                => Pipes.pipe(x,f,g);

        [MethodImpl(Inline)]
        public static Vector256<T> vpipe<F,G,T>(Vector256<T> x, F f, G g)
            where T : unmanaged
            where F : IVUnaryOp256<T>
            where G : IVUnaryOp256<T>
                => Pipes.pipe(x,f,g);

        [MethodImpl(Inline)]
        public static Vector128<T> vcompose<F,G,T>(Vector128<T> x, Vector128<T> y, F f, G g)
            where T : unmanaged
            where F : IVBinOp128<T>
            where G : IVUnaryOp128<T>
                => Pipes.compose(x,y,f,g);

        [MethodImpl(Inline)]
        public static Vector256<T> vpipe<F,G,T>(Vector256<T> x, Vector256<T> y, F f, G g)
            where T : unmanaged
            where F : IVBinOp256<T>
            where G : IVUnaryOp256<T>
                => Pipes.compose(x,y,f,g);

        [MethodImpl(Inline)]
        public static Vector128<T> vapply<F,T>(Vector128<T> x, Vector128<T> y, F f)
            where T : unmanaged
            where F : IVBinOp128<T>
                => Pipes.apply(x,y,f);
        
        [MethodImpl(Inline)]
        public static Vector256<T> vapply<F,T>(Vector256<T> x, Vector256<T> y, F f)
            where T : unmanaged
            where F : IVBinOp256<T>
                => Pipes.apply(x,y,f);

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vzip<F,T>(in Block128<T> lhs, in Block128<T> rhs, in Block128<T> dst, F f)
            where T : unmanaged
            where F : IVBinOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vzip<F,T>(in Block256<T> lhs, in Block256<T> rhs, in Block256<T> dst, F f)
            where T : unmanaged
            where F : IVBinOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vzip<F,T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst, F f)
            where T : unmanaged
            where F : IVTernaryOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block), c.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vzip<F,T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst, F f)
            where T : unmanaged
            where F : IVTernaryOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block), c.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static bit vall<F,T>(in Block128<T> lhs, F f)
            where T : unmanaged
            where F : IVUnaryPred128<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit vall<F,T>(in Block256<T> lhs, F f)
            where T : unmanaged
            where F : IVUnaryPred256<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit vall<F,T>(in Block128<T> lhs, in Block128<T> rhs, F f)
            where T : unmanaged
            where F : IVBinPred128<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit vall<F,T>(in Block256<T> lhs, in Block256<T> rhs, F f)
            where T : unmanaged
            where F : IVBinPred256<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vzip<F,T>(in Block128<T> src, byte offset, in Block128<T> dst, F f)
            where T : unmanaged
            where F : IVShiftOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),offset).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vzip<F,T>(in Block256<T> src, byte offset, in Block256<T> dst, F f)
            where T : unmanaged
            where F : IVShiftOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),offset).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vmap<F,T>(in Block128<T> src, in Block128<T> dst, F f)
            where T : unmanaged
            where F : IVUnaryOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vmap<F,T>(in Block256<T> src, in Block256<T> dst, F f)
            where T : unmanaged
            where F : IVUnaryOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }
    }
}