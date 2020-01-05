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
    
        static LogSettings Settings
            => LogSettings.Get();

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
        /// <param name="subfolder">The area subfolder</param>
        /// <param name="file">The filename</param>
        public FilePath TargetPath(LogArea area, FolderName subfolder, FileName file)
            => AreaFolder(LogTarget.Define(area), subfolder).CreateIfMissing() + file;

        public FolderPath LogDir(LogArea target)        
            => Settings.LogDir(target);

        public FolderPath LogDir(LogArea target, FolderName subdir)        
            => Settings.LogDir(target, subdir);

        public FileExtension AsmHexExt
            => FileExtension.Define("hex");

        public FileExtension CilExt
            => FileExtension.Define("il");

        public FileExtension AsmInfoExt
            => FileExtension.Define("asm");

        public FileName AsmInfoFile(string opcode)
            => FileName.Define(opcode, AsmInfoExt);

        public FileName AsmHexFile(string opcode)
            => FileName.Define(opcode, AsmHexExt);

        public FileName CilFile(string opcode)
            => FileName.Define(opcode, CilExt);

        public FolderPath AsmDataRoot
            => Settings.DataDir(FolderName.Define("asm"));

        public FolderPath AsmDataDir(FolderName subfolder)
            => Settings.DataDir(FolderName.Define("asm")) + subfolder;

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
        public FilePath AsmInfoPath(Type t, Moniker m)
            => AsmDataDir(t) + AsmInfoFile(m);

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="opcode">The operation identifier</param>
        public FilePath AsmHexPath(Type t, string opcode)
            => AsmDataDir(t) + AsmHexFile(opcode);

        /// <summary>
        /// Returns the path to the hex data file for a specified type and operation name
        /// </summary>
        /// <param name="t">The source type</param>
        /// <param name="opcode">The operation identifier</param>
        public FilePath CilPath(Type t, string opcode)
            => AsmDataDir(t) + CilFile(opcode);

        /// <summary>
        /// Returns the path to the asm info file for an identified operation
        /// </summary>
        /// <param name="subfolder">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        public FilePath AsmInfoPath(FolderName subfolder, Moniker m)
            => AsmDataDir(subfolder) + AsmInfoFile(m);

        /// <summary>
        /// Returns the path to the hex data file for an identified operation
        /// </summary>
        /// <param name="subfolder">The assembly log subfolder</param>
        /// <param name="opcode">The operation identifier</param>
        public FilePath AsmHexPath(FolderName subfolder, string opcode)
            => AsmDataDir(subfolder) + AsmHexFile(opcode);

        /// <summary>
        /// Returns the path to the cil file for an identified operation
        /// </summary>
        /// <param name="subfolder">The assembly log subfolder</param>
        /// <param name="m">The operation moniker</param>
        public FilePath CilPath(FolderName subfolder, Moniker m)
            => AsmDataDir(subfolder) + CilFile(m);

        public FilePath LogPath(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext = null)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{ext ?? DefaultExtension}");

        public FilePath LogPath(ILogTarget target, FileExtension ext = null)
            => LogDir(target.Area) + FileName.Define($"{target.Name}.{ext ?? DefaultExtension}");

        public FilePath LogPath(ILogTarget target, FolderName subdir, FileExtension ext = null)
            => LogDir(target.Area,subdir) + FileName.Define($"{target.Name}.{ext ?? DefaultExtension}");

        public FilePath DatedLogPath(LogArea area, string basename, FileExtension ext = null)
            => LogDir(area) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

        public FilePath DatedLogPath(LogArea area, FolderName subdir, string basename,  FileExtension ext = null)
            => LogDir(area,subdir) + FileName.Define($"{basename}.{LogDate}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{area}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, FolderName subdir, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, string basename, FileExtension ext, long timestamp)
            => LogDir(area) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(LogArea area, FolderName subdir, string basename, FileExtension ext, long timestamp)
            => LogDir(area, subdir) + FileName.Define($"{basename}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(ILogTarget target, FileExtension ext, long timestamp)
            => LogDir(target.Area) + FileName.Define($"{target.Name}.{timestamp}.{ext ?? DefaultExtension}");

        FilePath LogPath(ILogTarget target, FolderName subdir,  FileExtension ext, long timestamp)
            => LogDir(target.Area, subdir) + FileName.Define($"{target.Area}.{target.Name}.{timestamp}.{ext ?? DefaultExtension}");

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

        public FilePath UniqueLogPath(LogArea area, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, ext, elapsed);
        }

        public FilePath UniqueLogPath(LogArea area, FolderName subdir, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(area, subdir, ext, elapsed);
        }

        public FilePath UniqueLogPath(ILogTarget target, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(target, ext, elapsed);
        }

        public FilePath UniqueLogPath(ILogTarget target, FolderName subdir, FileExtension ext = null)
        {
            var first = new DateTime(2019,1,1);
            var current = now();
            var elapsed = (long) (current - first).TotalMilliseconds;
            return LogPath(target, subdir, ext, elapsed);
        }
    }
}