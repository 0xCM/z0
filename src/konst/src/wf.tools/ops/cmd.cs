//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Tooling
    {
        public static ToolCmd<T> cmd<T>(T src)
            where T : struct, IToolCmd<T>
                => new ToolCmd<T>(src, Records.values(src, Records.fields<T>()));
    }
}