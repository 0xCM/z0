//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Seed;

    public interface IRecordFormatter
    {
        string Render();

        void Reset();
    }

    public interface IRecordFormatter<F> : IRecordFormatter
        where F : unmanaged, Enum
    {
        void AppendField(F f, object data);   

        void AppendField<T>(F f, T data)
            where T : ITextual;

        void DelimitField(F f, object data, char delimiter);

        void DelimitField(F f, object data);

        void DelimitSome<T>(F f, T data)
            where T : unmanaged, Enum;

        void DelimitSome<T>(F f, T data, char delimiter)
            where T : unmanaged, Enum;

        void DelimitField<T>(F f, T data, char delimiter)
            where T : ITextual;

        void DelimitField<T>(F f, T data)
            where T : ITextual;       

        void AppendField(F f, object data, char delimiter)
            => DelimitField(f, data, delimiter);

         void AppendField<T>(F f, T data, char delimiter)
            where T : ITextual
                => DelimitField(f, data, delimiter);

         void AppendSome<T>(F f, T data, char delimiter)
            where T : unmanaged, Enum
                => DelimitSome(f,data,delimiter);         
    }
}