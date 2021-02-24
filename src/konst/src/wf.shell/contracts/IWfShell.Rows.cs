//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;
    using static WfEvents;
    using static Part;

    partial interface IWfShell
    {
       void Row<T>(T data)
            => Raise(row(data));

        void Rows<T>(T[] src)
            => Rows(@readonly(src), EmptyString);

        void Rows<T>(T[] src, string label)
            => Rows(@readonly(src), label);

        void Rows<T>(ReadOnlySpan<T> src)
            => Rows(src, EmptyString);

        void Rows<T>(ReadOnlySpan<T> src, string label)
        {
            if(src.Length != 0)
            {
                var buffer = Buffers.text();
                var count = src.Length;
                if(text.nonempty(label))
                    buffer.AppendLineFormat("Rowset {0}", label);

                for(var i=0; i<count; i++)
                    buffer.AppendLine(skip(src,i));
                Raise(rows(buffer.Emit()));
            }
        }
    }
}