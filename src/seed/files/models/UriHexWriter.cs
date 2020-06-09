//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RecordWriter<F,R> : IFileStreamWriter<R>
        where F : unmanaged, Enum
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}
        


        [MethodImpl(Inline)]
        internal RecordWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public void Delimit<T>(F field, T content)
            where T : ITextual
        {

        }

        [MethodImpl(Inline)]
        public void Write(R src)
        {

        }

        public void Write(R[] src)
        {

        }        
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}