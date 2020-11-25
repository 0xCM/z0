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
        public static ToolInfo describe<T>()
            where T : struct, IToolModel<T>
                => describe(typeof(T));

        /// <summary>
        /// Derives a <see cref='ToolInfo'/> from a specifying record
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static ToolInfo describe(Type src)
        {
            var dst = new ToolInfo();
            var tag = src.Tag<ToolAttribute>();
            dst.ToolId = toolid(src);
            if(!tag)
            {
                dst.Name = src.Name;
                dst.Usage = EmptyString;
            }
            else
            {
                var attrib = tag.Value;
                dst.Name = attrib.ToolName;
                dst.Usage = attrib.UsageSyntax;
            }

            var fields = @readonly(src.InstanceFields().Tagged<SlotAttribute>());
            var kFields = fields.Length;
            var buffer = alloc<CmdOptionSpec>(kFields);

            dst.Options = buffer;
            dst.Verbs = sys.empty<ToolVerb>();

            var options = span(buffer);
            for(ushort i=0; i<kFields; i++)
                extract(skip(fields,i), out seek(options,i));

            return dst;
        }
    }
}