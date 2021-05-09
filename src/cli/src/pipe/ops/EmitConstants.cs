//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class ImageMetaPipe
    {
        public void EmitConstants()
        {
            var target = Db.IndexTable<ConstantFieldInfo>();
            var flow = Wf.EmittingTable<ConstantFieldInfo>(target);
            var formatter = Tables.formatter<ConstantFieldInfo>();
            var counter = 0u;
            using var writer = target.Writer();
            writer.WriteLine(formatter.FormatHeader());

            foreach(var part in Wf.ApiCatalog.Parts)
            {
                try
                {
                    using var reader = PeTableReader.open(part.PartPath());
                    var constants = reader.constants(ref counter);
                    var count = constants.Length;
                    for(var i=0; i<count; i++)
                        writer.WriteLine(formatter.Format(skip(constants,i)));
                }
                catch(Exception e)
                {
                    Wf.Error(e);
                }
            }

            Wf.EmittedTable(flow, counter);
        }
    }
}