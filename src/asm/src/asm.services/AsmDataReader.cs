//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    public sealed class AsmDataReader : AsmWfService<AsmDataReader>
    {
        public Index<AsmCallRow> LoadCallRows()
        {
            var files = Db.TableDir<AsmCallRow>().AllFiles.View;
            var dst = root.list<AsmCallRow>();
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var doc = TextDocs.parse(file);
                if(doc)
                {
                    var rows = doc.Value.Rows;
                    var kRows = rows.Length;
                    for(var j = 0; j<kRows; j++)
                    {
                        ref readonly var row = ref skip(rows,j);
                        if(row.CellCount == AsmCallRow.FieldCount)
                        {
                            var cells = row.Cells.View;
                            var record = new AsmCallRow();
                            var k = 0;
                            Records.parse(skip(cells, k++).Text, out record.Source);
                            Records.parse(skip(cells, k++).Text, out record.Target);
                            Records.parse(skip(cells, k++).Text, out record.InstructionSize);
                            Records.parse(skip(cells, k++).Text, out record.TargetOffset);
                            record.Instruction = skip(cells, k++).Text;
                            Records.parse(skip(cells, k).Text, out record.Encoded);
                            dst.Add(record);
                        }
                    }
                }
            }
            return dst.ToArray();
        }
    }
}