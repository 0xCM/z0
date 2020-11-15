//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;
    using static z;

    partial struct Tooling
    {
        public static ToolModel model<T>()
            where T : struct, IToolModel<T>
                => model(typeof(T));

        /// <summary>
        /// Derives a <see cref='ToolModel'/> from a specifying record
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static ToolModel model(Type src)
        {
            var dst = new ToolModel();
            var tag = src.Tag<ToolAttribute>();
            if(!tag)
            {
                dst.Name = src.Name;
                dst.Delimiter = delimiter(Chars.Dash);
                dst.Usage = EmptyString;
            }
            else
            {
                var attrib = tag.Value;
                dst.Name = attrib.ToolName;
                dst.Delimiter = delimiter(attrib.OptionDelimiter);
                dst.Usage = attrib.UsageSyntax;
            }

            var fields = @readonly(src.InstanceFields().Tagged<SlotAttribute>());
            var props = @readonly(src.InstanceProperties().Tagged<SlotAttribute>());
            var kFields = fields.Length;
            var kProps = props.Length;

            var buffer = alloc<ToolOption>(kFields + kProps);
            dst.Options = buffer;
            var options = span(buffer);
            for(ushort i=0; i<kFields; i++)
                extract(skip(fields,i), i, out seek(options,i));
            for(ushort i=0; i<kProps; i++)
                extract(skip(props,i), i, out seek(options,i));

            return dst;
        }
    }
}