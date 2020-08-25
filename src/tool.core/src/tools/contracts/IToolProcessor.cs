//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface IToolProcessor  : IWfActor
    {
        void Process(); 

        ListedFiles List();
    }

    public interface IToolProcessor<T> : IToolProcessor
        where T : struct, ITool<T>
        
    {
    
    }
    
    public interface IToolProcessor<T,F> : IToolProcessor<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {


    }
}