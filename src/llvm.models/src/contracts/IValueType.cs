//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;

    public interface IValueType<T>
        where T : unmanaged, IValueType<T>
    {
        Label Name {get;}

        BitWidth Width => width<T>();

        ByteSize Size => size<T>();
    }
}