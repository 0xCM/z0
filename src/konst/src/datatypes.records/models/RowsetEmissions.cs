//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RowsetEmissions<T> : IDataFlow<Rowset<T>, FS.FilePath>
        where T : struct
    {
        public Rowset<T> Source {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public RowsetEmissions(Rowset<T> src, FS.FilePath dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator RowsetEmissions<T>((Rowset<T> src, FS.FilePath dst) x)
            => new RowsetEmissions<T>(x.src, x.dst);
    }
}