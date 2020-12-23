//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IRecordFormatter<T>
        where T : struct
    {
        string Format(in T src);

        string Format(in DynamicRow<T> src);
    }
}