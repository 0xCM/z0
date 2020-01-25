//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static zfunc;

    using dnlib.DotNet;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    partial class Symbolizer
    {
        public sealed class MetadataProvider : IDisposable 
        {
            readonly object lockObj;
            readonly List<ModuleDefMD> modules;

            public MetadataProvider() {
                lockObj = new object();
                modules = new List<ModuleDefMD>();
            }

            public ModuleDef GetModule(string filename) 
            {
                if (string.IsNullOrEmpty(filename))
                    return null;
                lock (lockObj) {
                    foreach (var module in modules) {
                        if (StringComparer.OrdinalIgnoreCase.Equals(module.Location, filename))
                            return module;
                    }
                    var mod = ModuleDefMD.Load(filename);
                    modules.Add(mod);
                    return mod;
                }
            }

            public void Dispose() {
                foreach (var module in modules)
                    module.Dispose();
                modules.Clear();
            }
        }

    }

}