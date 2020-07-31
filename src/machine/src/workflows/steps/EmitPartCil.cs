//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
        
    public ref struct EmiPartCil
    {
        readonly IAppContext Wf;

        readonly IPart Part;

        readonly FilePath TargetPath;
        
        readonly EmissionDataType DataType;

        uint RecordCount;
        
        [MethodImpl(Inline)]
        public EmiPartCil(IAppContext wf, IPart part, FilePath dst)
        {
             Wf = wf;
             Part = part;
             TargetPath = dst;
             DataType = EmissionDataType.Il;
             EmissionDataType.Il.Emitting(dst,Wf);
             RecordCount = 0;
        }
        
        const string FieldDelimiter = "| ";

        public void Run()
        {

            var id = Part.Id;

            var assembly = Part.Owner;                
            var methods = PartReader.methods(FilePath.Define(assembly.Location));
            RecordCount = (uint)methods.Length;
            
            using var writer = TargetPath.Writer();       
            writer.WriteLine(MethodBodyInfo.Header);      

            for(var i=0u; i<RecordCount; i++)
                writer.WriteLine(skip(methods,i).Format()); 
        }             

        public void Dispose()
        {
            TableEmission.emitted(Wf, PartRecordKind.None, Part.Id, (int)RecordCount);
        }
    }
}