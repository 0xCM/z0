//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    public ref struct EmitPartStrings
    {
        readonly IWfPartEmission Wf;

        readonly IPart Part;
        
        readonly FilePath TargetPath;
        
        readonly EmissionDataType DataType;

        public uint Count;
        
        [MethodImpl(Inline)]
        public EmitPartStrings(IWfPartEmission wf, IPart part, FilePath dst)
        {
            Wf = wf;
            Part = part;
            DataType = EmissionDataType.Strings;
            TargetPath = dst;
            Count = 0;
            DataType.Emitting(TargetPath, wf);
        }

        public PartRecordKind DataKind
            => PartRecordKind.String;                

        ReadOnlySpan<StringValueRecord> UserStrings(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadUserStrings();        
        }

        ReadOnlySpan<StringValueRecord> SysStrings(IPart part)
        {
            var srcPath = Wf.PartPath(part);              
            using var reader = PartReader.open(srcPath);
            return reader.ReadStrings();        
        }

        void Emit(ReadOnlySpan<StringValueRecord> src, StreamWriter writer)
        {
            var target = PartRecords.formatter(Wf.DataTypes.Strings);
            for(var i=0u; i<src.Length; i++)
                PartRecords.format(skip(src,i), target);
            writer.Write(target.Render());            
        }
        public void Run()
        {
            var target = PartRecords.formatter(Wf.DataTypes.Strings);
            
            using var writer = TargetPath.Writer();
            target.EmitHeader();            
            var j = 0;

            var data = SysStrings(Part);
            for(var i=0u; i<data.Length; i++, j++)
                PartRecords.format(skip(data,i), target);

            data = UserStrings(Part);
            for(var i=0u; i<data.Length; i++, j++)
                PartRecords.format(skip(data,i), target);
                        
            writer.Write(target.Render());            

            // for(var i=0u; i<count; i++)
            //     PartRecords.format(skip(data,i), target);
            
            // using var writer = TargetPath.Writer();
            // writer.Write(target.Render());

            Count += (uint)j;
            
        }

        public void Dispose()
        {
            DataEmitters.emitted(Wf, DataKind, Part.Id, (int)Count);
         }
    }
}