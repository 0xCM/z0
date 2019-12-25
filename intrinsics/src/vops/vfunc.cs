//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static class vfunc
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vpipe<F,G,T>(in Vector128<T> src, F f, G g)
            where T : unmanaged
            where F : IVUnaryOp128<T>
            where G : IVUnaryOp128<T>
                => g.Invoke(f.Invoke(src));

        [MethodImpl(Inline)]
        public static Vector256<T> vpipe<F,G,T>(in Vector256<T> src, F f, G g)
            where T : unmanaged
            where F : IVUnaryOp256<T>
            where G : IVUnaryOp256<T>
                => g.Invoke(f.Invoke(src));

        [MethodImpl(Inline)]
        public static Vector128<T> vpipe<F,G,T>(in Vector128<T> lhs, in Vector128<T> rhs, F f, G g)
            where T : unmanaged
            where F : IVBinOp128<T>
            where G : IVUnaryOp128<T>
                => g.Invoke(f.Invoke(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vector256<T> vpipe<F,G,T>(in Vector256<T> lhs, in Vector256<T> rhs, F f, G g)
            where T : unmanaged
            where F : IVBinOp256<T>
            where G : IVUnaryOp256<T>
                => g.Invoke(f.Invoke(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vector128<T> vapply<F,T>(in Vector128<T> lhs, in Vector128<T> rhs, F f)
            where T : unmanaged
            where F : IVBinOp128<T>
                => f.Invoke(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Vector256<T> vapply<F,T>(in Vector256<T> lhs, in Vector256<T> rhs, F f)
            where T : unmanaged
            where F : IVBinOp256<T>
                => f.Invoke(lhs,rhs);

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
            where F : IVBinaryPred128<T>
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
            where F : IVBinaryPred256<T>
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