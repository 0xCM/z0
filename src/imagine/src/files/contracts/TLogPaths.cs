//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface TLogPaths    
    {        
        FolderPath Root {get;}

        FolderPath DataRoot
            => Root + FolderName.Define("data");
        
        FolderPath AppRoot
            => Root + FolderName.Define("apps");

        FilePath AppMessages(PartId id)
            => AppRoot + FileName.Define(id.Format(), FileExtensions.StdOut);

        FilePath AppErrors(PartId id)
            => AppRoot + FileName.Define(id.Format(), FileExtensions.ErrOut);

        FolderPath TestRoot
            => Root + FolderName.Define("test");

        FilePath TestMessages(PartId id)
            => TestRoot + FileName.Define(id.Format(), FileExtensions.StdOut);
    
        FilePath TestErrors(PartId id)
            => TestRoot + FileName.Define(id.Format(), FileExtensions.ErrOut);

        FolderPath BenchRoot
            => Root + FolderName.Define("bench");

        FolderPath Data(FolderName subfolder)
            => DataRoot + subfolder;
    }

    readonly struct LogPaths : TLogPaths
    {
        public FolderPath Root {get;}        
        
        [MethodImpl(Inline)]
        public static TLogPaths Define(FolderPath root = null)     
            => new LogPaths(root ?? Env.Current.LogDir);

        [MethodImpl(Inline)]
        LogPaths(FolderPath root)
        {
            this.Root = root;
        }
    }
}