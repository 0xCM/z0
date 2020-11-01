//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface ICmdTarget
    {
        FS.FilePath Path {get;}
    }

    public interface ICmdTarget<T> : ICmdTarget
        where T : struct, ITool<T>
    {
        T Tool => default(T);

    }

    public interface ICmdTarget<T,F> : ICmdTarget<T>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {

    }
}