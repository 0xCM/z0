//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class t_env : UnitTest<t_env>
    {

        public void t_env_read()
        {
            var rundir = Env.Current.LogDir;
            var rundir_expect = EnvVar.Define(EnvVarNames.LogDir, FolderPath.Define(Environment.GetEnvironmentVariable(EnvVarNames.LogDir)));
            Claim.exists(rundir);
            Claim.eq(rundir_expect, rundir);

            var paths = Context.Paths;
            Claim.eq(rundir_expect, paths.Root);  
                                  
        }
    }
}