//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Tables;

    public readonly struct RowHeader : IIndex<HeaderCell>, ITextual
    {
        public static Outcome parse(string src, char delimiter, out RowHeader dst)
        {
            if(text.empty(src))
            {
                dst = RowHeader.Empty;
                return (false,"The source text is empty");
            }
            else
            {
                try
                {
                    var parts = text.split(src, delimiter, false).View;
                    var count = parts.Length;
                    var cells = alloc<HeaderCell>(count);
                    ref var cell = ref first(cells);
                    for(var i=0u; i<count; i++)
                    {
                        ref readonly var content = ref skip(parts,i);
                        var length = (ushort)content.Length;
                        var name = text.trim(content);
                        seek(cell,i) = new HeaderCell(i,name, length);
                    }
                    dst = new RowHeader(cells, delimiter);
                    return true;
                }
                catch(Exception e)
                {
                    dst = RowHeader.Empty;
                    return e;
                }
            }
        }

        public Index<HeaderCell> Cells {get;}

        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public RowHeader(HeaderCell[] data, string delimiter)
        {
            root.require(data != null, () => "Null header cells");
            Cells = data;
            Delimiter = delimiter;
        }

        [MethodImpl(Inline)]
        public RowHeader(HeaderCell[] data, char delimiter)
        {
            root.require(data != null, () => "Null header cells");
            Cells = data;
            Delimiter = delimiter.ToString();
        }

        public HeaderCell[] Storage
        {
            [MethodImpl(Inline)]
            get => Cells;
        }

        public ref HeaderCell this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public ref HeaderCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static RowHeader Empty
            => new RowHeader(sys.empty<HeaderCell>(), EmptyString);
    }
}