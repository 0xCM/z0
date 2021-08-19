//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static core;

    public class Generators : AppService<Generators>
    {
        internal new uint TableEmit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct
        {
            return base.TableEmit(src,widths,dst);
        }

        StringTableG _StringTableG;

        protected override void OnInit()
        {
            _StringTableG = new(this);
        }

        public IGenerator<S,T> Generator<S,T>()
        {
            if(typeof(S) == typeof(StringTableSpec) && typeof(T) == typeof(FS.FolderPath))
            {
                return (IGenerator<S,T>)_StringTableG;
            }
            else
                throw Unsupported.define<S>();
        }

        public Outcome Generate<S,T>(S src, T dst)
        {
            var g = Generator<S,T>();
            return g.Generate(src,dst);
        }

        class StringTableG : Generator, IGenerator<StringTableSpec,FS.FolderPath>
        {
            readonly Generators Host;

            internal StringTableG(Generators host)
            {
                Host = host;
            }

            public Outcome Generate(StringTableSpec spec, FS.FolderPath outdir)
            {
                var result = Outcome.Success;
                var csdst = outdir + FS.file(spec.TableName.Format(), FS.Cs);
                var rowdst = outdir + FS.file(spec.TableName.Format(), FS.Csv);
                using var cswriter = csdst.Writer();
                StringTables.gencode(spec, cswriter);
                var count = spec.Entries.Length;
                var buffer = alloc<StringTableRow>(count);
                StringTables.genrows(spec,buffer);
                Host.TableEmit(@readonly(buffer), StringTableRow.RenderWidths, rowdst);
                return result;
            }
        }
    }
}