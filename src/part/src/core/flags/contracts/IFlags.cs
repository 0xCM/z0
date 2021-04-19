//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFlags : ITextual
    {
        byte DataWidth {get;}
    }

    public interface IFlags<E> : IFlags
        where E : unmanaged
    {
        E Value {get;}

        bit this[E flag] {get;}
    }

    public interface IFlags<E,W> : IFlags<E>
        where E : unmanaged
        where W : unmanaged
    {
        bit this[W flag] {get;}
    }

    public interface IFlags<F,E,W> : IFlags<E,W>
        where E : unmanaged
        where W : unmanaged
        where F : IFlags<F,E,W>
    {
    }
}