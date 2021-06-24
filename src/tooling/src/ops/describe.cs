//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct ToolCmd
    {
        public static ToolInfo describe<T>()
            where T : struct, IToolCmdModel<T>
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
            dst.ToolId = Cmd.toolid(src);
            if(!tag)
            {
                dst.ToolName = src.Name;
                dst.Syntax = EmptyString;
            }
            else
            {
                var attrib = tag.Value;
                dst.ToolName = attrib.ToolName;
                dst.Syntax = attrib.UsageSyntax;
            }

            var fields = @readonly(src.InstanceFields().Tagged<SlotAttribute>());
            var kFields = fields.Length;
            var buffer = alloc<CmdOptionSpec>(kFields);

            dst.Options = buffer;
            var options = span(buffer);
            for(ushort i=0; i<kFields; i++)
                derive(skip(fields,i), out seek(options,i));

            return dst;
        }

        [Op]
        static ref CmdOptionSpec derive(MemberInfo src, out CmdOptionSpec dst)
        {
            var tag = src.RequiredTag<SlotAttribute>();
            var purpose = src.Tag<MeaningAttribute>().MapValueOrElse(t => (string)t.Content, () => EmptyString);
            dst = Cmd.option(TextTools.ifempty(tag.Name, src.Name), purpose);
            return ref dst;
        }
    }
}