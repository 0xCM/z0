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

    public struct RowFormatter<T>
        where T : struct
    {
        readonly StringBuilder Target;

        readonly TableFields Fields;

        readonly byte[] Widths;

        char Delimiter;

        [MethodImpl(Inline)]
        public RowFormatter(TableFields fields, StringBuilder dst, char delimiter)
        {
            Fields = fields;
            Target = dst;
            Delimiter = delimiter;
            Widths = sys.alloc<byte>(Fields.Length);
            for(var i=0; i<Widths.Length; i++)
                Widths[i] = 10;
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

        public string FormatHeader(ReadOnlySpan<byte> widths)
        {
            var dst = text.build();
            var view = Fields.View;
            var count = view.Length;
            for(var i=0u; i<count; i++)
            {
                dst.Append(Delimiter);
                dst.Append(Space);
                ref readonly var field = ref z.skip(view,i);
                dst.Append(field.FieldName.Format().PadRight(z.skip(widths,i)));
            }
            return dst.ToString();
        }

        public void EmitHeader(ReadOnlySpan<byte> widths)
        {
            Target.Append(FormatHeader(widths));
            EmitEol();
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
        public string Format()
            => Target.ToString();

        public override string ToString()
            => Format();
    }
}