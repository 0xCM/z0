//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITextBlock : IDataType
    {
        string Text {get;}

        ByteSize BufferSize => Text.Length;

        uint Length => (uint)Text.Length;

        ReadOnlySpan<char> Characters
            => Text;
    }

    [Free]
    public interface ITextBlock<T> : ITextBlock
        where T : unmanaged
    {
        ReadOnlySpan<T> Data {get;}
    }
}