//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static zfunc;


    partial class AsmReports
    {
        public static FilePath ResourcePath(AssemblyId id)
            => Paths.AsmReportRoot + FileName.Define(id.Format(), "csv");              

        public static FilePath EmissionsPath(AssemblyId id, AsmEmissionKind kind)
            => Paths.AsmDataRoot + FolderName.Define(".emissions") 
            + (kind == AsmEmissionKind.Imm 
                    ? FileName.Define($"{id.Format()}-imm", FileExtensions.Csv) 
                    : FileName.Define($"{id.Format()}", FileExtensions.Csv));

        static FolderPath LocationRoot
            =>  Paths.AsmReportRoot + FolderName.Define("locations");   
        
        static FileExtension LocationExtension
            => FileExtensions.Csv;

        static FolderPath CaptureRoot
            =>  Paths.AsmReportRoot + FolderName.Define("capture");   

        public static FilePath EncodingExtract(ApiHost host)
            => CaptureRoot + FileName.Define(concat(host.Owner.Format(), dot(), host.Name, dash(), "extract"), FileExtensions.Csv);

        public static FilePath EncodingParse(ApiHost host)
            => CaptureRoot + FileName.Define(concat(host.Owner.Format(), dot(), host.Name, dash(), "parsed"), FileExtensions.Csv);

        public static FilePath EncodingDecoded(ApiHost host)
            => CaptureRoot + FileName.Define(concat(host.Owner.Format(), dot(), host.Name, dash(), "decoded"), FileExtensions.Asm);

        public static FilePath HostLocation(ApiHost host)
            => LocationRoot + FileName.Define(concat(host.Owner.Format(), dash(), host.Name), LocationExtension);

        public static FilePath AssemblyLocation(AssemblyId assembly)
            => LocationRoot + FileName.Define(assembly.Format(), LocationExtension);
    }
}