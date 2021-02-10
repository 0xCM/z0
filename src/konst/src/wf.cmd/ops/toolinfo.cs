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

    partial struct Cmd
    {
        public static ToolInfo toolinfo<T>()
            where T : struct, ICmdToolModel<T>
                => describe(typeof(T));

        [MethodImpl(Inline), Op]
        public static ToolHelp toolhelp(ToolId tool, string src)
            => new ToolHelp(tool, src);

        [Op]
        static ref CmdOptionSpec extract(MemberInfo src, out CmdOptionSpec dst)
        {
            var tag = src.RequiredTag<SlotAttribute>();
            var purpose = src.Tag<MeaningAttribute>().MapValueOrElse(t => (string)t.Content, () => EmptyString);
            dst = Cmd.option(text.ifempty(tag.Name, src.Name), purpose);
            return ref dst;
        }

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
                extract(skip(fields,i), out seek(options,i));

            return dst;
        }
    }
}