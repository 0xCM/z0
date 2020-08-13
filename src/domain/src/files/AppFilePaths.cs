//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    using FS = FileSystem;

    public readonly struct AppFilePaths
    {   
        public static AppFilePaths create(in AppPathSettings settings, PartId? part = null)
            => new AppFilePaths(settings, part);        

        const string AsmFolderName = "asm";

        const string HexFolderName = "code";

        const string XCsvFolderName = "extracted";

        const string PCsvFolderName = "parsed";

        const string ImmFolderName = "imm";

        const string CaptureFolderName = "capture";

        public readonly FS.FolderPath CaptureRoot;

        readonly FS.FolderName AppFolder;        
                
        [MethodImpl(Inline)]
        public AppFilePaths(in AppPathSettings paths, PartId? app)
        {
            AppFolder = FS.folder(app != null ?app.Value.Format() : AppBase.Default.AppName);
            CaptureRoot = new FS.FolderPath(text.format("{0}/{1}/{2}/{3}", paths.Logs, "apps", AppFolder, "capture"));
        } 

        FS.FolderName CaptureFolder 
            => FS.folder(CaptureFolderName);

        FS.FolderName AsmFolder 
            => FS.folder(AsmFolderName);
        
        FS.FolderName HexFolder 
            => FS.folder(HexFolderName);

        FS.FolderName XCsvFolder 
            => FS.folder(XCsvFolderName);

        FS.FolderName PCsvFolder 
            => FS.folder(PCsvFolderName);

        FS.FolderName ImmFolder 
            => FS.folder(ImmFolderName);
        

        public FS.FolderPath AsmDir
            => CaptureRoot + AsmFolder;    

        public FS.FolderPath XCsvDir
            => CaptureRoot + XCsvFolder;    

        public FS.FolderPath PCsvDir
            => CaptureRoot + PCsvFolder;    

        public FS.FolderPath HexDir
            => CaptureRoot + PCsvFolder;    

        public FS.FolderPath ImmDir
            => CaptureRoot + ImmFolder;
    }    
}