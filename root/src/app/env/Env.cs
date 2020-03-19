//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct EnvVarNames
    {
        public const string LogDir = "ZLogs";
        
        public const string DevDir = "ZDev";
    }

    public readonly struct Env
    {
        public static Env Current
        {
            get
            {
                var log = EnvVar.Read(EnvVarNames.LogDir).Transform(FolderPath.Define);
                var dev = EnvVar.Read(EnvVarNames.DevDir).Transform(FolderPath.Define);
                return new Env(log,dev);
            }
        }

        Env(EnvVar<FolderPath> log, EnvVar<FolderPath> dev)
        {
            this.LogDir = log;
            this.DevDir = dev;
        }

        public FolderPath LogDir {get;}
    
        public FolderPath DevDir {get;}
    }
}