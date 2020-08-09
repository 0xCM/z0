//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;

    sealed class TableShell : Shell<TableShell>
    {
        public override void RunShell(params string[] args)
        {

            //IntrinsicsEmitter.create().Emit();

            var provider = TableProvider.create();


            foreach(var entry in provider.Provided)
            {

               term.print(entry.Format());  
            }

        }


        public static void Main(params string[] args)
            => TableShell.Launch(args);

        
        protected override void OnDispose()
        {

        }
    }
}