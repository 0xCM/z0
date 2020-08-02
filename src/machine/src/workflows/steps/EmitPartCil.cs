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
        readonly WfContext Wf;

        readonly IPart Part;

        readonly FilePath TargetPath;
        
        readonly EmissionDataType DataType;

        uint RecordCount;
        
        [MethodImpl(Inline)]
        public EmiPartCil(WfContext wf, IPart part, FilePath dst)
        {
             Wf = wf;
             Part = part;
             TargetPath = dst;
             DataType = EmissionDataType.Il;
             RecordCount = 0;

             Wf.Running(nameof(EmiPartCil));
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
            Wf.Emitted("PartCil", RecordCount, TargetPath);
        }
    }
}