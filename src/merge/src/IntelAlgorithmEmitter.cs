//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;

    using static Konst;

    using M = IntelIntrinsicsDoc;

    public readonly struct IntelAlgorithmEmitter
    {
        public static IntelAlgorithmEmitter create()
            => default;

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

        public static FileName filename(M.intrinsic src, FileExtension kind)
        {
            var identifier = src.identifier;
            if(TechLables.Contains(src.tech))
                return FileName.define("_" + src.tech, kind);
            else if(src.tech == "AVX-512/KNC")
                return FileName.define("_AVX-512-KNC", kind);
            else if(src.instructions.Count == 0)
                return FileName.define("_Other", kind);
            else
                return FileName.define($"{identifier[0]}", kind);
        }

        static string[] lines(string src, uint width)
        {
            var dst = z.list<string>();
            var parts = z.span(src.SplitClean(Space));
            var count = parts.Length;
            var current = EmptyString;
            for(var i=0u; i<count; i++)
            {
                ref readonly var part = ref z.skip(parts, i);
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

        static string label(M.intrinsic src)
            => text.concat("## ",
                src.instructions.Count != 0
                ? text.concat(src.identifier, Space, Chars.Dash, Space, src.name)
                : src.identifier);

        public void Emit()
        {
            var list = IntelIntrinsicsDocReader.read();
            var target = (WfPaths.Default.ResourceRoot + FolderName.Define("intrinsics")) + FolderName.Define("algorithms");
            var kind = FileExtension.Define("md");
            var folder = IntelIntrinsicsDocReader.folder(kind);
            target.Clear();

            term.print($"Emitting intrinsics algorithms");

            var pagewidth = (uint)text.PageBreak.Length;
            var writers = z.dict<string,StreamWriter>();
            for(var i=0; i< list.Length; i++)
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
                            info = info + SpacePipe;
                    }
                    writer.WriteLine(info);

                    writer.WriteLine();
                }

                writer.WriteLine(text.PageBreak);
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
                writer.WriteLine(text.PageBreak);
            }

            term.print($"Emitted {list.Length} intrinsics algorithms");

            z.iter(writers.Values, w => w.Dispose());
        }
    }
}