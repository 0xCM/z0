//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    public interface IMachineFileArchive : IContextual<IMachineContext>
    {
        TPartCaptureArchive CaptureArchive {get;}

        FilePath[] ExtractFiles
            => CaptureArchive.ExtractFilePaths(Context.Parts);

        FilePath[] ParseFiles 
            => CaptureArchive.ParseFilePaths(Context.Parts);

        FilePath[] ParseFileFilter(PartId part)
            => CaptureArchive.PartParseFilePaths(Context.Parts, part);

        FilePath[] AsmFilePaths(params PartId[] parts)
            => CaptureArchive.AsmFilePaths(parts);

        FilePath[] HexFilePaths(params PartId[] parts)
            => CaptureArchive.HexFilePaths(parts);

        FilePath[] AsmFiles 
            => CaptureArchive.AsmFilePaths(Context.Parts);

        FilePath[] CodeFiles 
            => CaptureArchive.HexFilePaths(Context.Parts);
    }
}