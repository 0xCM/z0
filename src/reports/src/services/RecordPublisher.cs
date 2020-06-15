//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct RecordPublisher : IRecordPublisher
    {
        public static RecordPublisher Service => default(RecordPublisher);

        IPublicationArchive Archive 
            => PublicationArchive.Default;
        
        public void Publish<M,F,R>(M model, F rep, R[] src, char delimiter)
            where M : IDataModel
            where R : IRecord
            where F : unmanaged, Enum
        {
            var dst = Archive.DatasetPath(model.Name);
            var header = RecordHeader.Create<F>();
            using var writer = dst.Writer();
            writer.WriteLine(header.Render(delimiter));
            for(var i=0; i<src.Length; i++)
                writer.WriteLine(src[i].DelimitedText(delimiter));                
        }
    }
}