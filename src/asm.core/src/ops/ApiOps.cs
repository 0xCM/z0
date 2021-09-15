//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly partial struct ApiOps
    {
        public interface IOperation
        {

        }

        public interface IOperation<T> : IOperation
            where T : unmanaged, IOperation<T>
        {

        }

        public interface IXor<T> : IOperation<T>
            where T : unmanaged, IXor<T>
        {
            T Op1 {get;}

            T Op2 {get;}
        }
    }
}