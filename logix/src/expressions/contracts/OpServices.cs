//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IOpSvc<T,K>
        where T : unmanaged
        where K : Enum
    {
        IEnumerable<K> Available {get;}
    }

    public interface IUnaryOpSvc<T,K> : IOpSvc<T,K>
        where T : unmanaged
        where K : Enum
    {
        UnaryOp<T> Lookup(K kind);

        T Eval(K kind, T a);
    }

    public interface IBinOpSvc<T,K> : IOpSvc<T,K>
        where T : unmanaged
        where K : Enum
    {
        BinaryOp<T> Lookup(K kind);

        T Eval(K kind, T a, T b);

    }

    public interface ITernaryOpSvc<T,K> : IOpSvc<T,K>
        where T : unmanaged
        where K : Enum
    {
        TernaryOp<T> Lookup(K kind);

        T Eval(K kind, T a, T b, T c);

    }


}