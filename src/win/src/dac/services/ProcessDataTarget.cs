//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Image;

    /// <summary>
    /// A crash dump or live process to read out of.
    /// </summary>
    public struct ProcessDataTarget : IDisposable
    {
        bool _disposed;

        /// <summary>
        /// Gets the list of CLR versions loaded into the process.
        /// </summary>
        public ClrDescription[] ClrDescriptions;

        public ModuleDescription[] Modules;

        public readonly CacheOptions CacheOptions;            

        /// <summary>
        /// Creates a DataTarget from the given reader.
        /// </summary>
        /// <param name="reader">The data reader to use.</param>
        public ProcessDataTarget(ClrDescription[] clrs, ModuleDescription[] modules)
            : this()
        {
            CacheOptions = new CacheOptions();
            Modules = modules;
            ClrDescriptions = clrs;
             _pefileCache = new Dictionary<string, PEImage>(StringComparer.OrdinalIgnoreCase);
            var symPath = Environment.GetEnvironmentVariable("_NT_SYMBOL_PATH");
            //_locator = new Implementation.SymbolServerLocator(symPath);
        }

        readonly Dictionary<string, PEImage> _pefileCache;
           
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