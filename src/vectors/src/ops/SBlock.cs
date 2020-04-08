//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Seed;

    public static partial class SBlock
    {
        [MethodImpl(Inline)]
        public static bit all<F,T>(in Block128<T> lhs, F f)
            where T : unmanaged
            where F : ISVUnaryPredicate128Api<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit all<F,T>(in Block256<T> lhs, F f)
            where T : unmanaged
            where F : ISVUnaryPredicate256Api<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit all<F,T>(in Block128<T> lhs, in Block128<T> rhs, F f)
            where T : unmanaged
            where F : ISVBinaryPredicate128Api<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit all<F,T>(in Block256<T> lhs, in Block256<T> rhs, F f)
            where T : unmanaged
            where F : ISVBinaryPredicate256Api<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> zip<F,T>(in Block128<T> lhs, in Block128<T> rhs, in Block128<T> dst, F f)
            where T : unmanaged
            where F : ISVBinaryOp128Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> zip<F,T>(in Block256<T> lhs, in Block256<T> rhs, in Block256<T> dst, F f)
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> zip<F,T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst, F f)
            where T : unmanaged
            where F : ISVTernaryOp128Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block), c.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> zip<F,T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst, F f)
            where T : unmanaged
            where F : ISVTernaryOp256Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block), c.LoadVector(block)).StoreTo(dst, block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> zip<F,T>(in Block128<T> src, byte offset, in Block128<T> dst, F f)
            where T : unmanaged
            where F : ISVShiftOp128Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),offset).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> zip<F,T>(in Block256<T> src, byte offset, in Block256<T> dst, F f)
            where T : unmanaged
            where F : ISVShiftOp256Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),offset).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> map<F,T>(in Block128<T> src, in Block128<T> dst, F f)
            where T : unmanaged
            where F : ISVUnaryOp128Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> map<F,T>(in Block256<T> src, in Block256<T> dst, F f)
            where T : unmanaged
            where F : ISVUnaryOp256Api<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }
         
    }
}