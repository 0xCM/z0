//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public readonly struct LogPaths
    {
        public static LogPaths The => default;
    
        static EnvConfig Settings
            => EnvConfig.Get();

        long LogDate
            => Date.Today.ToDateKey();

        FileExtension DefaultExtension
            => FileExtension.Define("log");

        /// <summary>
        /// Gets the log folder for a specific area
        /// </summary>
        /// <param name="target">The area target</param>
        public FolderPath AreaFolder(ILogTarget target)
            =>  Settings.LogDir(target.Area);

        /// <summary>
        /// Gets the log folder for a specific area and subfolder
        /// </summary>
        /// <param name="target">The area target</param>
        /// <param name="subfolder">The target subfolder</param>
        public FolderPath AreaFolder(ILogTarget target, FolderName subfolder)
            => Settings.LogDir(target.Area, subfolder);

        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FileName file)
            => AreaFolder(LogTarget.Define(area)).CreateIfMissing() + file;

        /// <summary>
        /// Creates a fully-qualified log file path
        /// </summary>
        /// <param name="area">The area</param>
        /// <param name="subject">The area subfolder</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FolderName subject, FileName file)
            => AreaFolder(LogTarget.Define(area), subject).CreateIfMissing() + file;

        public FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        public FolderPath LogDir(LogArea target, FolderName subject)        
            => Settings.LogDir(target, subject);

        public FolderPath DataDir(FolderName subject)
            => Settings.DataDir(subject);

        public FilePath DataPath(FolderName subject, FileName file)
            => Settings.DataDir(subject) + file;

        public FileExtension HexExt
            => FileExtension.Define("hex");

        public FileExtension CilExt
            => FileExtension.Define("il");

        public FileExtension AsmExt
            => FileExtension.Define("asm");

        public FileName AsmDetailFile(OpIdentity m)
            => FileName.Define(m, AsmExt);

        public FileName AsmHexFile(OpIdentity m)
            => FileName.Define(m, HexExt);

        public FileName CilFile(OpIdentity m)
            => FileName.Define(m, CilExt);

        public FolderPath AsmDataRoot
            => Settings.DataDir(FolderName.Define("asm"));

        public FolderPath AsmReportRoot
            => Settings.DataDir(FolderName.Define("asm-reports"));

        public FolderPath AsmDataDir(FolderName subject)
            => AsmDataRoot + subject; 

        public FolderPath AsmDumpDir
            => AsmDataDir(FolderName.Define(".dumps"));

        public FolderPath AsmDataDir(RelativeLocation location)
            => AsmDataRoot +  location;

        /// <summary>
        /// Returns the path to the dissasembly folder for a specified type
        /// </summary>
        /// <param name="t">The source type</param>
        public FolderPath AsmDataDir(Type t)
            => AsmDataDir(FolderName.Define(t.DisplayName().ToLower()));

        /// <summary>
        /// Returns the path to the primary dissasembly file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmInfoPath(Type t, OpIdentity m)
            => AsmDataDir(t) + AsmDetailFile(m);

        /// <summary>
        /// Returns the path to the asm info file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        public FilePath AsmDetailPath(FolderPath dir, OpIdentity m)
            => dir + AsmDetailFile(m);

        /// <summary>
        /// Returns the path to the cil file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        public FilePath CilPath(FolderPath dir, OpIdentity m)
            => dir + CilFile(m);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmHexPath(FolderName subject, OpIdentity m)
            => AsmDataDir(subject) + AsmHexFile(m);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subject">The assembly log subfolder</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmHexPath(FolderPath dir, OpIdentity m)
            => dir + AsmHexFile(m);

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        public FilePath AsmHexPath(Type t, OpIdentity m)
            => AsmDataDir(t) + AsmHexFile(m);

        public FilePath ConfigPath(string name, FileExtension ext = null)
            => Settings.ConfigPath(FileName.Define(name, ext ?? FileExtension.Define("json")));

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="m">The operation identifier</param>
        public FilePath CilPath(Type t, OpIdentity m)
            => AsmDataDir(t) + CilFile(m);

        public static FolderPath ApiSrcDir()
            => Settings.ApiSrcDir();
            
        public static FolderPath ApiSrcDir(FolderName subject)
            => Settings.ApiSrcDir(subject);

        public FilePath LogPath(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath Timestamped(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, string basename, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        public FilePath UniqueLogPath(LogArea area, string basename,  FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, basename, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FolderName subdir, string basename,  FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, basename, ext, elapsed);
        }
    }
}