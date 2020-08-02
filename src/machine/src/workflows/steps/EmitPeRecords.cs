//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using F = PeHeaderField;

    public readonly ref struct EmitPeRecords
    {
        readonly WfContext Wf;
        
        readonly EmissionDataType DataType;

        readonly IPart[] Parts;
        
        readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]        
        public EmitPeRecords(WfContext wf, IPart[] src)
        {
            Wf = wf;
            Parts = src;
            TargetPath = wf.AppPaths.ResourceRoot + FileName.Define("z0", "pe.csv");
            DataType = EmissionDataType.Pe;
            Wf.Running(nameof(EmitPeRecords));
        }

        public void Run()
        {
            var formatter = DatasetFormatter<F>.Default;            
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;                                
                var records = ImgMetadataReader.headers(FilePath.Define(assembly.Location));
                var count = records.Length;
                
                for(var i=0; i<count; i++)
                {
                    format(z.skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                }                    
            }  
        }

        public static void format(in PeHeaderRecord src, IDatasetFormatter<F> dst)
        {
            dst.Append(F.FileName, src.FileName);
            dst.Delimit(F.Section, src.Section);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Size, src.Size);
            dst.Delimit(F.EntryPoint, src.EntryPoint);
            dst.Delimit(F.CodeBase, src.CodeBase);
            dst.Delimit(F.Gpt, src.GlobalPointerTable);
            dst.Delimit(F.GptSize, src.GlobalPointerTableSize);
        }

        public void Dispose()
        {
             Wf.Ran(nameof(EmitPeRecords));
        }
    }
}