//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Core;

    partial class SBlock
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

    }
}