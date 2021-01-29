//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Reflection;

    using static Part;

    public struct TableFormatter<F> : ITableFormatter<F>
        where F : unmanaged
    {
        readonly StringBuilder Target;

        char Delimiter;

        readonly LiteralFieldValues<F> Fields;

        [MethodImpl(Inline)]
        public TableFormatter(StringBuilder dst, char delimiter, LiteralFieldValues<F> fields)
        {
            Target = dst;
            Delimiter = delimiter;
            Fields = fields;
        }

        [MethodImpl(Inline)]
        static ushort width(F field)
            => Scalars.scalar<F,ushort>(field);

        [MethodImpl(Inline)]
        static ushort width(FieldInfo field)
            =>  Scalars.scalar<F,ushort>((F)field.GetRawConstantValue());

        public void EmitEol()
            => Target.Append(Eol);

        public string FormatHeader()
        {
            var dst = text.build();
            var fields = Fields.Fields;
            for(var i=0u; i<fields.Length; i++)
            {
                if(i != 0)
                {
                    dst.Append(Delimiter);
                    dst.Append(Space);
                }

                ref readonly var field = ref z.skip(fields,i);
                dst.Append(field.Name.PadRight(width(field)));
            }
            dst.Append(Eol);
            return dst.ToString();
        }

        public void EmitHeader()
        {
            Target.Append(FormatHeader());
        }

        public void Append(F f, object content)
            => Target.Append(Render(content).PadRight(width(f)));

        public void Delimit(F f, object content)
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(width(f)));
        }

        public void Delimit<T>(F f, T content)
            where T : ITextual
        {
            Target.Append(Delimiter);
            Target.Append(Space);
            Target.Append(Render(content).PadRight(width(f)));
        }

        public string Format()
            => Target.ToString();


        public override string ToString()
            => Format();

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

        static string Render<T>(T content)
            where T : ITextual
                => content?.Format() ?? EmptyString;
    }
}