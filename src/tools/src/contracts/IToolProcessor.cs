//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface IToolProcessor  : IDisposable     
    {
        void Process(IToolFile src);
    }

    public interface IToolProcessor<T> : IToolProcessor, ITooling<T>
        where T : struct, ITool<T>
        
    {
        void Process(IToolFile<T> src);

        void IToolProcessor.Process(IToolFile src)
            => Process((IToolFile<T>)src);
    }
    
    public interface IToolProcessor<T,F> : IToolProcessor<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        void Process(IToolFile<T,F> src); 

        void IToolProcessor<T>.Process(IToolFile<T> src)       
            => Process((IToolFile<T,F>)src);
    }
}