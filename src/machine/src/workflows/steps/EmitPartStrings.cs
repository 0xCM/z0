//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitPartStringsStep;
    using static z;
    
    public ref struct EmitPartStrings
    {
        /// <summary>
        /// Indicates the number of records emitted after running
        /// </summary>
        public uint EmissionCount;

        readonly IWfContext Wf;
        
        readonly CorrelationToken Ct;

        readonly IPart Part;
        
        readonly bool UserStrings;

        readonly FilePath TargetPath;
                
        [MethodImpl(Inline)]
        public EmitPartStrings(IWfContext wf, IPart part, bool user, FilePath dst, CorrelationToken ct)
        {
            Wf = wf;
            Part = part;
            Ct = ct;            
            TargetPath = dst;
            UserStrings = user;
            EmissionCount = 0;
            Wf.Created(StepName, Ct);
        }
        
        public void Run()
        {
            Wf.Emitting(StepName, DataType, TargetPath, Ct);

            var data = ReadData();            
            EmissionCount = (uint)data.Length;

            var target = PartRecords.formatter(ImageRecords.Strings);        
            using var writer = TargetPath.Writer();
            target.EmitHeader();            
            
            for(var i=0u; i<EmissionCount; i++)
                PartRecords.format(skip(data,i), target);                        
            writer.Write(target.Render());
            
            Wf.Emitted(StepName, DataType, EmissionCount, TargetPath, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);        
        }

        ReadOnlySpan<ImgStringRecord> ReadData()
            => UserStrings ? ReadUserStrings(Part) : ReadSystemStrings(Part);            

        ReadOnlySpan<ImgStringRecord> ReadUserStrings(IPart part)
        {
            var srcPath = part.PartPath();
            using var reader = PeMetaReader.open(srcPath);
            return reader.ReadUserStrings();        
        }

        ReadOnlySpan<ImgStringRecord> ReadSystemStrings(IPart part)
        {
            var srcPath = part.PartPath();
            using var reader = PeMetaReader.open(srcPath);
            return reader.ReadStrings();        
        }
    }
}