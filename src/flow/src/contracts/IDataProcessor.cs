//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IDataProcessor
    {                
        void Connect() {}
    }
    
    public interface IDataProcessor<S> : IDataProcessor
    {        

    }

    public interface IDataProcessor<S,T>
    {
        T[] Target {get;}
        
        void Process();

        void Process(in S src, ref T dst, uint offset, uint count);

        ref T Process(in S src, ref T dst);
    }
}