//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IRecordFormatter
    {
        string Render(bool reset = true);

        void Reset();
    }

    public interface IRecordFormatter<F> : IRecordFormatter
        where F : unmanaged, Enum
    {
        void Append(F f, object data);   

        void Append<T>(F f, T data)
            where T : ITextual;

        void Delimit(F f, object data);

        void Delimit<T>(F f, T data)
            where T : ITextual;     

        void DelimitSome<T>(F field, T src)
            where T : unmanaged, Enum;              
    }
}