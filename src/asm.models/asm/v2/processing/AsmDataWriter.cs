//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct AsmDataWriter : IWfActor
    {
        public IWfShell Wf {get;}

        readonly FilePath Target;

        readonly bool Append;

        public AsmDataWriter(IWfShell wf, FilePath dst, bool append)
        {
            Wf = wf;
            Target = dst;
            Append = append;
        }

        /// <summary>
        /// Saves the encoded data contained in an array of decoded functions
        /// </summary>
        /// <param name="src">The source functions</param>
        /// <param name="append">Whether to append to an existing file or else overwrite</param>
        public void Write(AsmRoutine[] src)
        {
            try
            {
                using var writer = Target.Writer();
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                    {

                    }
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void Dispose()
        {

        }
    }
}