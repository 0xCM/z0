//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    using T = CliConstantInfo;

    partial class ImageDataEmitter
    {
        public void EmitConstants()
        {
            var target = Wf.Db().IndexTable<T>();
            var flow = Wf.EmittingTable<T>(target);
            var formatter = Tables.formatter<T>();
            var counter = 0u;
            using var writer = target.Writer();
            writer.WriteLine(formatter.FormatHeader());

            foreach(var part in Wf.Api.Parts)
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