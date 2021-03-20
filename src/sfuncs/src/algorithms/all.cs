//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SFx
    {
        [MethodImpl(Inline)]
        public static bit all<F,T>(in SpanBlock128<T> lhs, F f)
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
        public static bit all<F,T>(in SpanBlock256<T> lhs, F f)
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
        public static bit all<F,T>(in SpanBlock128<T> lhs, in SpanBlock128<T> rhs, F f)
            where T : unmanaged
            where F : IBinaryPred128<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block<blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit all<F,T>(in SpanBlock256<T> lhs, in SpanBlock256<T> rhs, F f)
            where T : unmanaged
            where F : IBinaryPred256<T>
        {
            var blocks = lhs.BlockCount;
            var result = bit.On;
            for(var block = 0; block<blocks; block++)
                result &= f.Invoke(lhs.LoadVector(block), rhs.LoadVector(block));
            return result;
        }
    }
}