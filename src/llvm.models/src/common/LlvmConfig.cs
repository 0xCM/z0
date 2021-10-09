//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Collections.Generic;

    using K = llvm.LlvmConfigKind;

    public class LlvmConfig
    {
        readonly Dictionary<K,dynamic> Data;

        public LlvmConfig()
        {
            Data = new();
        }

        public void Set(K key, dynamic value)
        {
            Data[key] = value;
        }

        public bool BinDir(out FS.FolderPath dst)
        {
            if(Data.TryGetValue(K.BinDir, out var x))
            {
                dst = (FS.FolderPath)x;
                return true;
            }
            dst = FS.FolderPath.Empty;
            return false;
        }

        public bool LibDir(out FS.FolderPath dst)
        {
            if(Data.TryGetValue(K.LibDir, out var x))
            {
                dst = (FS.FolderPath)x;
                return true;
            }
            dst = FS.FolderPath.Empty;
            return false;
        }
    }
}