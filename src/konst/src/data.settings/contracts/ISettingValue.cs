//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISettingValue<V> : ITextual
        where V : ISettingValue<V>
    {
        bool Parse(string src, out V dst);
    }
}