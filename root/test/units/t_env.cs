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
            var rundir = Env.Current.RunDir;
            var rundir_expect = EnvVar.Define(EnvVarNames.RunDir, FolderPath.Define(Environment.GetEnvironmentVariable(EnvVarNames.RunDir)));
            Claim.exists(rundir);
            Claim.eq(rundir_expect, rundir);

            var paths = Context.Paths;
            Claim.eq(rundir_expect, paths.GlobalRootDir);  
                                  
        }
    }
}