//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    readonly struct RecordUtilities
    {
        public const string DefaultDelimiter = " | ";

        /// <summary>
        /// Formats a <see cref='RowHeader'/>
        /// </summary>
        /// <param name="src">The source header</param>
        public static string FormatHeader(RowHeader src)
        {
            var dst = text.buffer();
            for(var i=0; i<src.Count; i++)
            {
                dst.Append(src.Delimiter);
                dst.Append(src[i].Format());
            }
            return dst.Emit();
        }

        public static Outcome ParseHeader(string src, char delimiter, out RowHeader dst)
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

        [Op]
        internal static string slot(uint index, RenderWidth width, string delimiter = DefaultDelimiter)
            => delimiter + RP.slot(index, (short)(-(short)width));

        [Op]
        internal static string pattern(Index<CellFormatSpec> cells, string delimiter = DefaultDelimiter)
        {
            var count = cells.Count;
            var view = cells.View;
            var parts = sys.alloc<string>(count);
            for(var i=0u; i<count; i++)
            {
                var cell = skip(view,i);
                seek(parts,i) = slot(i, cell.Width, delimiter);
            }
            return string.Concat(parts);
        }

        /// <summary>
        /// Computes the <see cref='TableId'/> of a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static TableId tableid(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(
                    a => new TableId(src, a.TableId),
                    () => new TableId(src, src.Name));

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a parametrically-identified record type
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static RecordFields fields<T>()
            where T : struct
                => fields(typeof(T));

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static RecordFields fields(Type src)
        {
            var fields = src.DeclaredPublicInstanceFields();
            var count = fields.Length;
            var dst = sys.alloc<RecordField>(count);
            map(fields,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static ref RecordField map(FieldInfo src, ushort index, ref RecordField dst)
        {
            dst.FieldIndex = index;
            dst.Definition = src;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static void map(ReadOnlySpan<FieldInfo> src, Span<RecordField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }
     }
}