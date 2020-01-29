//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public abstract class Record<T> : IRecord<T>
        where T : Record<T>, new()
    {
        public static readonly T Empty = new T();

        public abstract string DelimitedText(char delimiter);

        protected IRecord<T> This
            => this;

        IReadOnlyList<string> IRecord.GetHeaders()
            => This.HeaderFields;    
    
        protected static IReadOnlyList<string> GetHeaders()
            => Empty.This.HeaderFields;            
    }
}