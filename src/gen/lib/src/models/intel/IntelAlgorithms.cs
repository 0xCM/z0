//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;

    using static Part;

    using M = IntelIntrinsicsDoc;

    public interface IIntelAlgorithms
    {

    }

    [ApiHost]
    public sealed class IntelAlgorithms : WfService<IntelAlgorithms,IIntelAlgorithms>, IIntelAlgorithms
    {
        [Op]
        public static string fxlabel(string name)
            => name.StartsWith("_mm512") ? "_mm512"  :
            name.StartsWith("_mm256") ? "_mm256" :
            (name.StartsWith("_mm_") || name.StartsWith("_MM_")) ? "_mm" :
            name.StartsWith("_bnd") ? "_bnd" :
            name.StartsWith("_cast") ? "_cast" :
            name.StartsWith("_cvt") ? "_cvt" :
            "_unknown";

        static string[] TechLables
            => new string[]{"AVX-512","AVX","AMX", "SVML", "AVX2"};

        [Op]
        public static FS.FileName filename(M.intrinsic src, FS.FileExt kind)
        {
            var identifier = src.identifier;
            if(TechLables.Contains(src.tech))
                return FS.file("_" + src.tech, kind);
            else if(src.tech == "AVX-512/KNC")
                return FS.file("_AVX-512-KNC", kind);
            else if(src.instructions.Count == 0)
                return FS.file("_Other", kind);
            else
                return FS.file($"{identifier[0]}", kind);
        }

        [Op]
        static string[] lines(string src, uint width)
        {
            var dst = root.list<string>();
            var parts = memory.span(src.SplitClean(Space));
            var count = parts.Length;
            var current = EmptyString;
            for(var i=0u; i<count; i++)
            {
                ref readonly var part = ref memory.skip(parts, i);
                var tmp = current + part;
                if(tmp.Length > width)
                {
                    dst.Add(current);
                    current = part;
                }
                else
                    current = current + Space + part;
            }

            dst.Add(Space + current);

            return dst.ToArray();
        }

        [Op]
        static string label(M.intrinsic src)
            => text.concat("## ",
                src.instructions.Count != 0
                ? text.concat(src.identifier, Space, Chars.Dash, Space, src.name)
                : src.identifier);

        [Op]
        public void Emit()
        {
            var list = IntelIntrinsicsDocReader.read();
            var target = WfShell.paths().ResourceRoot + FS.folder("intrinsics") + FS.folder("algorithms");
            var kind = FS.ext("md");
            var folder = IntelIntrinsicsDocReader.folder(kind);
            target.Clear();

            term.print($"Emitting intrinsics algorithms");

            var pagewidth = (uint)RP.PageBreak120.Length;
            var writers = root.dict<string,StreamWriter>();
            for(var i=0; i<list.Length; i++)
            {
                ref readonly var current = ref list[i];

                var name = filename(current, kind);
                var writer = default(StreamWriter);
                if(!writers.TryGetValue(name.Name, out writer))
                {
                    writer = (target + name).Writer();
                    var header = text.concat("#", Space, name.WithoutExtension);
                    writer.WriteLine(header);
                    writers.Add(name.Name, writer);
                }

                var description = (current.description.Content ?? EmptyString).Trim();
                var lined = lines(description, pagewidth);
                var described = text.build();
                for(var j=0; j<lined.Length; j++)
                {
                    var l = lined[j];
                    var next = l.Trim();
                    if(j != lined.Length - 1)
                        described.AppendLine(next);
                    else
                        described.Append(next);
                }

                var algorithm = (current.operation.Content ?? EmptyString).Trim().Replace("\t", "    ");
                writer.WriteLine();
                writer.WriteLine(label(current));
                writer.WriteLine();

                if(current.instructions.Count != 0)
                {
                    var info = "| ";
                    for(var mm = 0; mm < current.instructions.Count; mm++)
                    {
                        var x = current.instructions[mm];
                        info = info + x.xed;
                        if(mm != current.instructions.Count - 1)
                            info = info + RP.SpacePipe;
                    }
                    writer.WriteLine(info);
                    writer.WriteLine();
                }

                writer.WriteLine(RP.PageBreak120);
                writer.WriteLine(described);
                writer.WriteLine();
                if(text.nonempty(algorithm))
                {
                    writer.WriteLine(text.bracket("algorithm"));
                    writer.WriteLine();
                    writer.WriteLine(algorithm);
                }
                else
                {
                    writer.WriteLine(text.bracket("missing"));
                }

                writer.WriteLine();
                writer.WriteLine(RP.PageBreak120);
            }

            term.print($"Emitted {list.Length} intrinsics algorithms");

            root.iter(writers.Values, w => w.Dispose());
        }
    }
}