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

    using static Konst;
    using static Memories;

    readonly struct AppMsgLog : IAppMsgLog
    {   
        public static IAppMsgLog Create(TAppEnv env)         
            => new AppMsgLog(env);
        
        readonly TAppEnv AppEnv;

        FilePath DefaultTarget 
            => AppEnv.AppPaths.TestStandardPath;

        FilePath ErrorTarget 
            => AppEnv.AppPaths.TestErrorPath;
                
        [MethodImpl(Inline)]
        AppMsgLog(TAppEnv env)
        {
            AppEnv = env;
        }

        public void Deposit(IEnumerable<IAppMsg> src)
        {
            insist(src !=  null, $"Null enumerables are bad");
            insist(!src.Any(m => m == null),"Null messages are bad");

            var errors = (from m in src where m.IsError select m.Format()).Array();        
            if(errors.Length != 0)
                ErrorTarget.Append(errors);
                                
            var standard = Formattable.items(src.Where(m => !m.IsError)).Array();
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