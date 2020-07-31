//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cmd
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ICmdTool
    {
        string Name {get;}
    }
    
    public interface ICmdTool<T> : ICmdTool
        where T :  unmanaged, ICmdTool<T>
    {


    }

    public interface ICmdTool<T,F> : ICmdTool<T>
        where T : unmanaged, ICmdTool<T,F>
        where F : unmanaged, Enum
    {
        F[] Flags => Enums.literals<F>();
    }
}