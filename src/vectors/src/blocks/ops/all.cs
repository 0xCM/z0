//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Seed;

    partial class SBlock
    {
        [MethodImpl(Inline)]
        public static bit all<F,T>(in Block128<T> lhs, F f)
            where T : unmanaged
            where F : IUnaryPred128<T>
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
            where F : IUnaryPred256<T>
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
            where F : IBinaryPred128<T>
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
            where F : IBinaryPred256<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block < blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }
    }
}