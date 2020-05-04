//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    readonly struct AppMsgLog : IAppMsgLog
    {   
        public static IAppMsgLog Create(IAppEnv env)         
            => new AppMsgLog(env);
        
        readonly IAppEnv AppEnv;

        FilePath DefaultTarget => AppEnv.AppPaths.StandardLogPath;

        FilePath ErrorTarget => AppEnv.AppPaths.ErrorLogPath;
                
        [MethodImpl(Inline)]
        AppMsgLog(IAppEnv env)
        {
            this.AppEnv = env;
        }

        public void Deposit(IEnumerable<IAppMsg> src)
        {
            insist(src !=  null, $"Null enumerables are bad");
            insist(!src.Any(m => m == null),"Null messages are bad");

            var errors = (from m in src
                            where m.IsError
                            select m.Format()).ToArray();
            
            if(errors.Length != 0)
                ErrorTarget.Append(errors);
                                
            var standard = Formattable.items(src.Where(m => !m.IsError)).ToArray();

            if(standard.Length != 0)
                DefaultTarget.Append(standard);
        }

         public void Deposit(IAppMsg src)
         {
            var formatted = src.Format();
            if(src.IsError)
                ErrorTarget.Append(formatted);
            else
                DefaultTarget.Append(formatted);
        }
   }
}