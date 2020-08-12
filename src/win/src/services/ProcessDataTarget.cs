//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    using Z0.Image;
    using Z0.MS;

    
    /// <summary>
    /// A crash dump or live process to read out of.
    /// </summary>
    public struct ProcessDataTarget : IDisposable
    {
        bool _disposed;

        public ClrProcessData Data;

        /// <summary>
        /// Gets the list of CLR versions loaded into the process.
        /// </summary>
        public ClrDescription[] ClrDescriptions => Data.Runtimes;

        public ProcessModuleInfo[] Modules => Data.Modules;

        public readonly ProcessCacheOptions CacheOptions;            

        readonly Dictionary<string, PEImage> _pefileCache;

        /// <summary>
        /// Creates a DataTarget from the given reader.
        /// </summary>
        /// <param name="reader">The data reader to use.</param>
        public ProcessDataTarget(ClrDescription[] runtimes, ProcessModuleInfo[] modules)
            : this()
        {
            CacheOptions = new ProcessCacheOptions();
            Data = new ClrProcessData(runtimes,modules);            
             _pefileCache = new Dictionary<string, PEImage>(StringComparer.OrdinalIgnoreCase);
            var symPath = Environment.GetEnvironmentVariable("_NT_SYMBOL_PATH");
            //_locator = new Implementation.SymbolServerLocator(symPath);
        }
           
        public IBinaryLocator BinaryLocator
            => default;

        public void Dispose()
        {
            if (!_disposed)
            {

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
                throw new ObjectDisposedException(nameof(ProcessDataTarget));

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
    }
}