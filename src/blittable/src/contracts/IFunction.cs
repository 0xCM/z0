//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct BitFlow
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

            KeyedValue<S,T> Map(S x);
        }
    }
}