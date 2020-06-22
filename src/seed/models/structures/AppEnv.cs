//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public readonly struct EnvVarNames
    {
        public const string LogDir = "ZLogs";
        
        public const string DevDir = "ZDev";
    }

    /// <summary>
    /// Reifies an application evironment service predicated on environment variables
    /// </summary>
    public readonly struct Env : TAppEnv
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