//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    using api = Table;

    public struct RowFormatter
    {
        readonly Type TableType;

        readonly TableFields Fields;

        readonly TableSpan<ushort> Widths;

        readonly StringBuilder Target;

        readonly char Delimiter;

        [MethodImpl(Inline)]
        public RowFormatter(Type table, TableFields fields, StringBuilder dst = null, char delimiter = FieldDelimiter)
        {
            TableType = table;
            Fields = fields;
            Target = dst;
            Delimiter = delimiter;
            Widths = fields.Storage.Select(f => f.RenderWidth);
        }

        public void EmitEol()
            => Target.Append(Eol);

        public RowFormatter Reset()
        {
            Target.Clear();
            return this;
        }

        public void EmitRow(object src)
            => api.render(Fields,src,Target);

        public string FormatHeader()
        {
            var dst = text.build();
            var view = Fields.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                dst.Append(Delimiter);
                dst.Append(Space);
                ref readonly var field = ref skip(view,i);
                dst.Append(field.Name.PadRight(Widths[i]));
            }
            return dst.ToString();
        }

        public void EmitHeader()
        {
            Target.Append(FormatHeader());
            EmitEol();
        }

        void Append(ushort width, object src)
            => Target.Append(Render(src).PadRight(width));

        void Delimit(ushort width, object src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(src).PadRight(width));
        }

        void Delimit<E>(ushort width, EnumValue<E> src)
            where E : unmanaged, Enum
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.Format().PadRight(width));
        }

        void Delimit(ushort width, byte src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        void Delimit(ushort width, ushort src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        void Delimit(ushort width, uint src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        void Delimit(ushort width, ulong src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(src.ToString().PadRight(width));
        }

        void Delimit(ushort width, string src)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append((src ?? EmptyString).PadRight(width));
        }

        void Delimit<C>(ushort width, C content)
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
        public string Format()
            => Target.ToString();

        public override string ToString()
            => Format();
    }
}