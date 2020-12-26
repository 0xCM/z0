//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost("tooling", true)]
    public partial struct CmdTools
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static ToolArchive<T> archive<T>(ToolId tool, FS.FolderPath root, ToolArchiveKind kind)
            where T : struct, ITool<T>
                => new ToolArchive<T>(tool, root, kind);

        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="verbs"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec specify(ToolId tool, CmdFlagSpec[] flags, CmdOptionSpec[] options, ToolUsage syntax)
            => new ToolSpec(tool, flags, options, syntax);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec specify<T>(CmdFlagSpec[] flags, CmdOptionSpec[] options, ToolUsage syntax)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags, options, syntax);

        [MethodImpl(Inline), Op]
        public static ToolHelp help(ToolId tool, string src)
            => new ToolHelp(tool, src);

        public static ToolInfo describe<T>()
            where T : struct, ICmdToolModel<T>
                => describe(typeof(T));

        [Projector]
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