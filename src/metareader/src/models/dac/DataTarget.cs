//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using Z0.Image;
    using Z0.MS;

    using static ClrDataModel;

    /// <summary>
    /// A crash dump or live process to read out of.
    /// </summary>
    public sealed class DataTarget : IDisposable
    {
        private IBinaryLocator _locator;

        private bool _disposed;

        private ImmutableArray<ClrInfo> _clrs;

        private ModuleInfo[] _modules;

        private readonly Dictionary<string, PEImage> _pefileCache 
            = new Dictionary<string, PEImage>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Gets the data reader for this instance.
        /// </summary>
        public IDataReader DataReader { get; }

        public CacheOptions CacheOptions { get; } 
            = new CacheOptions();

        /// <summary>
        /// Gets or sets instance to manage the symbol path(s).
        /// </summary>
        public IBinaryLocator BinaryLocator
        {
            get
            {
                if (_locator is null)
                {
                    string symPath = Environment.GetEnvironmentVariable("_NT_SYMBOL_PATH");
                    _locator = new Implementation.SymbolServerLocator(symPath);
                }

                return _locator;
            }

            set => _locator = value;
        }

        /// <summary>
        /// Creates a DataTarget from the given reader.
        /// </summary>
        /// <param name="reader">The data reader to use.</param>
        public DataTarget(IDataReader reader)
        {
            DataReader = reader ?? throw new ArgumentNullException(nameof(reader));

            DebugOnlyLoadLazyValues();
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                DataReader.Dispose();

                lock (_pefileCache)
                {
                    foreach (PEImage img in _pefileCache.Values)
                        img?.Stream.Dispose();

                    _pefileCache.Clear();
                }

                _disposed = true;
            }
        }

        public PEImage LoadPEImage(string path)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(DataTarget));

            if (string.IsNullOrEmpty(path))
                return null;

            PEImage result;

            lock (_pefileCache)
            {
                if (_pefileCache.TryGetValue(path, out result))
                    return result;
            }

            Stream stream = File.OpenRead(path);
            result = new PEImage(stream);

            if (!result.IsValid)
            {
                stream.Dispose();
                result = null;
            }

            lock (_pefileCache)
            {
                // We may have raced with another thread and that thread put a value here first
                if (_pefileCache.TryGetValue(path, out PEImage cached) && cached != null)
                {
                    result?.Dispose(); // We don't need this instance now.
                    return cached;
                }

                return _pefileCache[path] = result;
            }
        }

        [Conditional("DEBUG")]
        private void DebugOnlyLoadLazyValues()
        {
            // Prefetch these values in debug builds for easier debugging
            GetOrCreateClrVersions();
            EnumerateModules();
        }

        /// <summary>
        /// Gets the list of CLR versions loaded into the process.
        /// </summary>
        public ImmutableArray<ClrInfo> ClrVersions 
            => GetOrCreateClrVersions();

        private ImmutableArray<ClrInfo> GetOrCreateClrVersions()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(DataTarget));

            if (!_clrs.IsDefault)
                return _clrs;

            Architecture arch = DataReader.Architecture;
            ImmutableArray<ClrInfo>.Builder versions = ImmutableArray.CreateBuilder<ClrInfo>(2);
            foreach (ModuleInfo module in EnumerateModules())
            {
                if (!ClrInfoProvider.IsSupportedRuntime(module, out var flavor, out var platform))
                    continue;

                string dacFileName = ClrInfoProvider.GetDacFileName(flavor, platform);
                string dacLocation = Path.Combine(Path.GetDirectoryName(module.FileName)!, dacFileName);

                VersionInfo version = module.Version;
                string dacAgnosticName = ClrInfoProvider.GetDacRequestFileName(flavor, arch, arch, version, platform);
                string dacRegularName = ClrInfoProvider.GetDacRequestFileName(flavor, IntPtr.Size == 4 ? Architecture.X86 : Architecture.Amd64, arch, version, platform);

                DacInfo dacInfo = new DacInfo(DataReader, dacAgnosticName, arch, 0, module.FileSize, module.TimeStamp, dacRegularName, module.Version);
                versions.Add(new ClrInfo(this, flavor, module, dacInfo, dacLocation));
            }

            _clrs = versions.MoveOrCopyToImmutable();
            return _clrs;
        }

        /// <summary>
        /// Enumerates information about the loaded modules in the process (both managed and unmanaged).
        /// </summary>
        public IEnumerable<ModuleInfo> EnumerateModules()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(DataTarget));

            if (_modules != null)
                return _modules;

            char[] invalid = Path.GetInvalidPathChars();
            _modules = DataReader.EnumerateModules().Where(m => m.FileName != null && m.FileName.IndexOfAny(invalid) < 0).ToArray();
            Array.Sort(_modules, (a, b) => a.ImageBase.CompareTo(b.ImageBase));
            return _modules;
        }

        /// <summary>
        /// Gets a set of helper functions that are consistently implemented across all platforms.
        /// </summary>
        public static WindowsFunctions PlatformFunctions { get; } 
            = new WindowsFunctions();
   }
}