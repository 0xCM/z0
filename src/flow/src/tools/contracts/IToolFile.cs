//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolFile
    {
        FilePath Path {get;}
    }

    public interface IToolFile<T> : IToolFile, ITooling<T>
        where T : struct, ITool<T>

    {

    }

    public interface IToolFile<T,F> : IToolFile<T>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        

    }
}