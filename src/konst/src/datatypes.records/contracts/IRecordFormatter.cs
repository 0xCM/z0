//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public interface IRecordFormatter<T>
        where T : struct
    {
        string Formt(in T src);

        string Format(in DynamicRow<T> src);
    }
}