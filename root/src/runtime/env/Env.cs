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
        public const string RunDir = "ZLogs";
        
        public const string DevDir = "ZDev";
    }

    public readonly struct Env
    {
        public static Env Current
        {
            get
            {
                var run = EnvVar.Read(EnvVarNames.RunDir).Transform(FolderPath.Define);
                var dev = EnvVar.Read(EnvVarNames.DevDir).Transform(FolderPath.Define);
                return new Env(run,dev);
            }
        }

        Env(EnvVar<FolderPath> run, EnvVar<FolderPath> dev)
        {
            this.RunDir = run;
            this.DevDir = dev;
        }

        public EnvVar<FolderPath> RunDir {get;}
    
        public EnvVar<FolderPath> DevDir {get;}
    }
}