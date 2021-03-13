//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;

    using api = Table;

    public struct RowFormatter<T>
        where T : struct
    {
        readonly Type TableType;

        readonly TableFields Fields;

        readonly StringBuilder Target;

        readonly char Delimiter;

        [MethodImpl(Inline)]
        public RowFormatter(TableFields fields, StringBuilder dst = null, char delimiter = FieldDelimiter)
        {
            TableType = typeof(T);
            Fields = fields;
            Target = dst ?? text.build();
            Delimiter = delimiter;
        }

        public void EmitEol()
            => Target.Append(Eol);

        public RowFormatter<T> Reset()
        {
            Target.Clear();
            return this;
        }

        public string Render(bool reset = true)
        {
            var content = Target.ToString();
            if(reset)
                Target.Clear();
            return content;
        }

        public string FormatHeader()
        {
            var dst = text.build();
            header(Fields, Delimiter, dst);
            return dst.ToString();
        }

        static void header(in TableFields src, char Delimiter, StringBuilder dst)
        {
            var view = src.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref memory.skip(view,i);
                dst.Append(Delimiter);
                dst.Append(Space);
                dst.Append(field.Name.PadRight(field.RenderWidth - 2));
            }
        }

        public void EmitHeader()
        {
            Target.Append(FormatHeader());
            EmitEol();
        }

        public void EmitRow(in T src, bool eol)
            => api.render(Fields, src, Target, eol);

        public string FormatRow(in T src, bool clear = true)
        {
            EmitRow(src, false);

            var row = Target.ToString();
            if(clear)
                Reset();
            return row;
        }

        public void Append(ushort width, object src)
            => Target.Append(Render(src).PadRight(width));

        void Delimit(ushort width, object src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(src).PadRight(width));
        }

        public void Delimit<E>(ushort width, EnumValue<E> src)
            where E : unmanaged, Enum
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.Format().PadRight(width));
        }

        public void Delimit(ushort width, byte src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        public void Delimit(ushort width, ushort src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        public void Delimit<X>(X src)
            where X : ITextual
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.Format());
        }

        public void Delimit(ushort width, uint src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        public void Delimit(ushort width, ulong src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        public void Delimit(ushort width, string src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append((src ?? EmptyString).PadRight(width));
        }

        public void Delimit<C>(ushort width, C content)
            where C : ITextual
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(width));
        }

        static string Render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return Render(t);
            else
                return content.ToString();
        }

        static string Render<C>(C content)
            where C : ITextual
                => content?.Format() ?? EmptyString;

        [MethodImpl(Inline)]
        public string Format()
            => Target.ToString();

        public override string ToString()
            => Format();
    }
}