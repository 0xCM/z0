//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct OperationClasses
    {
        [Free]
        public interface ICellClass : IOperationClass
        {
            TypeWidth Width {get;}
        }

        [Free]
        public interface ICellClass<F,E> : IOperationClass<E>, IOperationClass
            where F : struct, ICellClass<F,E>
            where E : unmanaged, Enum
        {

        }
    }

}