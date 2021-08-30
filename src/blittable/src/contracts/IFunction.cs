//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct Blit
    {
        [Free]
        public interface IFunction
        {

        }

        [Free]
        public interface IFunction<F,S,T> : IFunction
            where F : IFunction<F,S,T>
            where S : unmanaged
            where T : unmanaged
        {
            T Eval(S x);

            map<S,T> Map(S x);
        }
    }
}