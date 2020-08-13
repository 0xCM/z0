//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Reifies an application environment service predicated on environment variables
    /// </summary>
    public readonly struct Env
    {
        public FolderPath LogDir {get;}
    
        public FolderPath DevDir {get;}        

        public const string LogDirName = "ZLogs";

        public const string DevDirName = "ZDev";

        [MethodImpl(Inline)]
        public static EnvVar define(string name, string value)
            => new EnvVar(name,value);

        [MethodImpl(Inline)]
        public static EnvVar<T> define<T>(string name, T value)
            => new EnvVar<T>(name,value);
        
        [MethodImpl(Inline)]
        public static EnvVar readvar(string name) 
            => new EnvVar(name, Environment.GetEnvironmentVariable(name));
        
        public static Env read()
        {
            var log = readvar(LogDirName).Transform(FolderPath.Define);
            var dev = readvar(DevDirName).Transform(FolderPath.Define);
            return new Env(log,dev);
        }
        
        public static Env Current
            => read();

        internal Env(EnvVar<FolderPath> log, EnvVar<FolderPath> dev)
        {
            LogDir = log;
            DevDir = dev;
        }
    }
}